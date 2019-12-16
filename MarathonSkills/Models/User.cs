using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class User: IdentityUser
    {
        [StringLength(80)]
        public string FirstName { get; set; }
        
        [StringLength(80)]
        public string LastName { get; set; }

        public virtual Runner Runner { get; set; }
    }
}
