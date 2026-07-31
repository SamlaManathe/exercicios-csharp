using System;

class Ex09_SomaPares
{
    public static void Executar()
    {
        decimal soma = 0;

        for (int i = 1; i <= 100; i++)
        {
            if(i % 2 == 0)
            {
                soma += i;
            }
        }
        Console.WriteLine($"\nSoma dos números pares entre 1 e 100: {soma}");
    }
}