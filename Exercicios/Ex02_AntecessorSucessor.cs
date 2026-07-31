using System;

class Ex02_AntecessorSucessor
{
    public static void Executar()
    {
        Console.Write("\nInsira um número inteiro: ");
        string? entrada = Console.ReadLine();

        if(int.TryParse(entrada, out int numero))
        {
            int antecessor = numero - 1;
            int sucessor = numero + 1;

            Console.WriteLine($"\nAntecessor: {antecessor}");
            Console.WriteLine($"\nNúmero digitado: {numero}");
            Console.WriteLine($"\nSucessor: {sucessor}");
        }
        else
        {
            Console.WriteLine("\nEntrada inválida!");
        }
    }
}