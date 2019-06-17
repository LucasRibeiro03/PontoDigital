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
    public class AdministradorController :Controller
    {
        HomeViewModel homeViewModel = new HomeViewModel();
        AdmRepositorio admRepositorio = new AdmRepositorio();
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();

        DuvidasRepositorio duvidasRepositorio = new DuvidasRepositorio();
        public IActionResult Index()
        {
            
            ViewData["NomeView"] = "Administrador";
            homeViewModel.Duvidas = duvidasRepositorio.Listar();
            homeViewModel.Cadastros = admRepositorio.ListarAdm();
            homeViewModel.Cadastros = cadastroRepositorio.Listar();
            return View(homeViewModel);
        }
        [HttpGet]
        public IActionResult Aceitar (int id) {
            DepoimentosModels item = duvidasRepositorio.BuscarPorId (id);
            duvidasRepositorio.Aceitar(item);
            System.Console.WriteLine("Aceitou");
            return RedirectToAction ("Index");
        }
        public IActionResult Recusar (int id) {
            DepoimentosModels item = duvidasRepositorio.BuscarPorId (id);
            duvidasRepositorio.Recusar(item);
            
            System.Console.WriteLine("Recusou");
            return RedirectToAction ("Index");
        }
        public IActionResult CadastrarAdm(IFormCollection Form){
            CadastroModel cadastro = new CadastroModel();
            cadastro.Nome = Form["nome"];
            cadastro.Senha = Form["senha"];
            cadastro.Email = Form["email"];
            cadastro.Data = DateTime.Parse(Form["data"]);
            

            admRepositorio.CadastrarNoAdm(cadastro);


            return RedirectToAction("Index","Home");
    }
}
}

