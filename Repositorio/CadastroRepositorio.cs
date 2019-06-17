using System;
using System.Collections.Generic;
using System.IO;
using PontoDigitalFinal.Models;


namespace PontoDigitalFinal.Repositorio
{
    public class CadastroRepositorio
    {
        private const string PATH = "DataBase/Cadastros.csv";
        private const string PATH_ADMIN = "DataBase/Admins.csv";

        public void CadastrarNoCSV(CadastroModel cadastro)
        {
            cadastro.AdmOuComum = 1;
            if (File.Exists(PATH))
            {
                cadastro.Id = File.ReadAllLines(PATH).Length + 1;
            }
            else
            {
                cadastro.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{cadastro.Id};{cadastro.Nome};{cadastro.Senha};{cadastro.Email};{cadastro.Data.ToShortDateString()};{cadastro.AdmOuComum}");
            sw.Close();

        }

        public List<CadastroModel> Listar()
        {
            var lista = new List<CadastroModel>();
            if (!File.Exists(PATH))
            {
                return null;
            }
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                CadastroModel usuario = new CadastroModel();
                var dados = item.Split(";");
                usuario.Id = int.Parse(dados[0]);
                usuario.Nome = dados[1];
                usuario.Senha = dados[2];
                usuario.Email = dados[3];
                usuario.Data = DateTime.Parse(dados[4]);
                usuario.AdmOuComum = int.Parse(dados[5]);
                lista.Add(usuario);

            }
            return lista;
        }

        public List<CadastroModel> ListarAdm()
        {
            var lista = new List<CadastroModel>();
            if (!File.Exists(PATH_ADMIN))
            {
                return null;
            }
            var linhas = File.ReadAllLines(PATH_ADMIN);
            foreach (var item in linhas)
            {
                CadastroModel usuario = new CadastroModel();
                var dados = item.Split(";");
                usuario.Id = int.Parse(dados[0]);
                usuario.Nome = dados[1];
                usuario.Senha = dados[2];
                usuario.Email = dados[3];
                usuario.Data = DateTime.Parse(dados[4]);
                usuario.AdmOuComum = int.Parse(dados[5]);
                lista.Add(usuario);

            }
            return lista;
        }


        public CadastroModel ObterPor(string email)
        {
            var lista = Listar();

            foreach (var item in lista)
            {
                if (item != null && item.Email == email)
                {
                    return item;
                }
            }

            var listaAdmin = ListarAdm();

            foreach (var item in listaAdmin)
            {
                if (item != null && item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }


    }
}