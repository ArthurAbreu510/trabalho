using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autor autor = new Autor();
            Livro livro = new Livro();
            autor.nome = "Arthur";
            autor.nacionalidade = "Brasil";
            livro.autor = autor;
            livro.titulo = "Voar Longe";
            livro.Exibir();
        }
        public class Autor
        {
            public string nome;
            public string nacionalidade;
        }
        public class Livro
        {
            public string titulo;
            public Autor autor;

            public void Exibir()
            {
                Console.WriteLine($"Nome autor: {autor.nome}, Nacionalidade: {autor.nacionalidade}, Titulo livro: {titulo}");
            }
        }
    }
    }
}
