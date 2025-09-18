using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diretor diretor = new Diretor();
            Filme filme = new Filme();
            filme.diretor = diretor;
            diretor.nome = "Arthur";
            diretor.nacionalidade = "brasil";
            filme.titulo = "carros";
            filme.exibir();
        }
        public class Diretor
        {
            public string nome;
            public string nacionalidade;
        }
        public class Filme
        {
          public Diretor diretor;
          public string titulo;

            public void exibir()
            {
                Console.WriteLine($"o nome do diretor do filme é {diretor.nome} e a nacionalidade dele é {diretor.nacionalidade} o titulo do filme é {titulo}");
            }
        }
        
    }
}
