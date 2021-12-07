using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class Filters
    {
        public int PriceFrom { get; set; }
        public int PriceTo { get; set; }
        public string City { get; set; }
        public int CategoryId { get; set; }
        public bool BuyNow { get; set; }
    }
}
