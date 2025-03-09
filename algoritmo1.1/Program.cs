
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Informe o preço atual do produto (R$): ");
        double precoAtual = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a venda média mensal do produto: ");
        int vendaMediaMensal = Convert.ToInt32(Console.ReadLine());

       
        double novoPreco = precoAtual;

        if (vendaMediaMensal < 500)
        {
            if (precoAtual < 30.00)
            {
                
                novoPreco = precoAtual * 1.10;
                Console.WriteLine($"O preço do produto será aumentado em 10%. Novo preço: R${novoPreco:F2}");
            }
            else
            {
                
                novoPreco = precoAtual * 0.80;
                Console.WriteLine($"O preço do produto será reduzido em 20%. Novo preço: R${novoPreco:F2}");
            }
        }
        else
        {
            if (precoAtual >= 30.00)
            {
               
                Console.WriteLine("O preço do produto não sofrerá reajuste.");
            }
        }
    }
}
