using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Ex11_SomaParadaZero
{
    public static void Executar()
    {
        int numero = 0;
        int soma = 0;

        do
        {
            Console.Write("\nInsira um número inteiro (0 - Encerrar): ");
            string? entrada = Console.ReadLine();

            if(!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("\nEntrada inválida!");
                numero = -1;
                continue;

            }
            soma += numero;

        } while (numero != 0);

        Console.WriteLine($"\nSoma dos números: {soma}");
    }
}