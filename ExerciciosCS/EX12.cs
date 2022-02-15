using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX12
    {
        public static void ex12()
        {
            int num;
            int maior = 0;
            int menor = 1000000;
            while (true)
            {
                Console.WriteLine("Escreva um numero: ");
                num = System.Convert.ToInt32(Console.ReadLine());

                if (num > maior) { maior = num; }
                if (num < menor) { menor = num; }

                Console.WriteLine("Caso queira sair, digite 0: ");
                num = System.Convert.ToInt32((Console.ReadLine()));
                if (num == 0) { break; }
            }
            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);
        }
    }
}
