using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, menor, maior;
            menor = 0;
            maior = 0;
            Console.WriteLine("Digite o primeiro valor");

            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");

            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor");

            num3 = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();


            if (num1 >= num2 && num1 >= num3)
            {
                maior = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                maior = num2;
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                maior = num3;
            }
            else if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
            }
            else if (num3 <= num1 && num2 <= num3)
            {
                menor = num3;
            }
            Console.WriteLine("O maior valor é " + maior);
            Console.WriteLine("O menor valor é " + menor);
            
            Console.ReadKey();

        }
    }
}
        
 
