using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCS
{
    class EX11
    {
        public static void ex11()
        {
            string nome, escolha;
            int idade;
            Dictionary<String, int> infantilA = new Dictionary<String, int>();
            Dictionary<String, int> infantilB = new Dictionary<String, int>();
            Dictionary<string, int> juvenilA = new Dictionary<string,int>();
            Dictionary<String, int> juvenilB = new Dictionary<String,int>();
            Dictionary<String, int> adultos = new Dictionary<String, int>();

            while (true)
            {
                Console.WriteLine("Insira o nome do nadador: ");
                nome = Console.ReadLine();
                Console.WriteLine("Agora insira a idade dele: ");
                idade = System.Convert.ToInt32(Console.ReadLine());

                if (idade > 4 && idade <= 7 ) { infantilA.Add(nome, idade); }
                else if (idade > 7 && idade <= 11) { infantilB.Add(nome,idade); }
                else if (idade > 11 && idade <= 13) { juvenilA.Add(nome, idade); }
                else if (idade > 14 && idade <= 17) { juvenilB.Add(nome, idade); }
                else if (idade > 18) { adultos.Add(nome, idade); }

                Console.WriteLine("Deseja adicionar mais um nadador? Digite 'S'");
                escolha = Console.ReadLine().ToLower();

                if (escolha != "s") 
                {
                    if (infantilA.Count > 0)
                    {
                        foreach (var nadador in infantilA)
                        {
                            Console.WriteLine("Integrantes do grupo infantilA: ");
                            Console.WriteLine(String.Format("Nome: {0} | Idade: {1}", nadador.Key, nadador.Value));
                        }
                    }
                    if (infantilB.Count > 0)
                    {
                        foreach (var nadador in infantilB)
                        {
                            Console.WriteLine("Integrantes do grupo infantilB: ");
                            Console.WriteLine(String.Format("Nome: {0} | Idade: {1}", nadador.Key, nadador.Value));
                        }
                    }
                    if (juvenilA.Count > 0)
                    {
                        foreach (var nadador in juvenilA)
                        {
                            Console.WriteLine("Integrantes do grupo juvenilA: ");
                            Console.WriteLine(String.Format("Nome: {0} | Idade: {1}", nadador.Key, nadador.Value));
                        }
                    }
                    if (juvenilB.Count > 0)
                    {
                        foreach (var nadador in juvenilB)
                        {
                            Console.WriteLine("Integrantes do grupo juvenilB: ");
                            Console.WriteLine(String.Format("Nome: {0} | Idade: {1}", nadador.Key, nadador.Value));
                        }
                    }
                    if (adultos.Count > 0)
                    {
                        foreach (var nadador in adultos)
                        {
                            Console.WriteLine("Integrantes do grupo adultos: ");
                            Console.WriteLine(String.Format("Nome: {0} | Idade: {1}", nadador.Key, nadador.Value));
                        }
                    }

                    break; 
                }
            }

        }
    }
}
