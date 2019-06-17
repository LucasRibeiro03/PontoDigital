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


namespace PontoDigitalFinal.ViewModels
{
    public class HomeViewModel
    {
        
        public List<DepoimentosModels> Duvidas {get;set;}

        public List<DepoimentosModels> DuvidasListar {get;set;} 

        public List<CadastroModel> Cadastros {get;set;}
    }
}