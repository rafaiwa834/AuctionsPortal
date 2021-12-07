using BlazorApp.Entities.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        [ValidEmail]
        public string Email { get; set; }
        [Required]
        [MinLength(5)]
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public int RoleId { get; set; }
        public DateTime Date { get; set; }
        public virtual Role Role { get; set; }
        public virtual CurrentLog CurrentLog{ get; set; }
    }
}
