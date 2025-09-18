using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Curso curso = new Curso();
            curso.aluno = aluno;
            aluno.nome = "arthur";
            aluno.matricula = 3480;
            curso.NomeCurso = "senai";
            curso.Exibir();
        }
        public class Aluno
        {
            public string nome;
            public int matricula;
        }
        public class Curso
        {
            public Aluno aluno;
            public string NomeCurso;

            public void Exibir()
            {
                Console.WriteLine($"o nome do aluno e {aluno.nome} a matricula e {aluno.matricula} o nome do curso e {NomeCurso}");
            }
        }
    }
}
