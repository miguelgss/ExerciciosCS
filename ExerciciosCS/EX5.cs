using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX5
    {
        public static void ex5()
        {
            int somaPar = 0; int somaImpar = 0;
            int num = 0;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(String.Format("Insira o {0} numero: ", i + 1));
                num = System.Convert.ToInt32(Console.ReadLine());
                if (num%2 == 0) 
                { 
                    somaPar += num; 
                }
                else 
                { 
                    somaImpar += num; 
                }
            }
            Console.WriteLine("Soma dos pares: " + somaPar);
            Console.WriteLine("Soma dos impares: " + somaImpar);
        }
    }
}
