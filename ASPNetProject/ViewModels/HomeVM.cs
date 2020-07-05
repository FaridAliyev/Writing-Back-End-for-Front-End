﻿using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderText Content { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public About About { get; set; }
    }
}
