using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorista motorista = new Motorista();
            Carro carro = new Carro();
            carro.motorista = motorista;
            motorista.nome = "arthur";
            motorista.cnh = 300;
            carro.modelo = "golf sapão";
            carro.Exibir();
        }
        public class Motorista
        {
            public string nome;
            public int cnh;
        }
        public class Carro
        {
            public Motorista motorista;
            public string modelo;

            public void Exibir()
            {
                Console.WriteLine($"O nome do motorista é {motorista.nome} e a CNH é {motorista.cnh} e o modelo do carro é {modelo}");
            }
        }
    }
}
