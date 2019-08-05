using ScreenProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class EventField: IBaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ? EventId { get; set; }
        public int TemplateFieldId { get; set; }
        public string Value { get; set; }

        public Event MyEvent { get; set; }
        public TemplateField MyTemplateField { get; set; }

        
    }
}
