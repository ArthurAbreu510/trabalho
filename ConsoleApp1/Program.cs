using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            professor.nome = "Ronaldo";
            professor.especialidade = "Calculos";
            Disciplina disciplina = new Disciplina();
            disciplina.professor = professor;
            disciplina.nomedisciplina = "Matematica";
            disciplina.Exibir();
        }
        public class Professor
        {
            public string nome;
            public string especialidade;
        }
        public class Disciplina
        {
            public string nomedisciplina;
            public Professor professor;

            public void Exibir()
            {
                Console.WriteLine($"Nome disciplina: {nomedisciplina}, Professor responsavel: {professor.nome}, especialidade: {professor.especialidade}");
            }
        }
    }
    
}
