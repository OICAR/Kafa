using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    
    public class HomeController : Controller
    {

        public HomeController( )
        {
         
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
          
        }

    }
}
