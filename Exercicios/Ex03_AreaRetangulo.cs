using System;

class Ex03_AreaRetangulo
{
    public static void Executar()
    {
        Console.Write("\nInsira a base do retângulo: ");
        string? entradaBase = Console.ReadLine();

        Console.Write("\nInsira a altura do retângulo: ");
        string? entradaAltura = Console.ReadLine();

        if(decimal.TryParse(entradaBase, out decimal baseRetangulo) && decimal.TryParse(entradaAltura, out decimal alturaRetangulo))
        {
            decimal areaRetangulo = baseRetangulo * alturaRetangulo;
            decimal perimetroRetangulo = 2 * (baseRetangulo + alturaRetangulo);

            Console.WriteLine($"\nÁrea do retângulo: {areaRetangulo}");
            Console.WriteLine($"Perímetro do retângulo: {perimetroRetangulo}");
        }
        else
        {
            Console.WriteLine("\nAlguma entrada inválida foi digitada!");
        }
    }
}