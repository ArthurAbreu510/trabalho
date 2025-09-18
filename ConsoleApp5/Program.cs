using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Empresa empresa = new Empresa();
            funcionario.nome = "arthur";
            funcionario.cargo = "zelador";
            empresa.NomeEmpresa = "senai";
            empresa.funcionario = funcionario;
            empresa.exibir();
        }
        public class Funcionario
        {
            public string nome;
            public string cargo;
        }
        public class Empresa
        {
            public string NomeEmpresa;
            public Funcionario funcionario;

            public void exibir()
            {
                Console.WriteLine($"O nome do Funcionario: {funcionario.nome}, o cargoé: {funcionario.cargo}, a empresa é: {NomeEmpresa}");
            }
        }
    }
}
