using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PocketMenuUI.Infrastructure;
using PocketMenuUI.Services;
using PocketMenuUI.ViewModel;

namespace PocketMenuUI.Controllers
{
    public class ExcelController : Controller
    {

        private readonly IExcel _ExcelSvc;

        public ExcelController(IExcel excelSvc)
        {
            _ExcelSvc = excelSvc;
        }

        public async Task<ActionResult> Import()
        {

            _ExcelSvc.Get();
          
                return View();
        }


        public ActionResult Export(CatererViewModel caterer)
        {



            return View();
        }

    }
}