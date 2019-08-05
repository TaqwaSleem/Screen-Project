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

    public class TemplateController : Controller
    {
        private ITemplateRepo _ITemplateRepo;
        public TemplateController(ITemplateRepo ITemplateRepo)
        {
            _ITemplateRepo = ITemplateRepo;
        }


        [HttpGet]
        public List<Template> GetAll()
        {
            return _ITemplateRepo.GetAll();
        }

    }
}
