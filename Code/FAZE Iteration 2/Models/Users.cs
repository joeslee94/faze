using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAZE.Models
{
    //[Index(nameof(UserId), nameof(UserName))]
    public class Users : IdentityUser
    {
        public override string Id { get; set; }
        public override string UserName { get; set; }
        public string Password { get; set; }
        public override string Email { get; set; }
        public string Initials { get; set; }
        public ICollection<FishingTrip> Trips { get; set; }

        public Users()
        {

        }

    }
}
