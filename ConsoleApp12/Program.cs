using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.motorcarro();
        }
        public class Motor
        {
            public void ligamotor()
            {
                Console.WriteLine("motor ligado");
            }
        }
           public class Carro
            {
                public Motor motor;

                public Carro()
                {
                    motor = new Motor();
                }
                public void motorcarro()
                {
                    motor.ligamotor();
                }
            }
        
    }
}
