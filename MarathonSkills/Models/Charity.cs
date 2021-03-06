﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Charity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharityId { get; set; }
        
        [Required]
        [StringLength(maximumLength: 100)]
        public string CharityName { get; set; }
        
        [StringLength(maximumLength: 2000)]
        public string CharityDescription { get; set; }
       
        [StringLength(maximumLength: 50)]
        public string CharityLogo { get; set; }
    }
}
