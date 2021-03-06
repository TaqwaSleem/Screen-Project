﻿using ScreenProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class Template: IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BackGroundImg { get; set; }

        public ICollection<TemplateField> TemplateFields { get; set; }
        public ICollection<Event> Events { get; set; }

    }
}
