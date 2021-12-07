using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class ImageName
    {
        public int Id { get; set; }
        public int AuctionId { get; set; }
        public string ImageLocation { get; set; }
        public bool Main { get; set; }
        public virtual Auctions Auction { get; set; }
    }
}
