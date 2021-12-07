using BlazorApp.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class DisplayAuctionsService
    {
        private AuctionsDbContext _dbContext { get; set; }
        public List<Auctions> _auctions { get; set; }
        public ICheckValidAuctionsService _checkValidAuctionsService { get; set; }

        public DisplayAuctionsService(AuctionsDbContext dbContext, ICheckValidAuctionsService checkValidAuctionsService)
        {
            _dbContext = dbContext;
            _checkValidAuctionsService = checkValidAuctionsService;
        }
       

        public void GetAuctions(int userId=0)
        {
            _auctions = _dbContext
                   .Auctions
                   .Include(r => r.Images)
                   .Include(p=>p.Transaction.Where(r=>r.type == true))
                   .Include(k => k.FollowAuction.Where(p => p.UserId == userId))
                   .ToList();

            _auctions = _checkValidAuctionsService.CheckAuctions(_auctions);
        } 
        
        public void GetAuctionsByUser(int userId)
        {
            _auctions = _dbContext
                   .Auctions
                   .Where(p=>p.userID == userId)
                   .Include(p => p.Transaction.Where(r => r.type == true))
                   .Include(r => r.Images)
                   .ToList();
            _auctions = _checkValidAuctionsService.CheckAuctions(_auctions);
        } 
        
        public void GetAuctionsBySearch(string expression, int userId=0)
        {
            _auctions = _dbContext
                   .Auctions
                   .Where(p => p.Description.Contains(expression) == true || p.Title.Contains(expression) == true)
                   .Include(r => r.Images)
                   .Include(p => p.Transaction.Where(r => r.type == true))
                   .Include(k => k.FollowAuction.Where(p => p.UserId == userId))
                   .ToList();
            _auctions = _checkValidAuctionsService.CheckAuctions(_auctions);
        }

         public void GetFollowsAuctions(int userId=0)
        {
            _auctions = _dbContext
                   .Auctions
                   .Where(p=>p.FollowAuction.FirstOrDefault(e=>e.UserId == userId && e.Follow == true) != null)
                   .Include(p => p.Transaction.Where(r => r.type == true))
                   .Include(r => r.Images)
                   .Include(k => k.FollowAuction.Where(p => p.UserId == userId && p.Follow == true))
                   .ToList();
            _auctions = _checkValidAuctionsService.CheckAuctions(_auctions);
        }

        public void FollowAuction(int auctionId, int userId)
        {
            var auction = _dbContext
                          .FollowsAuctions
                          .FirstOrDefault(p => p.AuctionsId == auctionId && p.UserId == userId);
            if (auction !=null)
            {
                auction.Follow = !auction.Follow;
                _dbContext.Update(auction);
            }
            else
            {
                FollowAuction follow = new FollowAuction
                                    { UserId = userId,
                                    AuctionsId = auctionId,
                                    Follow = true };

                _dbContext.FollowsAuctions.Add(follow);
            }
            _dbContext.SaveChanges();
        }

        public void FiltersAuctions(Filters filters, int userId = 0)
        {
            filters.City = (filters.City=="Brak") ? null : filters.City;

            //filtracje po kategori jeszcze trzeba dodac ale to jak dodamy takie propertys do klasy Auctions
             _auctions = _dbContext
                   .Auctions
                   .Where(p=> filters.City == null || p.Location == filters.City)
                   .Where(p => filters.CategoryId == 0 || p.categoryID == filters.CategoryId)
                   .Where(p => filters.BuyNow == false || p.BuyNowPrice != 0)
                   .Where(p => filters.PriceFrom == 0 || p.StartPrice >= filters.PriceFrom)
                   .Where(p => filters.PriceTo == 0 || p.StartPrice <= filters.PriceTo)
                   .Include(r => r.Images)
                   .Include(k => k.FollowAuction.Where(p => p.UserId == userId))
                   .ToList();

            _auctions = _checkValidAuctionsService.CheckAuctions(_auctions);
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
