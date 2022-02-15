using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX10
    {
        public static void ex10()
        {
            while (true)
            {
                double salario = 0;
                Console.WriteLine("Insira o salário para calcular o imposto de renda:");
                salario = System.Convert.ToDouble(Console.ReadLine());
                if (salario == 0) { break; }
                
                if (salario < 1903.98) { Console.WriteLine("Esse valor nao possui imposto."); }
                else if (salario > 1903.99 && salario < 2826.65)
                {
                    Console.WriteLine("Imposto que será aplicado: " + Math.Round(salario*(7.5/100),2));
                }
                else if (salario > 2826.66 && salario < 3751.05)
                {
                    Console.WriteLine("Imposto que será aplicado: " + Math.Round(salario*(15.0/100),2));
                }
                else if (salario > 3751.06 && salario <= 4664.68)
                {
                    Console.WriteLine("Imposto que será aplicado: " + Math.Round(salario * (22.5 / 100),2));
                }
                else if (salario > 4664.68 )
                {
                    Console.WriteLine("Imposto que será aplicado: " + Math.Round(salario * (27.5 / 100),2));
                }
            }
            
        }
    }
}
