using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computador computador = new Computador();
            computador.iniciarprocessador();
        }
        public class Processador
        {
            public void iniciar()
            {
                Console.WriteLine("processador iniciado");
            }
        }
        public class Computador
        {
            public Processador Processador;

            public Computador()
            {
                Processador = new Processador();
            }
            public void iniciarprocessador()
            {
                Processador.iniciar();
            }
        }
    }
}
