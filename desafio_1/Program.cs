using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
        Console.WriteLine("Usando método if");
        if (salario < 1900.0)
        {
            Console.WriteLine("Você é issento do imposto de renda!");
        }
        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("Sua alicota IR é de 7.5% e você pode deduzir na declaração o valor de R$ 142.00");
        }
        if(salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("Sua alicota IR é de 15% e você pode deduzir na declaração o valor de R$ 350.00");
        }
        if (salario >= 3751.01 && salario <= 4664.00)
        {
            Console.WriteLine("Sua alicota IR é de 22.5% e você pode deduzir na declaração o valor de R$ 636.00");
        }

        salario = 4800.0;

        Console.WriteLine("Usando método switch");
        switch (salario)
        {
            case (< 1900.0):
                Console.WriteLine("Você é issento do imposto de renda!");
                break;
            case (< 2800.01):
                Console.WriteLine("Sua alicota IR é de 7.5% " +
                    "e você pode deduzir na declaração o valor de R$ 142.00");
                break;
            case (< 3751.01):
                Console.WriteLine("Sua alicota IR é de 15% " +
                    "e você pode deduzir na declaração o valor de R$ 350.00");
                break;
            case (< 4664.01):
                Console.WriteLine("Sua alicota IR é de 22.5% " +
                    "e você pode deduzir na declaração o valor de R$ 636.00");
                break;
            default:
                Console.WriteLine("Salario inválido");
                break;

        }
    }
}