using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variaveis");

        int idade;

        idade = 27;
        Console.WriteLine("minha idade é: " + idade);
        idade = idade + 1;
        Console.WriteLine(idade);
        idade = idade - 5;
        Console.WriteLine(idade);
        idade = (idade * 5) + 1;
        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }
}
