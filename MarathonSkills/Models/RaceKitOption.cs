using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class RaceKitOption
    {
        [Key]
        public char RaceKitOptionId { get; set; }

        [Required]
        [StringLength(80)]
        [Column(name: "RaceKitOption")]
        public string RaceKitOptionName { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal RaceKitCost { get; set; }
    }
}
