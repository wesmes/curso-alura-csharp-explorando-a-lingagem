using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 11 - Calcula Poupança 2");

        double investimento = 1000;

        // int mes = 1;

        //while (mes <= 12)
        //{

        //    investimento = investimento + investimento * 0.005;
        //    Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

        //    mes++;

        //}

        for(int mes = 1; mes <= 12; mes++)
        {

            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }

}