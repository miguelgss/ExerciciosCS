using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX7
    {
        public static void ex7()
        {
            int limite, num;
            int maior = 0;
            int menor = 1000000;
            Console.WriteLine("Quantos numeros deseja digitar?");
            limite = System.Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < limite; i++)
            {
                Console.WriteLine("Escreva um numero: ");
                num = System.Convert.ToInt32(Console.ReadLine());
                if (num > maior) { maior = num; }
                if (num < menor) { menor = num; }  
            }
            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);
        }
    }
}
