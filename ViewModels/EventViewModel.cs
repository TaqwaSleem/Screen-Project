using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.ViewModels
{
    public class EventViewModel
    {

        public int Id { get; set; }
        public TimeSpan StartDate { get; set; }
        public TimeSpan EndDate { get; set; }

        public int Priority { get; set;}
        public string Name { get; set; }
        public string BackGroundImg { get; set; }
        public string Value { get; set; }


    }
}
