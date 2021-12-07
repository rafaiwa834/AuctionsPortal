using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class Auctions
    {
        public int Id { get; set; }
        public int userID { get; set; }
        public string Title { get; set; }  
        public string Description { get; set; }
        public int StartPrice { get; set; }
        public int BuyNowPrice { get; set; }
        public int HowManyDays { get; set; }
        public string Location { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public byte categoryID { get; set; }
        public DateTime Date { get; set; }
        public bool active { get; set; }
        public virtual List<ImageName> Images { get; set; }
        public virtual User User { get; set; }
        public virtual List<FollowAuction> FollowAuction { get; set; }
        public virtual Categories Category { get; set; }
        public virtual List<Transactions> Transaction { get; set; }
    }
}
