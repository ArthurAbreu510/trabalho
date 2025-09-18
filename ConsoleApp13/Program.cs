using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();
            escola.iniciaraula();
        }
        public class SalaAula
        {
            public void Abrisala()
            {
                Console.WriteLine("sala de aula aberta");
            }
        }
        public class Escola
        {
            public SalaAula salaaula;

            public Escola()
            {
                salaaula = new SalaAula();
            }
            public void iniciaraula()
            {
                salaaula.Abrisala();
            }
        }
    }
}
