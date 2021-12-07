using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class CurrentLog
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }
    }
}
