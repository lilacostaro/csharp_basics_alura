using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 10 - Calculando Poupança");

        double investimento = 1000;
        // Rendimento de 0.5% (0.005) ao mês
        int ano = 1;
             
        while(ano <= 12)
        {
            investimento = investimento + investimento * 0.125;
            Console.WriteLine("No mes " + ano + " o seu saldo será de r$ " + investimento);
            ano++;
        }
        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }
}
