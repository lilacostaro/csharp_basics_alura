using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Textos e Caracteres");

        char letra = 'a';
        Console.WriteLine("Isso é char " + letra);

        letra = (char)65;
        Console.WriteLine("Isso é ASCII " + letra);

        letra = (char)(65 * 2);
        Console.WriteLine("Isso é ASCII " + letra);

        letra = (char)(243);
        Console.WriteLine("Isso é ASCII " + letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = " ";
        Console.WriteLine(vazia);

        string cursos = @"Cursos Disponiveis: 
- Go, 
- C#, 
- Python, 
- Java";
        Console.WriteLine(cursos);
        Console.WriteLine("Tecle enter para finaliza o programa");
        Console.ReadLine();
    }
}

