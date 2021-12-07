using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Entities;

namespace BlazorApp.Data
{
    public class AuctionService
    {
        private AuctionsDbContext _dbContext;
        public Transactions transactions;

        public AuctionService(AuctionsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void GetTransactions(int id)
        {
            transactions = _dbContext
                            .Transactions
                            .Where(p => p.AuctionsId == id && p.type == true)
                            .OrderByDescending(p => p.Id)
                            .FirstOrDefault();
        }

        public void AddTransaction(int auctionId, int userId,int price, bool type)
        {
            var auction = _dbContext
                           .Auctions
                           .Where(e => e.Id == auctionId)
                           .FirstOrDefault();
            if (auction.Date > DateTime.Now && auction.active == true)
            {
                var newTransaction = new Transactions()
                {
                    AuctionsId = auctionId,
                    userId = userId,
                    Price = price,
                    type = type,
                    date = DateTime.Now
                };
                _dbContext.Transactions.Add(newTransaction);
            }
            else //tutaj warunek, ktory bedzie sie wykonywal gdy aukcja zostala wczesniej zakonczona.. tak zeby wyswietlic info lub cos
            {

            }
            if (type == false || auction.Date <= DateTime.Now)
            {
                auction.active = false;
                _dbContext.Auctions.Update(auction);
            }
           
            _dbContext.SaveChanges();
            GetTransactions(auctionId);
        }
    }
}
