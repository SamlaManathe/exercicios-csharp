using System;

class Ex14_MaiorElemento
{
    public static void Executar()
    {
        decimal maior = decimal.MinValue;
        int posicao = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\nInsira o {i+1}º número: ");
            string? entrada = Console.ReadLine();

            if(decimal.TryParse(entrada, out decimal numero))
            {
                if(numero > maior) {
                    maior = numero;
                    posicao = i;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida!");
            }
        }
        Console.WriteLine($"\nMaior elemento: {maior}");
        Console.WriteLine($"Posição do elemento: {posicao+1}");
    }
}