using ScreenProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class EventField: IBaseModel
    {
        public int Id { get; set; }
        public int ? EventId { get; set; }
        public int TemplateFieldId { get; set; }
        public int Value { get; set; }

        public Event MyEvent { get; set; }
        public TemplateField MyTemplateField { get; set; }


    }
}
