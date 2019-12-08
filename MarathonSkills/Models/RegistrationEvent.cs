using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class RegistrationEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistrationEventId { get; set; }

        [Required]
        [ForeignKey("Registration")]
        public int RegistrationId { get; set; }

        [Required]
        [ForeignKey("Registration")]
        [StringLength(6)]
        public string EventId { get; set; }

        public int BibNumber { get; set; }

        public int RaceTime { get; set; }
    }
}
