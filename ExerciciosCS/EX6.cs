using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX6
    {
        public static void ex6()
        {
            string comando = "";
            string nome = "";
            double nota = 0;
            double notaTotal = 0;
            Dictionary<string, double> alunos = new Dictionary<string, double>();
            do
            {
                Console.WriteLine("Insira o nome do Aluno: ");
                nome = Console.ReadLine();
                for(int i = 0; i < 4; i++) 
                {
                    Console.WriteLine(String.Format("Insira a {0} nota: ", i + 1));
                    nota += System.Convert.ToDouble(Console.ReadLine());
                }

                alunos.Add(nome, nota / 4);

                nota = 0;
                Console.WriteLine("Digite 'finalizar' para ver os resultados da turma: ");
                comando = Console.ReadLine().ToLower();

                if (comando == "finalizar") 
                {
                    foreach(var aluno in alunos)
                    {
                        notaTotal += aluno.Value;
                    }
                    Console.WriteLine("Media de cada aluno: ");
                    foreach (var aluno in alunos)
                    {
                        Console.WriteLine(String.Format("{0} | Nota: {1}", aluno.Key, aluno.Value));
                    }
                    Console.WriteLine("Media de toda a turma: " + (notaTotal/alunos.Count));
                    Console.ReadKey();
                    break; 
                }
            } while (true);
        }
    }
}
