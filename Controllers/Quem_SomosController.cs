using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace PontoDigitalFinal.Controllers
{
    public class Quem_SomosController: Controller
    {
         public IActionResult Index()
        {
            ViewData["NomeView"] = "Quem_Somos";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}