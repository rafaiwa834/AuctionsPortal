using BlazorApp.Entities;
using BlazorApp.Models;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public interface ILoginRegisterService
    {
        public void MarkUserLoggedOut();
        public Task<bool> MarkUserAsAuthenticated(UserLog user);
    }
    public class LoginRegisterService: AuthenticationStateProvider, ILoginRegisterService
    {
        private ISessionStorageService _sessionStorage;
        private AuctionsDbContext _auctionsDbContext;
        private NavigationManager _navigationManager;
        private IPasswordHasher<User> _passwordHasher;
        public LoginRegisterService(ISessionStorageService sessionStorage, AuctionsDbContext auctionsDbContext, NavigationManager navigationManager, IPasswordHasher<User> passwordHasher)
        {
            _sessionStorage = sessionStorage;
            _auctionsDbContext = auctionsDbContext;
            _navigationManager = navigationManager;
            _passwordHasher = passwordHasher;
        }

        public void AddUser(User user)
        {
            user.Date = DateTime.Now;
            user.PasswordHash = _passwordHasher.HashPassword(user, user.PasswordHash);
            _auctionsDbContext.Users.Add(user);
            _auctionsDbContext.SaveChanges();
            _navigationManager.NavigateTo("/");
        }


        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var userId =  await _sessionStorage.GetItemAsync<string>("userId");
            var logDate =  await _sessionStorage.GetItemAsync<string>("logDate");
            var role = await _sessionStorage.GetItemAsync<string>("role");

            ClaimsIdentity identity;
            if (userId != null)
            {
                identity = new ClaimsIdentity(new[]
               {
                new Claim(ClaimTypes.Email, userId),
                new Claim(ClaimTypes.Name, logDate),
                new Claim(ClaimTypes.Role, role)
                 }, "apiauth_type");
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }


        public async Task<bool> MarkUserAsAuthenticated(UserLog user)
        {

            var result = _auctionsDbContext.Users.Include(p => p.Role).FirstOrDefault(p => p.Email == user.Email);
           
            if (result != null)
            {
                var resultLog = _auctionsDbContext.CurrentLogs.FirstOrDefault(p => p.UserID == result.Id);
                var pass = _passwordHasher.VerifyHashedPassword(result, result.PasswordHash, user.PasswordHash);
                if (pass == PasswordVerificationResult.Success)
                {

                    if (resultLog != null)
                    {
                        _auctionsDbContext.CurrentLogs.Remove(resultLog);
                        _auctionsDbContext.SaveChanges();
                    }

                    CurrentLog currentUser = new CurrentLog();

                    currentUser.UserID = result.Id;
                    currentUser.Date = DateTime.Now;

                    _auctionsDbContext.CurrentLogs.Add(currentUser);
                    _auctionsDbContext.SaveChanges();

                    await _sessionStorage.SetItemAsync("userId", result.Id);
                    await _sessionStorage.SetItemAsync("logDate", currentUser.Date.ToString());
                    await _sessionStorage.SetItemAsync("role", result.Role.Name);

                    var identity = new ClaimsIdentity(new[]
                    {
                    new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()),
                    new Claim(ClaimTypes.Name, currentUser.Date.ToString()),
                    new Claim(ClaimTypes.Role, result.Role.Name)
                    }, "auth");

                    var userLog = new ClaimsPrincipal(identity);

                    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(userLog)));

                    _navigationManager.NavigateTo("/");
                    return await Task.FromResult(true);
                }

                return await Task.FromResult(false);
            }
            else
            {
                return await Task.FromResult(false);
            }


        }


        public void MarkUserLoggedOut()
        {
            _sessionStorage.RemoveItemAsync("userId");
            _sessionStorage.RemoveItemAsync("logDate");
            _sessionStorage.RemoveItemAsync("role");
            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
