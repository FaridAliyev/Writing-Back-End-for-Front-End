﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Degree
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; }
        public ICollection<TeacherDegree> TeacherDegrees { get; set; }
    }
}
