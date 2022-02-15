using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXMeioDoCurso
{
    class matematica
    {
        public static int exponenciacao(int a, int b)
        {
            int resultado = 1;
            if (b != 0)
            {
                for (int i = 1; i <= b; i++)
                {
                    resultado = resultado * a;
                }
            }
            return resultado;
        }
    }
}
