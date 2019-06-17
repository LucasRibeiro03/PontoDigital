using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace PontoDigitalFinal.Controllers
{
    public class ServicoController: Controller
    {
         public IActionResult Index()
        {
            ViewData["NomeView"] = "Servico";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}