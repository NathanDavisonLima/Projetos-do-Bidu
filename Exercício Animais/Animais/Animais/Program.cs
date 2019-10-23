using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;

            Console.WriteLine("O animal é um mamifero?");
            resp = Console.ReadLine();
            if (resp == "sim")
            {
                Console.WriteLine("O animal é quadrúpede?");
                resp = Console.ReadLine();
                if (resp == "sim")
                {
                    Console.WriteLine("O animal é carnívoro?");
                    resp = Console.ReadLine();
                    if (resp == "sim")
                    {
                        Console.WriteLine("O animal é um Leão");
                    }
                    else
                    {
                        Console.WriteLine("O animal é um Cavalo");
                    }
                }
                else
                {
                    Console.WriteLine("O animal é bípede?");
                    resp = Console.ReadLine();
                    if (resp == "sim")
                    {
                        Console.WriteLine("O animal é onívoro?");
                        resp = Console.ReadLine();
                        if (resp == "sim")
                        {
                            Console.WriteLine("O animal é um Homem");
                        }
                        else
                        {
                            Console.WriteLine("O animal é um Macaco");
                        }
                    }
                    else
                    {
                        Console.WriteLine("O animal é voador?");
                        resp = Console.ReadLine();
                        if (resp == "sim")
                        {
                            Console.WriteLine("O animal é um Morcego");
                        }
                        else
                        {
                            Console.WriteLine("O animal é uma Baleia");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("O animal é uma ave?");
                resp = Console.ReadLine();
                if (resp == "sim")
                {
                    Console.WriteLine("É do tipo não-voadora?");
                    resp = Console.ReadLine();
                    if (resp == "sim")
                    {
                        Console.WriteLine("O animal é tropical?");
                        resp = Console.ReadLine();
                        if (resp == "sim")
                        {
                            Console.WriteLine("O animal é um Avestruz");
                        }
                        else
                        {
                            Console.WriteLine("O animal é um Pinguim");
                        }
                    }
                    else
                    {
                        Console.WriteLine("É uma ave nadadora?");
                        resp = Console.ReadLine();
                        if (resp == "sim")
                        {
                            Console.WriteLine("O animal é um Pato");
                        }
                        else
                        {
                            Console.WriteLine("O animal é uma Águia");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("O animal é um réptil?");
                    resp = Console.ReadLine();
                    if (resp == "sim")
                    {
                        Console.WriteLine("O animal tem casco?");
                        resp = Console.ReadLine();
                        if (resp == "sim")
                        {
                            Console.WriteLine("O animal é uma Tartaruga");
                        }
                        else
                        {
                            if (resp == "nao")
                            {
                                Console.WriteLine("O animal é carnivoro?");
                                resp = Console.ReadLine();
                                if (resp == "sim")
                                {
                                    Console.WriteLine("O animal é um Crocodilo");
                                }
                                else
                                {
                                    Console.WriteLine("O animal é uma Cobra");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Animal Inexistente");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
