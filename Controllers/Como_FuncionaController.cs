using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// Colocar o models quando criar
namespace PontoDigitalFinal.Controllers
{
    public class Como_FuncionaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Como_Funciona";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}