using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    public static class Program
    {
        public static void Main (String[] args)
        {
            int opcao = 0;
            while (true) {
                Console.WriteLine("Insira o numero da atividade que deseja executar. " +
                    "\nCaso queira encerrar, digite 0: ");
                try { opcao = System.Convert.ToInt32(Console.ReadLine()); }
                catch ( Exception e ){ 
                    Console.WriteLine("O tipo de dado inserido não é compativel. Favor tente novamente.");
                }
                
                if (opcao == 0) { break; }
                if (opcao == 1) { EX1.ex1(); }
                if (opcao == 2) { EX2.ex2(); }
                if (opcao == 3) { EX3.ex3(); }
                if (opcao == 4) { EX4.ex4(); }
                if (opcao == 5) { EX5.ex5(); }
                if (opcao == 6) { EX6.ex6(); }
                if (opcao == 7) { EX7.ex7(); }
                if (opcao == 8) { EX8.ex8(); }
                if (opcao == 9) { EX9.ex9(); }
                if (opcao == 10) { EX10.ex10(); }
                if (opcao == 11) { EX11.ex11(); }
                if (opcao == 12) { EX12.ex12(); }
                if (opcao == 13) { EX13.ex13(); }
            }
            
        }
    }
}