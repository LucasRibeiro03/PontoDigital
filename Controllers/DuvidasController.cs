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
namespace PontoDigitalFinal.Controllers
{
    public class DuvidasController: Controller
    {
        
        HomeViewModel homeViewModel = new HomeViewModel();
        DuvidasRepositorio duvidasRepositorio = new DuvidasRepositorio();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Duvidas";
            return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroDeDuvida(IFormCollection Form){
            DepoimentosModels duvida = new DepoimentosModels();
            duvida.Nome = Form["nome"];
            duvida.Titulo =  Form["titulo"];
            duvida.Texto = Form["texto"];
            duvidasRepositorio.DuvidasNoCSV(duvida);


            return RedirectToAction("Index","Duvidas");
        }
        public IActionResult ListarDuvidas(){
            homeViewModel.Duvidas = duvidasRepositorio.Listar();

            return View(homeViewModel);
        }
    }
}