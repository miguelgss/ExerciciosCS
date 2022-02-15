using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX13
    {
        public static void ex13()
        {
            int anosTrabalhados = 0;
            decimal salarioInicial, salarioAtual = 0m;

            Console.Write("Informe os anos trabalhados: ");
            anosTrabalhados = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o salario inicial: ");
            salarioInicial = System.Convert.ToDecimal(Console.ReadLine());

            for (int i = 1; i <= anosTrabalhados; i++)
            {
                if (i < 3)
                {
                    salarioInicial += salarioInicial * 0.50m;
                }
                if (i >= 4)
                {
                    salarioInicial += salarioInicial;
                }
                if (i % 10 == 0)
                {
                    salarioInicial += salarioInicial * 0.10m;
                }
            }

            Console.WriteLine("Salario Atual desse funcionario e: " + Math.Round(salarioInicial,2));

        }
    }
}
