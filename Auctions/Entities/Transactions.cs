using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class Transactions
    {
        public int Id { get; set; }
        public int AuctionsId { get; set; }
        public int userId { get; set; }
        //typ ma okreslac czy jest to licytacja czy kup teraz, true- licytacja, false- kup teraz
        public bool type { get; set; }
        public DateTime date { get; set; }
        public int Price { get; set; }
    }
}
