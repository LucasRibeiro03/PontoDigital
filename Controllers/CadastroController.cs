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
namespace PontoDigitalFinal.Controllers
{
    public class CadastroController: Controller
    {
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();
         public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(IFormCollection Form){
            CadastroModel cadastro = new CadastroModel();
            cadastro.Nome = Form["nome"];
            cadastro.Senha = Form["senha"];
            cadastro.Email = Form["email"];
            cadastro.Data = DateTime.Parse(Form["data"]);
            

            cadastroRepositorio.CadastrarNoCSV(cadastro);


            return RedirectToAction("Index","Home");
        }


    }
}