using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Marathon
    {
        [Key]
        public int MarathonId { get; set; }

        [Required]
        [StringLength(80)]
        public string MarathonName { get; set; }

        [StringLength(80)]
        public string CityName { get; set; }

        [ForeignKey("Country")]
        [Required]
        [StringLength(3)]
        public string CountryCode { get; set; }

        public int YearHeld { get; set; }

    }
}
