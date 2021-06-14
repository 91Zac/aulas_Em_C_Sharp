using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 0, var2 = 0, total = 0;
            do
            {
                try
                {
                    Console.WriteLine("Digite o primeiro número:");
                    var1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    var2 = Convert.ToInt32(Console.ReadLine());
                    total = var1 + var2;

                }
                catch
                {
                    Console.WriteLine("Valore precisam ser números");
                    var1 = -999;
                    var2 = -999;
                    total = 0;

                }
            } while (var1 == -999 && var2 == -999);
            Console.WriteLine("O total é " + total);
            Console.ReadKey();
        }
    }
}
