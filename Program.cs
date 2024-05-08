using System;
using System.Collections.Generic;

namespace ExemplosCSharp
{
    class Aluno
    {
        public string Nome { get; set; }
        public List<double> Notas { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Notas = new List<double>();
        }

        public double CalcularMedia()
        {
            if (Notas.Count == 0)
            {
                return 0;
            }

            double soma = 0;
            foreach (double nota in Notas)
            {
                soma += nota;
            }

            return soma / Notas.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();

            // Cadastro de alunos (exemplo)
            alunos.Add(new Aluno("João") { Notas = new List<double> { 9.0, 8.5, 7.0 } });
            alunos.Add(new Aluno("Maria") { Notas = new List<double> { 8.0, 9.5, 10.0 } });

            // Impressão de informações dos alunos
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Notas:");
                foreach (double nota in aluno.Notas)
                {
                    Console.WriteLine($"- {nota}");
                }
                Console.WriteLine($"Média: {aluno.CalcularMedia()}");
                Console.WriteLine();
            }
        }
    }
}
