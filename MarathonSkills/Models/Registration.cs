using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistrationId { get; set; }

        [Required]
        [ForeignKey("Runner")]
        public int RunnerId { get; set; }

        [Required]
        public DateTime RegistrationDateTime { get; set; }

        [Required]
        [ForeignKey("RaceKitOption")]
        public char RaceKitOptionId { get; set; }

        [Required]
        [ForeignKey("RegistrationStatus")]
        public int RegistrationStatusId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Cost { get; set; }

        [Required]
        [ForeignKey("Charity")]
        public int CharityId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal SponsorshipTarget { get; set; }
    }
}
