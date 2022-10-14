using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais!");

        int idadeJoao = 26;
        int quantidadePessoas = 1;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acpmpanhado!";
        }
        else
        {
            textoAdicional = "João não está acompamhado!";
        }

        if (idadeJoao > 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("João pode entrar no show!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("João não pode entrar no show!");
        }
        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }

}