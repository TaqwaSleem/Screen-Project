using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.ViewModels
{
    public class EventFieldViewModel
    {

        public int Id { get; set; }
        public int? EventId { get; set; }
        public int TemplateFieldId { get; set; }
        public string Value { get; set; }

        public int TopPosition { get; set; }
        public int LeftPosition { get; set; }
        public int FontSize { get; set; }
        public string FontColor { get; set; }
        public string FontFamily { get; set; }
        public string FontWeight { get; set; }
        public string FontStyle { get; set; }
        


    }
}
