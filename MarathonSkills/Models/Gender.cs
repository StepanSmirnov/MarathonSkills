using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Gender
    {
        [Key]
        [StringLength(10)]
        public string Gender { get; set; }
    }
}
