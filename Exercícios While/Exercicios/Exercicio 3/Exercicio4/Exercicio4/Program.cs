using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cont = 1, qtdapares = 0, qtdaimpar = 0;

            while(cont <= 10)
            {
                Console.WriteLine("Informe o número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    qtdapares = qtdapares + 1;
                }
                else
                {
                    qtdaimpar = qtdaimpar + 1;
                }


                cont++;
            }

            Console.WriteLine("São {0} números pares e {1} números impares", qtdapares, qtdaimpar);


            Console.ReadKey();
        }
    }
}
