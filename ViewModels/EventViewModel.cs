﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.ViewModels
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public TimeSpan StartDate { get; set; }
        public TimeSpan EndDate { get; set; }
        public DateTime Date { get; set; }
        public string Repeat { get; set; }
        public int Priority { get; set; }


        public TemplateViewModel MyTemplate { get; set; }
        public ICollection<EventFieldViewModel> EventFields { get; set; }


    }
}
