using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX8
    {
        public static void ex8()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(String.Format("{0} e multiplo de 3!", i));
                }
            }
        }
    }
}
