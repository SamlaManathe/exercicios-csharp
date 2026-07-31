using System;

class Ex05_CalculadoraSimples
{
    public static void Executar()
    {
        Console.Write("\nInsira um número: ");
        string? entradaNumero1 = Console.ReadLine();

        Console.Write("\nInsira mais um número: ");
        string? entradaNumero2 = Console.ReadLine();

        if (decimal.TryParse(entradaNumero1, out decimal numero1) && decimal.TryParse(entradaNumero2, out decimal numero2))
        {
            decimal soma = numero1 + numero2;
            decimal subtracao = numero1 - numero2;
            decimal multiplicacao = numero1 * numero2;

            Console.WriteLine($"\nSoma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");

            if (numero2 != 0)
            {
                decimal divisao = numero1 / numero2;
                Console.WriteLine($"Divisão: {divisao}");
            }
            else
            {
                Console.WriteLine("Divisão: não é possível realizar divisão por zero.");
            }
        }
        else
        {
            Console.WriteLine("\nAlguma das entradas digitadas é inválida!");
        }
    }
}