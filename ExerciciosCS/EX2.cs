using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX2
    {
        /// <summary>
        /// Escreva um programa que leia: A quantidade de números que o usuário deseja informar;
        /// Leia cada número e informe a média aritmética e a soma deles.
        /// </summary>
        public static void ex2()
        {
            Console.WriteLine("Digite a quantidade de numeros que deseja inserir: ");
            int numQtd = System.Convert.ToInt32(Console.ReadLine());
            int soma = 0;
            for (int i = 0; i < numQtd; i++)
            {
                Console.WriteLine(String.Format("Digite o {0} numero: ", i+1));
                soma += System.Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Media aritmetica: " + ((double)soma / numQtd));
        }
    }
}
