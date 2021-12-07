using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Entities;

namespace BlazorApp.Data
{

    public interface ICheckValidAuctionsService
    {
        public List<Auctions> CheckAuctions(List<Auctions> auctions);
    }

    public class CheckValidAuctionsService: ICheckValidAuctionsService
    {
        public AuctionsDbContext _dbContext { get; set; }
        public CheckValidAuctionsService(AuctionsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Auctions> CheckAuctions(List<Auctions> auctions)
        {
            var invalidAuctions = auctions.Where(e => e.Date <= DateTime.Now).ToList();
            foreach (var item in invalidAuctions)
            {
                item.active = false;
            }
            _dbContext.Auctions.UpdateRange(invalidAuctions);
            _dbContext.SaveChanges();

            return auctions.Where(e => e.Date > DateTime.Now).ToList();
        }
    }
}
