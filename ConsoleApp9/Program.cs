using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cantor cantor = new Cantor();
            Musica musica = new Musica();
            musica.cantor = cantor;
            cantor.nome = "arthur";
            cantor.EstiloMusical = "pagode";
            musica.titulo = "pagode do arthur";
            musica.Exibir();
        }
        public class Cantor
        {
            public string nome;
            public string EstiloMusical;
        }
        public class Musica
        {
            public Cantor cantor;
            public string titulo;

            public void Exibir()
            {
                Console.WriteLine($"nome do cantor {cantor.nome} estilo musical {cantor.EstiloMusical} o titulo da musica é {titulo}");
            }
        }
    }
}
