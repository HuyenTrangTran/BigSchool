using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3_trang.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Require]
        [StringLength(255)]
        public string Name { get; set; }
        public async Task<ClaimIdentity> GenerateUserIdentinyAsync(UserManager)
    }
}