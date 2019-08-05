using Microsoft.EntityFrameworkCore;
using ScreenProject.Interfaces;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.persistant
{
    public class EventRepo : BaseRepo<Event>, IEventRepo
    {
        private MyAppContext _AppContext;

        public EventRepo(MyAppContext appContext) : base(appContext)
        {
            _AppContext = appContext;

        }


        public List<Event> GetAnnualMonthlyDailyAndOnce()
        {
            DateTime dateTime = DateTime.Now;
            string annual = dateTime.ToString("dd/MM");
            string monthly = dateTime.ToString("dd");
            string daily = dateTime.ToString("");
            string once = dateTime.ToString("dd / MM / yyyy");

            //return _AppContext.Events.Include(c => c.MyTemplate).Include(c => c.EventFields).Where(c => ((c.Date.ToString("dd/MM") == annual) && (c.Repeat == "annual"))||((c.Date.ToString("dd") == monthly) && (c.Repeat == "monthly"))||((c.Repeat == "daily"))||((c.Date.ToString("dd / MM / yyyy") == once) && (c.Repeat == "once"))).ToList();
            return _AppContext.Events.Include(c => c.MyTemplate).ThenInclude(t => t.TemplateFields)
             .Include(c => c.EventFields)
             .Where(c => ((c.Date.ToString("dd/MM") == dateTime.ToString("dd/MM")) && (c.Repeat == "annual")) || ((c.Date.ToString("dd") == monthly) && (c.Repeat == "monthly")) || ((c.Repeat == "daily")) || ((c.Date.ToString("dd / MM / yyyy") == once) && (c.Repeat == "once"))).ToList();
        }

        public List<Event> GetAllAnnual()
        {

            DateTime dateTime = DateTime.Now;
            string annual = dateTime.ToString("dd/MM");

            return _AppContext.Events.Include(c => c.MyTemplate).Include(c => c.EventFields).Where(c => (c.Date.ToString("dd/MM") == annual) && (c.Repeat == "annual")).ToList();

        }
        public List<Event> GetAllMonthly()
        {

            DateTime dateTime = DateTime.Now;
            string monthly = dateTime.ToString("dd");

            return _AppContext.Events.Include(c => c.MyTemplate).Include(c => c.EventFields).Where(c => (c.Date.ToString("dd") == monthly) && (c.Repeat == "monthly")).ToList();

        }

        public List<Event> GetAllDaily()
        {

            DateTime dateTime = DateTime.Now;
            string daily = dateTime.ToString("");

            return _AppContext.Events.Include(c => c.MyTemplate).Include(c => c.EventFields).Where(c =>(c.Repeat == "daily")).ToList();
            
        }

        public List<Event> GetAllOnce()
        {

            DateTime dateTime = DateTime.Now;
            string once = dateTime.ToString("dd / MM / yyyy");

            return _AppContext.Events.Include(c => c.MyTemplate).Include(c => c.EventFields).Where(c => (c.Date.ToString("dd / MM / yyyy") == once) && (c.Repeat == "once")).ToList();

        }
        public List<Event> GetAll()
        {
            return _AppContext.Events.ToList();
        }
    }
}
