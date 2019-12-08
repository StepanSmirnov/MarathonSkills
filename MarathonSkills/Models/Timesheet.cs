using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Timesheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimesheetId { get; set; }
        
        [Required]
        [ForeignKey("Staff")]
        public int StaffId { get; set; }

        public DateTime StartDateTime { get; set; }
        
        public DateTime EndDateTime { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? PayAmount { get; set; }
    }
}
