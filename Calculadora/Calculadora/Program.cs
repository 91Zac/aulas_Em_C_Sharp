using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            String operador;
            double num1, num2, resultado;

            Console.WriteLine("Digite o primeiro valor");

            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecione o oporador");

            Console.WriteLine("Digite o segundo valor");

            num2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();

            if (operador == "+")
            {
                resultado= num1+num2;
                Console.WriteLine(resultado);
            }
            else if (operador == "-")
            {
                resultado= num1-num2;
                Console.WriteLine(resultado);
            }   
            else if (operador == "*")
            {
                resultado= num1*num2;
                Console.WriteLine(resultado);
            }
                else if(operador == "/")
            {
                resultado= num1/num2;
                Console.WriteLine(resultado);
            }
            
            Console.ReadKey();
        }
    }
}
