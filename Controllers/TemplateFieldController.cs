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

    public class TemplateFieldController : Controller
    {
        private ITemplateFieldRepo _ITemplateFieldRepo;
        public TemplateFieldController(ITemplateFieldRepo ITemplateFieldRepo)
        {
            _ITemplateFieldRepo = ITemplateFieldRepo;
        }


        [HttpGet]
        public List<TemplateField> GetAll()
        {
            return _ITemplateFieldRepo.GetAll();
        }
    }
}
