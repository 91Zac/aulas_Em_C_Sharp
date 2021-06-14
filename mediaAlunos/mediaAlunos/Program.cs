using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, soma, media, ntrec, nfinal;

            Console.WriteLine("Digite a primeira nota");

            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");

            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");

            num3 = Convert.ToDouble(Console.ReadLine());

            soma = num1 + num2 + num3;

            media = soma / 3;

            Console.WriteLine("A média do aluno é: " + media);

            Console.ReadKey();

            if (media >= 6)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else if (media < 6 && media >= 2)
            {
                Console.WriteLine("Aluno de Exame");
                Console.WriteLine("Digite a nota da atividade de Recuperação");
                ntrec = Convert.ToDouble(Console.ReadLine());
                nfinal = (ntrec + media) / 2;

                if (nfinal >= 6)
                {
                    Console.WriteLine("Aluno Aprovado");
                }

                else
                {
                    Console.WriteLine("Aluno Reprovado");
                }
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
            Console.ReadKey();
        }
    }
}
