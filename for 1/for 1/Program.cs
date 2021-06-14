using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, maior = 0;
            for (int i = 0; i < 5; i++ )
            {
                Console.WriteLine("Digite um valor:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if(num1>maior)
                {
                    maior = num1;
                }
            }
            Console.WriteLine("O maior valor digitado foi " + maior);
            Console.ReadKey();
        }
    }
}
