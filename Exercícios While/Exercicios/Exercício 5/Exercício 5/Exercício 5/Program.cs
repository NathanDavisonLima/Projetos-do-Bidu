using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, somapar = 0;
            int cont = 85;

            while (cont <= 907)
            {
                Console.WriteLine("Informe o número: ");
                num = int.Parse(Console.ReadLine());

                if (cont  % 2 == 0)
                {
                    somapar = num + somapar;
                }
                else
                {
                    somaimpar = num + somaimpar;
                }


                cont++;
            }



            


            Console.ReadKey();
        }
    }
}
