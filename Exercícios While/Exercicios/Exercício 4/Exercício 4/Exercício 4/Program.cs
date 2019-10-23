using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, somapar = 0, somaimpar = 0;
            int cont = 1;

            while (cont <= 10)
            {
                Console.WriteLine("Informe o número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    somapar = num + somapar; 
                }
                else
                {
                    somaimpar = num + somaimpar;
                }


                cont++;
            }



            Console.WriteLine("A soma dos números pares é de {0}, e a dos impares é de {1}.", somapar, somaimpar);


            Console.ReadKey();
        }
    }
}
