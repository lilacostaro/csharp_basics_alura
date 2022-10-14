using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Condicionais!");

        int idadeJoao = 26;
        int quantidadePessoas = 1;

        bool acompanhado = quantidadePessoas > 1;

   
        if (idadeJoao > 18 || acompanhado)
        {
            Console.WriteLine("João pode entrar no show!");
        }
        else
        {
            Console.WriteLine("João não pode entrar no show!");
        }
        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }

}


