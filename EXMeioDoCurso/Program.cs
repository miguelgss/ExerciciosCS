using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXMeioDoCurso
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            // S2E1
            string nome;
            int idade;
            int dataAtual = DateTime.Now.Year;
            // DateTime.Now.ToString("Y");

            Console.Write("Favor insira o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Favor insira a sua idade: ");
            idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine("Seu ano de nascimento e: " + (dataAtual - idade) +
                " ou " + (dataAtual - idade - 1));

            // S4E1
            int x = matematica.exponenciacao(2, 5);
            Console.WriteLine(String.Format("O resultado da potencia e: {0}", x));
        }
    }
}