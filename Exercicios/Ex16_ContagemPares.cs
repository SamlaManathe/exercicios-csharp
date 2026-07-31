using System;

class Ex16_ContagemPares
{
    public static void Executar()
    {
        int quantidadePares = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"\nInsira o {i+1}º número: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                if (numero % 2 == 0)
                {
                    quantidadePares++;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida, insira um número!");
                i--;
                continue;
            }
        }
        Console.WriteLine($"\nQuantidade de números pares: {quantidadePares}");
    }
}