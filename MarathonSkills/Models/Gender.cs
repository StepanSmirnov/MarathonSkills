﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class Gender
    {
        [Key]
        [StringLength(10)]
        [Column(name: "Gender")]
        public string GenderName { get; set; }
    }
}
