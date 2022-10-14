using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 13 - Encadeando for");

        //*
        //**
        //***
        //****
        //*****

        // Sem break
        for(int contadoLinhas = 1; contadoLinhas <= 10; contadoLinhas++)
        {
            for(int contadoColunas = 1; contadoColunas <= contadoLinhas; contadoColunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Com break
        for (int contadoLinhas = 1; contadoLinhas <= 10; contadoLinhas++)
        {
            for (int contadoColunas = 1; contadoColunas <= 10; contadoColunas++)
            {
                Console.Write("*");
                if (contadoColunas == contadoLinhas)
                    break;
            }
            Console.WriteLine();
        }

        // Testando a atividade
        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                if (coluna > linha )
                {
                    break;
                }
                Console.Write(coluna + 1);
            }
            Console.WriteLine();
        }

        //Desafio: múltiplos de 3
        Console.WriteLine("Desafio: múltiplos de 3");
        for(int numero = 0; numero <= 100; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine(numero);
            }
        }

        // Desafio: fatorial
        Console.WriteLine(' ');
        Console.WriteLine("Desafio: fatorial");
        int fatorial = 1;

        for(int numero = 1; numero <10; numero++)
        {
            fatorial = fatorial * numero;
            Console.WriteLine("O fatoria de " + numero + " é " +fatorial);
        }

        Console.WriteLine("Tecle enter pra fechar!");
        Console.ReadLine();
    }
}
