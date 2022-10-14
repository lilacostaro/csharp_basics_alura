using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 12 - Investindo a longo prazo");

        double fatorInvestimento = 1.005;
        double investimento = 1000;
        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorInvestimento;
                Console.WriteLine("Ano: " + anos + " Mes: " + mes + " Saldo: " + investimento);
            }
            fatorInvestimento = fatorInvestimento + 0.001;
        }
        
        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }
}