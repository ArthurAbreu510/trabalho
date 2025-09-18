using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medico medico = new Medico();
            Paciente paciente = new Paciente();
            paciente.medico = medico;
            paciente.nomeP = "arthur";
            medico.nome = "afonso";
            medico.especialidade = "nariz";
            paciente.ExibirNomeP();
        }
        public class Medico
        {
            public string nome;
            public string especialidade;
        }
        public class Paciente
        {
            public string nomeP;
            public Medico medico; 

            public void ExibirNomeP()
            {
                Console.WriteLine($"O nome do medico :{medico.nome} ele e especialista em {medico.especialidade} o paciente e {nomeP}");
            }
        }
    }
}
