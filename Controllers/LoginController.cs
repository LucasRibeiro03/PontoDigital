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
    public class LoginController : Controller
    {

        private CadastroRepositorio UsuarioRepositorio = new CadastroRepositorio();



        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";



        //Aparecer View Na tela
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Login";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //Logar Formulario
        [HttpPost]
        public IActionResult LogarUsuario(IFormCollection form)
        {
            var usuario = form["email"];
            var senha = form["senha"];
            var cliente = UsuarioRepositorio.ObterPor(usuario);

            if (cliente != null && cliente.Senha.Equals(senha))
            {
                HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
            }



            if (cliente.AdmOuComum == 2)
            {
                return View("Administrador");
            }
            else if (cliente.AdmOuComum == 1)
            {

                return View("LogarUsuario");
            } 
            else
            {
                System.Console.WriteLine("Nenhum dos dois");
            }


            return View(usuario);
        }
        //Sair do Login
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }

}