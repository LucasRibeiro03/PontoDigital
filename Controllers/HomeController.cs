using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Http;
using PontoDigitalFinal.Models;
using PontoDigitalFinal.Repositorio;
using PontoDigitalFinal.ViewModels;
// Colocar o models quando criar
namespace PontoDigitalFinal.Controllers
{
    public class HomeController : Controller
    {
        
        HomeViewModel homeViewModel = new HomeViewModel();
        DuvidasRepositorio duvidasRepositorio = new DuvidasRepositorio();

        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_ADMIN = "_ADMIN";
        public IActionResult Index()
        {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_EMAIL);
            ViewData["Admin"] = HttpContext.Session.GetString (SESSION_ADMIN);
            
            homeViewModel.Duvidas = duvidasRepositorio.Listar();
            ViewData["NomeView"] = "Home";
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}