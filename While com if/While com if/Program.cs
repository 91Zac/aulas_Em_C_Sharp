using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_com_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont = 0, maiores = 0;
            while (cont < 10)
            {
                Console.WriteLine("Qual a idade");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 18)
                {
                    maiores++;
                }
                cont++;
                Console.Clear();
            }
            Console.WriteLine(maiores + " Pessoas são maiores de idade");
            Console.ReadKey();
        }
    }
}
