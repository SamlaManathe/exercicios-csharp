using System;

class Ex15_MediaNotas
{
    public static void Executar()
    {
        decimal somaNotas = 0;

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"\nInsira a {i + 1}ª nota: ");
            string? entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out decimal nota))
            {
                somaNotas += nota;
            }
            else
            {
                Console.WriteLine("\nEntrada inválida, insira a nota novamente!");
                i--;
                continue;
            }
        }

        decimal mediaNotas = somaNotas / 8.0m;

        Console.WriteLine($"\nMédia das notas: {mediaNotas}");
    }
}