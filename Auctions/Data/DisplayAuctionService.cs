using BlazorApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class DisplayAuctionService
    {
        private AuctionsDbContext _dbContext;
        public Auctions auction;
        public ICheckValidAuctionsService _checkValidAuctionsService { get; set; }
        public DisplayAuctionService (AuctionsDbContext dbContext, ICheckValidAuctionsService checkValidAuctionsService)
            {
                _dbContext = dbContext;
                _checkValidAuctionsService = checkValidAuctionsService;
            }

        
        public void GetData(int id, int userId=0)
        {
            auction = _dbContext
                .Auctions
                .Include(p=>p.Images)
                .Include(p=>p.Transaction)
                .Include(p=> p.User)
                .Include(p=> p.User.CurrentLog)
                .Include(k => k.FollowAuction.Where(p => p.UserId == userId))
                .FirstOrDefault(p=>p.Id == id);
        }

        public void FollowAuction(int auctionId, int userId, bool type = false) //typ true jest przekazywany w przypadku licytacji uzytkownika bo wtedy ustawia z automatu na follow a nie na negacje tego co jest
        {
            var auction = _dbContext
                          .FollowsAuctions
                          .FirstOrDefault(p => p.AuctionsId == auctionId && p.UserId == userId);
            if (auction != null || type == false)
            {
                auction.Follow = !auction.Follow;
                _dbContext.FollowsAuctions.Update(auction);
            }
            else if(auction != null || type == true)
            {
                auction.Follow = true;
                _dbContext.FollowsAuctions.Update(auction);
            }
            else
            {
                FollowAuction follow = new FollowAuction
                {
                    UserId = userId,
                    AuctionsId = auctionId,
                    Follow = true
                };

                _dbContext.FollowsAuctions.Add(follow);
            }
            _dbContext.SaveChanges();
        }

        public string ImageToDisplay(byte[] image)
        {
            if (image != null)
            {
                var base64 = Convert.ToBase64String(image);
                var fs = string.Format("data:image/jpg;base64,{0}", base64);
                return fs;
            }
            return "";
        }
    }
}
