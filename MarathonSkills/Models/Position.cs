using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string PositionName { get; set; }
        
        [StringLength(1000)]
        public string PositionDescription { get; set; }
        
        [Required]
        [StringLength(10)]
        public string PayPeriod { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PayRate { get; set; }
    }
}
