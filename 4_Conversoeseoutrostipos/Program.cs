using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;
        int salarioInteiro = (int)salario;
        Console.WriteLine(salario);
        Console.WriteLine(salarioInteiro);

        long x = 2000000000000000000;
        Console.WriteLine(x);

        float altura = 1.54f;
        Console.WriteLine(altura);
        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }
}
