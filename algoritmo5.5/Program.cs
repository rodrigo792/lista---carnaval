
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Responda as perguntas abaixo com 'sim' ou 'não'.");

        // Pergunta 1: É mamífero?
        Console.Write("É mamífero? ");
        string resposta = Console.ReadLine().ToLower();

        if (resposta == "sim")
        {
            // Pergunta 2: É quadrúpede?
            Console.Write("É quadrúpede? ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                // Pergunta 3: É carnívoro?
                Console.Write("É carnívoro? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    // O animal é o leão
                    Console.WriteLine("O animal escolhido foi o leão.");
                }
                else
                {
                    // Pergunta 4: É herbívoro?
                    Console.Write("É herbívoro? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        // O animal é o cavalo
                        Console.WriteLine("O animal escolhido foi o cavalo.");
                    }
                    else
                    {
                        // O animal é o homem
                        Console.WriteLine("O animal escolhido foi o homem.");
                    }
                }
            }
            else
            {
                // Pergunta 5: O animal pode voar?
                Console.Write("O animal pode voar? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    // O animal é o morcego
                    Console.WriteLine("O animal escolhido foi o morcego.");
                }
                else
                {
                    // O animal é o macaco
                    Console.WriteLine("O animal escolhido foi o macaco.");
                }
            }
        }
        else
        {
            // Pergunta 6: O animal vive na água?
            Console.Write("O animal vive na água? ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                // Pergunta 7: O animal é grande?
                Console.Write("O animal é grande? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    // O animal é a baleia
                    Console.WriteLine("O animal escolhido foi a baleia.");
                }
                else
                {
                    // O animal é o pinguim
                    Console.WriteLine("O animal escolhido foi o pinguim.");
                }
            }
            else
            {
                // Pergunta 8: O animal pode voar?
                Console.Write("O animal pode voar? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    // O animal é a águia
                    Console.WriteLine("O animal escolhido foi a águia.");
                }
                else
                {
                    // O animal é o avestruz
                    Console.WriteLine("O animal escolhido foi o avestruz.");
                }
            }
        }
    }
}
