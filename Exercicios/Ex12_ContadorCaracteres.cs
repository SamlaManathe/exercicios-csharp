using System;

class Ex12_ContadorCaracteres
{
    public static void Executar()
    {
        Console.Write("\nInsira um nome: ");
        string? nome = Console.ReadLine();

        Console.WriteLine($"\nQuantidade de caracteres: {nome.Length}");
    }
}