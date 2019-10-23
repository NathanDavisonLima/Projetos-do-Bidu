using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int cont = 1;

            while(cont <= 10000)
            {
                num = num + 1;

                Console.WriteLine(num);

                cont++;
            }
            Console.ReadKey();
        }
    }
}
