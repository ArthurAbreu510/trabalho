using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefone telefone = new Telefone();
            telefone.liga();
        }
        public class Chip
        {
            public void ativar()
            {
                Console.WriteLine("chip ativo");
            }
        }
        public class Telefone
        {
            public Chip chip;

            public Telefone()
            {
                chip = new Chip();
            }
            public void ativar()
            {
                chip.ativar ();
            }
        }
    }
}
