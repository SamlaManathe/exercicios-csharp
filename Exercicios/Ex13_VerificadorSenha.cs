using System;

class Ex13_VerificadorSenha
{
    public static void Executar()
    {
        Console.Write("\nSenha: ");
        string? senha = Console.ReadLine();

        if(senha != null && senha.Length >= 8)
        {
            Console.WriteLine("\nA senha possui pelo menos 8 caracteres.");
        }
        else
        {
            Console.WriteLine("\nA senha possui menos de 8 caracteres.");
        }
    }
}