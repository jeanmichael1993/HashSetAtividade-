using System;
using System.Collections.Generic;

namespace HashSetAtividade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> turmas = new List<string>() { "A", "B", "C" };
            HashSet<int> matriculados = new HashSet<int>();
            foreach (String turma in turmas)
            {
               Console.Write($"How many students for course {turma}?");
               int qtd = int.Parse(Console.ReadLine());
               for(int i=0;i<qtd;i++)
                {
                    matriculados.Add(int.Parse(Console.ReadLine()));
                }
                
            }
            Console.WriteLine($"Total students:{matriculados.Count}");

        }
    }
}
