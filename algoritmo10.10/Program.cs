
using System;

class Program
{
    static void Main()
    {
        
        int[,] A = new int[4, 4];
        int somaHachurada = 0;

        
        Console.WriteLine("Digite os valores para a matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Calcular a soma das partes hachuradas (diagonais)
        for (int i = 0; i < 4; i++)
        {
            // Somando a diagonal principal (A[i,i])
            somaHachurada += A[i, i];

            // Somando a diagonal secundária (A[i, 3-i])
            somaHachurada += A[i, 3 - i];
        }

       
      
        somaHachurada -= A[1, 2]; // A célula central é A[1,2] (no índice 1 da linha e 2 da coluna)

        
        Console.WriteLine($"A soma das partes hachuradas da matriz é: {somaHachurada}");
    }
}
