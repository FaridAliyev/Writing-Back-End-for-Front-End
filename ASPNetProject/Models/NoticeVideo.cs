﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class NoticeVideo
    {
        public int Id { get; set; }
        [Required,StringLength(300)]
        public string Source { get; set; }
    }
}
