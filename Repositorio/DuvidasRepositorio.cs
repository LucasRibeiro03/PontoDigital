using System;
using System.Collections.Generic;
using System.IO;
using PontoDigitalFinal.Models;

namespace PontoDigitalFinal.Repositorio
{
    public class DuvidasRepositorio
    {
        List<DepoimentosModels> Listadepoimentos = new List<DepoimentosModels>();

        DepoimentosModels depoimentosModels = new DepoimentosModels();
        private const string PATH = "DataBase/Depoimentos.csv";
        public void DuvidasNoCSV(DepoimentosModels depoimentos){
            if (File.Exists(PATH))
            {
                depoimentos.Id = File.ReadAllLines(PATH).Length + 1;
            }else{
                depoimentos.Id = 1;
            }
            depoimentos.ConfirmacaoAdm = 0;
            depoimentos.Data = DateTime.Now;
             StreamWriter sw = new StreamWriter(PATH,true);
            sw.WriteLine($"{depoimentos.Id};{depoimentos.Nome};{depoimentos.Titulo};{depoimentos.Texto};{depoimentos.Data.ToShortDateString()};{depoimentos.ConfirmacaoAdm}");
            sw.Close();
        }
        public List<DepoimentosModels> Listar(){

           

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");

                DepoimentosModels depoimentos = new DepoimentosModels();

                depoimentos.Id = int.Parse(dados[0]);
                depoimentos.Nome = dados[1];
                depoimentos.Titulo = dados[2];
                depoimentos.Texto = dados[3];
                depoimentos.Data = DateTime.Parse(dados[4]);
                depoimentos.ConfirmacaoAdm = int.Parse(dados[5]);
                
                Listadepoimentos.Add(depoimentos);
            }
            return Listadepoimentos;
        }
        public DepoimentosModels BuscarPorId(int id){
             List<DepoimentosModels> listaDeDepoimentos = Listar();

             foreach (var item in listaDeDepoimentos)
             {
                 if (id == item.Id)
                 {
                     return item;
                 }
             }
             return null;
        }
        public DepoimentosModels Aceitar(DepoimentosModels duvida){
            string[] linhas = File.ReadAllLines("DataBase/Depoimentos.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                if (string.IsNullOrEmpty(linhas[i]))
                {
                    continue;
                }
                string[] dadosDaLinha = linhas[i].Split(";");
                //Vamos veriricar se o id do usuario é igual ao da Linha;
                if(duvida.Id.ToString() == dadosDaLinha[0]){
                    linhas[i] = $"{duvida.Id};{duvida.Nome};{duvida.Titulo};{duvida.Texto};{duvida.Data.ToShortDateString()};1";
                    break;
                }
            }//fim do for
            File.WriteAllLines("DataBase/Depoimentos.csv", linhas);
            return duvida;
        
        
        }

        public DepoimentosModels Recusar(DepoimentosModels duvida){
            string[] linhas = File.ReadAllLines("DataBase/Depoimentos.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                if (string.IsNullOrEmpty(linhas[i]))
                {
                    continue;
                }
                string[] dadosDaLinha = linhas[i].Split(";");
                //Vamos veriricar se o id do usuario é igual ao da Linha;
                if(duvida.Id.ToString() == dadosDaLinha[0]){
                    linhas[i] = $"{duvida.Id};{duvida.Nome};{duvida.Titulo};{duvida.Texto};{duvida.Data.ToShortDateString()};2";
                    break;
                }
            }//fim do for
            File.WriteAllLines("DataBase/Depoimentos.csv", linhas);
            return duvida;
        }
    }
}