using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroDigitado;

            Console.WriteLine("Digite um numero");

            NumeroDigitado = Convert.ToInt32(Console.ReadLine());


            if (NumeroDigitado % 2 == 0)
            {
                Console.Clear();
                Console.WriteLine("O Número digitado é Par");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("O número digitado é Impar");
            }
            Console.ReadKey();
            

        }

    }

}