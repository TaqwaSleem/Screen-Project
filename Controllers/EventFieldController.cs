using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScreenProject.Interfaces;
using ScreenProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScreenProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EventFieldController : Controller
    {
        private IEventFieldRepo _IEventFieldRepo;
        public EventFieldController(IEventFieldRepo IEventFieldRepo)
        {
            _IEventFieldRepo = IEventFieldRepo;
        }


        [HttpGet]
        public List<EventField> GetAll()
        {
            return _IEventFieldRepo.GetAll();
        }
    }
}
