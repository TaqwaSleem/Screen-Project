using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ScreenProject.Interfaces;
using ScreenProject.Models;
using ScreenProject.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScreenProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EventController : Controller
    {
        private readonly IOptions<setData> _options;
        private IMapper _mapper;
        private IEventRepo _IEventRepo;
        public EventController(IEventRepo IeventRepo, IMapper mapper, IOptions<setData> options)
        {
            _IEventRepo = IeventRepo;
            _mapper = mapper;
            _options = options;

        }

        [HttpGet("setData")]
        public setData Get()        {            return _options.Value;        }

        // GET: api/<controller>
        [HttpGet("annual")]        public List<Event> GetAllAnnual()        {            return _IEventRepo.GetAllAnnual();        }

        [HttpGet("monthly")]        public List<Event> GetAllMonthly()        {            return _IEventRepo.GetAllMonthly();        }

        [HttpGet("daily")]        public List<Event> GetAllDaily()        {            return _IEventRepo.GetAllDaily();        }

        [HttpGet("once")]        public List<Event> GetAllOnce()        {            return _IEventRepo.GetAllOnce();        }

        //[HttpGet("GetAnnualMonthlyDailyAndOnce")]
        //public List<Event> GetAnnualMonthlyDailyAndOnce()
        //{
        //    return _IEventRepo.GetAnnualMonthlyDailyAndOnce();
        //}



        // GET: api/<controller>
        [HttpGet("GetAnnualMonthlyDailyAndOnce")]
        public List<EventViewModel> GetAnnualMonthlyDailyAndOnce()        {


            List<Event> eventList = _IEventRepo.GetAnnualMonthlyDailyAndOnce();
            List<EventViewModel> eventviewmodel = _mapper.Map<List<EventViewModel>>(eventList);

            return eventviewmodel;
            //return eventList;        }
        [HttpGet]
        public List<Event> GetAll()
        {
            return _IEventRepo.GetAll();
        }
        ////GET api/values/5
        //[HttpGet("{id}")]
        //public Event GetAll()
        //{
        //     Event event = Events.Where(c => c.Id == id).FirstOrDefault();

        //    return event;
        //}
    }
}
