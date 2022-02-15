using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX4
    {
        public static void ex4()
        {
            Console.WriteLine("Insira o numero para visualizar sua tabuada: ");
            int num = System.Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(String.Format("{0} * {1} = {2}", num, i, (num*i)));
            }
        }
    }
}
