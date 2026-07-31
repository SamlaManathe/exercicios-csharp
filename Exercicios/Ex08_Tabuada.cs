using System;

class Ex08_Tabuada
{
    public static void Executar()
    {
        Console.Write("\nInsira um número: ");
        string? entrada = Console.ReadLine();

        if(decimal.TryParse(entrada, out decimal numero))
        {
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        else
        {
            Console.WriteLine("\nEntrada inválida!");
        }
    }
}