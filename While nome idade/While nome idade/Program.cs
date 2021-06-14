using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_nome_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont = 0, maiores = 0;
            string nome = ("");
            while (cont < 10)
            {
                Console.WriteLine("Qual o nome");
                nome = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Qual a idade");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Olá " + nome + " sua idade é " + idade + " anos");
                Console.ReadKey();
                Console.Clear();
                if (idade >= 18)
                {
                    maiores++;
                }
                cont++;
                
            }
            Console.WriteLine(maiores + " Pessoas são maiores de idade");
            Console.ReadKey();
        }
    }
}
