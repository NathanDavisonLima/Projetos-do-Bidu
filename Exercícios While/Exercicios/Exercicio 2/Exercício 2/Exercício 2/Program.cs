using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int num = 1;

            while(cont <= 99)
            {
                num = num + 1 + cont;

                cont++;
            }
            Console.WriteLine("O resultado da soma dos números entre 1 e 100 é: {0}", num);
            Console.ReadKey();

        }
    }
}
