using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador();
            Time time = new Time();
            time.jogador = jogador;
            jogador.nome = "Arthur";
            jogador.posicao = "volante";
            time.NomeTime = "milan";
            time.ExibirNomeTime();
        }
        public class Jogador
        {
            public string nome;
            public string posicao;
        }
        public class Time
        {
            public string NomeTime;
            public Jogador jogador;

            public void ExibirNomeTime()
            {
                Console.WriteLine($"Nome jogador {jogador.nome} Posição {jogador.posicao} e o time que joga é {NomeTime}");
            }
        }
    }
}
