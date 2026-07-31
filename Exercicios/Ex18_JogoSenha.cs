using System;

class Ex18_JogoSenha
{
    public static void Executar()
    {
        Random sortearNumero = new Random();

        Console.Write("\nSorteando número");

        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }

        Console.WriteLine();

        int numeroSorteado = sortearNumero.Next(1, 101);

        int numeroDigitado = 0;

        do
        {
            Console.Write("\nQual número entre 1 e 100 você acha que foi sorteado? ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numeroDigitado))
            {
                if(numeroDigitado == numeroSorteado)
                {
                    Console.WriteLine($"\nParabéns, você acertou! O número é {numeroSorteado}!");
                }
                else if(numeroDigitado > numeroSorteado)
                {
                    Console.WriteLine($"\nO número {numeroDigitado} é MAIOR que o sorteado!");

                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nO número {numeroDigitado} informado é MENOR que o sorteado!");

                    Thread.Sleep(2500);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida, insira um número inteiro!");

                Thread.Sleep(2500);
                Console.Clear();

                continue;
            }

        } while (numeroDigitado != numeroSorteado);
    }
}