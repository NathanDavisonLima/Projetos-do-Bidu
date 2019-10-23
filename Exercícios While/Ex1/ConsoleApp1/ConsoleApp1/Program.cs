using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cont = 1;

            while (cont <= 3)
            {
                Console.WriteLine("Informe o número:");
                num = int.Parse(Console.ReadLine());

                if(num % 2 == 0)
                {
                    Console.WriteLine("O númer é par");
                }
                else
                {
                    Console.WriteLine("O número é impar");
                }
                cont = cont + 1; //cont += 1; ou cont++;
            }
            Console.ReadKey();
        } 
    }
}
