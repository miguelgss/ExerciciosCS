using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX9
    {
        public static void ex9()
        {
            int escolha, num1, num2, operacao = 0;
            char c = 'a';
            while (true)
            {
                Console.Write("1 - Adicao;" +
                    "\n2 - Subtracao;" +
                    "\n3 - Multiplicacao;" +
                    "\n4 - Divisao;" +
                    "Informe uma opcao:");
                escolha = System.Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira o numero 1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira o numero 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1) { operacao = num1 + num2; }
                if (escolha == 2) { operacao = num1 - num2; }
                if (escolha == 3) { operacao = num1 * num2; }
                if (escolha == 4) { operacao = num1 / num2; }

                Console.WriteLine("O resultado da operacao e: " + operacao);
                Console.WriteLine("Caso queira executar outra operacao, digite 'S'");
                c = System.Convert.ToChar(Console.ReadLine().ToLower());
                if (c != 's') { break; }
            }
            
        }
    }
}
