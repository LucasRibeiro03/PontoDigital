using System;
namespace PontoDigitalFinal.Models
{
    public class DepoimentosModels
    {
        public int Id{get;set;}
        
        public string Nome{get;set;}
        public string Titulo{get;set;}
        public string Texto{get;set;}
        public DateTime Data{get;set;}
        public int ConfirmacaoAdm {get;set;}
    }
}