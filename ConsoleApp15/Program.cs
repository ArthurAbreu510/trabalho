using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.Abrirlivro();
        }
        public class Pagina
        {
            public void Ler()
            {
                Console.WriteLine("pagina sendo lida");
            }
        }
            public class Livro
            {
                public Pagina pagina;

                public Livro()
                {
                    pagina = new Pagina();
                }
                public void Abrirlivro()
                {
                    pagina.Ler();
                }
            }
        
    }
}
