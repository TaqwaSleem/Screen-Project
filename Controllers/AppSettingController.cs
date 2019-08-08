using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScreenProject.Controllers{    [Route("api/[controller]")]    [ApiController]    public class AppSettingController : Controller    {        private readonly IConfiguration _configuration;        public AppSettingController(IConfiguration configuration)        {            _configuration = configuration;        }


        // GET: api/<controller>
        [HttpGet("SwappingTime")]        public String GetSwappingTime()        {            String SwappingTime = _configuration.GetSection("AppSetting").GetSection("SwappingTime").Value;            return SwappingTime;        }

        // GET: api/<controller>
        [HttpGet("DefulatImg")]        public String GetDefulatImg()        {            String DefulatImg = _configuration.GetSection("AppSetting").GetSection("DefulatImg").Value;            return DefulatImg;        }    }}