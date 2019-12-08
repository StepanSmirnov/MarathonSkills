using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Event
    {
        [Key]
        [StringLength(6)]
        public string EventId { get; set; }
        
        [StringLength(50)]
        [Required]
        public string EventName { get; set; }

        [StringLength(50)]
        [Required]
        [ForeignKey("EventType")]
        public string EventTypeId { get; set; }

        //[ForeignKey("EventTypeId")]
        //public EventType EventType { get; set; }

        [Required]
        [ForeignKey("Marathon")]
        public int MarathonId { get; set; }

        //[ForeignKey("MarathonId")]
        //public Marathon Marathon{ get; set; }

        public DateTime StartDateTime { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Cost { get; set; }

        public int? MaxParticipants { get; set; }
    }
}
