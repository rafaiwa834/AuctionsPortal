using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class UserLog
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
