using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class EventType
    {
        [Key]
        [StringLength(2)]
        public string EventTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string EventTypeName { get; set; }
    }
}
