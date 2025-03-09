
using System;

class Program
{
    static void Main()
    {
        
        int[] D = new int[20];

        
        Console.WriteLine("Digite os 20 elementos do vetor D:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            D[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        Console.Write("Digite o valor de N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Encontrar os elementos maiores que N e compactar o vetor
        Console.WriteLine("\nVetor compactado (apenas elementos maiores que N):");
        bool encontrou = false; // Flag para verificar se algum elemento foi maior que N
        for (int i = 0; i < 20; i++)
        {
            if (D[i] > N)
            {
                Console.Write(D[i] + " ");
                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Nenhum elemento maior que N foi encontrado.");
        }
    }
}
