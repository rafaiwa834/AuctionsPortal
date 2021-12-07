using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class FollowAuction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AuctionsId { get; set; }
        public bool Follow { get; set; }
    }
}
