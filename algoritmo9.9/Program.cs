
using System;

class Program
{
    static void Main()
    {
        
        double[] notas = new double[6];

     
        Console.WriteLine("Digite as 6 notas dos juízes (de 0 a 10):");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Nota do juiz {i + 1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }

       
        double maiorNota = notas[0];
        double menorNota = notas[0];
        for (int i = 1; i < 6; i++)
        {
            if (notas[i] > maiorNota)
                maiorNota = notas[i];

            if (notas[i] < menorNota)
                menorNota = notas[i];
        }

        // Calcular a soma das notas excluindo a maior e a menor
        double somaFinal = 0;
        for (int i = 0; i < 6; i++)
        {
            if (notas[i] != maiorNota && notas[i] != menorNota)
            {
                somaFinal += notas[i];
            }
        }

        
        Console.WriteLine($"A nota final do atleta, excluindo a maior e a menor nota, é: {somaFinal:F2}");
    }
}
