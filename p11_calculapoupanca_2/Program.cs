using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 11 - Calculando Poupança");

        double investimento = 1000;
        // Rendimento de 0.5% (0.005) ao mês
        

        for(int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mes " + mes + " o seu saldo será de r$ " + investimento);
            
        }
        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }
}
