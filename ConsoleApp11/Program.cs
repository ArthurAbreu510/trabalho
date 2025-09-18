using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Casa casa = new Casa();
            casa.entrarcasa();
        }
        public class Porta
        {
            public void abrir()
            {
                Console.WriteLine("a porta foi aberta");
            }
        }
        public class Casa
        {
            public Porta porta;

            public Casa()
            {
                porta = new Porta();
            }
            public void entrarcasa()
            {
                porta.abrir();
            }
        }
    }
}
