using System;

class Ex04_ConversorMoedas
{
    public static void Executar()
    {
        Console.Write("\nInsira o valor: R$");
        string? entradaReais = Console.ReadLine();

        Console.Write("\nInsira a cotação do dólar (ex.: US$5,14 = R$1): US$");
        string? entradaCotacaoDolar = Console.ReadLine();

        if (decimal.TryParse(entradaReais, out decimal valorReais) && decimal.TryParse(entradaCotacaoDolar, out decimal cotacaoDolar))
        {
            decimal valorEmDolar = valorReais / cotacaoDolar;

            Console.WriteLine($"\nValor em dólares: US${valorEmDolar:F2}");
        }
        else
        {
            Console.WriteLine("\nAlguma das entradas digitadas é inválida!");
        }
    }
}
