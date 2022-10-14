using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais!");

        int idadeJoao = 16; 
        int quantidadePessoas = 2;

        if (idadeJoao > 18)
        {
            Console.WriteLine("João pode entrar no show!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("João está acompanhado. Pode entrar no show!");
            }
            else
            {
                Console.WriteLine("João não pode entrar no show!");
            }

        }
        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }
}
