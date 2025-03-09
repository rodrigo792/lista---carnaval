
using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Informe a altura da pessoa (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o sexo da pessoa (M para masculino ou F para feminino): ");
        char sexo = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        double pesoIdeal = 0;

        // Calcular o peso ideal com base no sexo
        if (sexo == 'M')
        {
            // Fórmula para homens
            pesoIdeal = (72.7 * altura) - 58;
        }
        else if (sexo == 'F')
        {
            // Fórmula para mulheres
            pesoIdeal = (62.1 * altura) - 44.7;
        }
        else
        {
            Console.WriteLine("Sexo inválido! Informe 'M' para masculino ou 'F' para feminino.");
            return;
        }

        
        Console.WriteLine($"O peso ideal para uma pessoa de altura {altura:F2}m e sexo {sexo} é: {pesoIdeal:F2} kg");
    }
}
