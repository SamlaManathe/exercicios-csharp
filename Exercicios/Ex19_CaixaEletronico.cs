using System;

class Ex19_CaixaEletronico
{
    public static void Executar()
    {
        Console.Write($"\nInsira o valor para saque (inteiro): R$");
        string? entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int valorSaque) && valorSaque > 0)
        {
            int[] notas = { 100, 50, 20, 10, 5, 2 };

            Console.WriteLine("\n---------- Notas ----------\n");

            foreach (int nota in notas)
            {
                int quantidadeNotas = valorSaque / nota;

                Console.WriteLine($"R${nota}  ->  {quantidadeNotas} un.");

                valorSaque %= nota;
            }

            if(valorSaque > 0)
            {
                Console.WriteLine($"\nNão foi possível sacar R${valorSaque}.");
            }
        }
        else
        {
            Console.WriteLine("\nEntrada inválida, valor negativo ou valor igual a zero!");
        }
    }
}