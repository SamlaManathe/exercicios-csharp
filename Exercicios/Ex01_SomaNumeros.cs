using System;

class Ex01_SomaNumeros
{
    public static void Executar ()
    {
        int soma = 0;

        for(int i = 0; i < 2; i++)
        {
            Console.Write("\nInsira um número inteiro: ");
            string? entrada = Console.ReadLine();

            if(int.TryParse(entrada, out int numero))
            {
                soma += numero;
            }
            else
            {
                Console.WriteLine("\nEntrada inválida!");
                return;
            }
        } 

        Console.WriteLine($"\nSoma: {soma}");
    }
}