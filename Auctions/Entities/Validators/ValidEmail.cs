using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities.Validators
{
    public class ValidEmail: ValidationAttribute
    {
        private AuctionsDbContext _dbContext = new AuctionsDbContext();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var currentemail = _dbContext.Users.Any(u => u.Email == value.ToString());
            if(currentemail == false)
            {
                return null;
            }


            return new ValidationResult("Istnieje konto o tym adresie email", new[] { validationContext.MemberName});
        }
    }
}
