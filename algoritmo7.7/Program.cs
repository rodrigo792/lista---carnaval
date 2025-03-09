
using System;

class Program
{
    static void Main()
    {
        // Declarar o vetor do gabarito da LOTO com 5 elementos
        int[] gabarito = new int[5];
        // Declarar o vetor da aposta com 10 elementos
        int[] aposta = new int[10];

        
        Console.WriteLine("Digite os 5 números do gabarito (de 1 a 60): ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1} do gabarito: ");
            gabarito[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        Console.WriteLine("Digite os 10 números da aposta (de 1 a 60): ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1} da aposta: ");
            aposta[i] = Convert.ToInt32(Console.ReadLine());
        }

      
        int pontos = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (gabarito[i] == aposta[j])
                {
                    pontos++;
                    break; 
                }
            }
        }

        
        Console.WriteLine($"O apostador acertou {pontos} pontos.");
    }
}
