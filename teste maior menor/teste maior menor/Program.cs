using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_maior_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, maior = 0, menor = 0;
            Console.WriteLine("Digite o primeiro valor");
            num1 = Convert.ToDouble(Console.ReadLine());
            maior = num1;
            menor = num1;
            Console.WriteLine("Digite o segundo valor");
            num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 > num1)
            {
                maior = num2;
            }
            else
            {
                menor = num2;
            }
            Console.WriteLine("Digite o terceiro valor valor");
            num3 = Convert.ToDouble(Console.ReadLine());
            if (num3 > maior)
            {
                maior = num3;
            }
            else if (num3 < menor)
            {
                menor = num3;
            }
            Console.WriteLine("O MAIOR VALOR É " + maior + " E O MENOR VALOR É " + menor);
            Console.ReadKey();

        }
    }
}
