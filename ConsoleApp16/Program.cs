using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisao televisao = new Televisao();
            televisao.assisti();
        }
        public class Controle
        {
            public void ligatv()
            {
                Console.WriteLine("a tv ligou");
            }
        }
        public class Televisao
        {
            public Controle controle;

            public Televisao()
            {
                controle = new Controle();
            }
            public void assisti()
            {
                controle.ligatv();
            }
        }

    }
}
