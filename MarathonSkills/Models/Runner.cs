using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Runner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RunnerId { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required]
        [StringLength(100)]
        [ForeignKey("Gender")]
        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        [ForeignKey("Country")]
        [StringLength(3)]
        public string CountryCode { get; set; }

        public virtual User User { get; set; }
    }

}
