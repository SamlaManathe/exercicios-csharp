using System;

class Ex10_LoginSimples
{
    public static void Executar()
    {
        string usuarioCorreto = "User";
        string? usuario = null;

        string senhaCorreta = "User%15";
        string? senha = null;

        do
        {
            Console.Write("\nUsuário: ");
            usuario = Console.ReadLine();

            Console.Write("Senha: ");
            senha = Console.ReadLine();

            if(usuario != usuarioCorreto || senha != senhaCorreta)
            {
                Console.WriteLine("\nUsuário ou senha incorretos! Insira novamente.");
            }
            else
            {
                Console.WriteLine("\nUsuário e senha corretos!");
            }

        } while (usuario != usuarioCorreto || senha != senhaCorreta);
    }
}