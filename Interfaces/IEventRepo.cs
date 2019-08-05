using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Interfaces
{
    public interface IEventRepo : IBaseRepo<Event>
    {
        List<Event> GetAll();
        List<Event> GetAllAnnual();
        List<Event> GetAllMonthly();
        List<Event> GetAllDaily();
        List<Event> GetAllOnce();
        List<Event> GetAnnualMonthlyDailyAndOnce();
    }
}
