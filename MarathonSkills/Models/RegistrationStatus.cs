using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class RegistrationStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistrationStatusId { get; set; }

        [Required]
        [StringLength(80)]
        [Column(name: "RegistrationStatus")]
        public string RegistrationStatusName { get; set; }
    }
}
