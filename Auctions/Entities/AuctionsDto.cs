using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class AuctionsDto
    {
        public int userID { get; set; }
        
        [MaxLength(50)]
        [MinLength(5)]
        [Required]
        public string Title { get; set; }
        [MaxLength(1000)]
        [Required]
        [MinLength(10)]
        public string Description { get; set; }
        [Required]
        [Range(0, uint.MaxValue)]
        public int StartPrice { get; set; }
        [Required]
        [Range(0, uint.MaxValue)]
        public int BuyNowPrice { get; set; }
        [Required]
        [Range(1,100)]
        public int HowManyDays { get; set; }
        public string Location { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int phone { get; set; }
        [Required]
        public byte categoryId { get; set; }
    }
}
