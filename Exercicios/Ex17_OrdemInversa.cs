using System;

class Ex17_OrdemInversa
{
    public static void Executar()
    {
        decimal[] numeros = new decimal[10];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"\nInsira o {i + 1}º número: ");
            string? entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out decimal numero))
            {
                numeros[i] = numero;
            }
            else
            {
                Console.WriteLine("\nEntrada inválida, insira um número!");
                i--;
                continue;
            }
        }

        Console.WriteLine("\n\n--- Ordem inversa dos números digitados ---\n");

        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write($"{numeros[i]}   ");
        }

        Console.WriteLine();
    }
}