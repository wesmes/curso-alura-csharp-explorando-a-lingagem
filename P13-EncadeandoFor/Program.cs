using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 13 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****

        for (int contadorLinhas = 1; contadorLinhas < 10; contadorLinhas++)
        {

            for (int contadorColuna = 0; contadorColuna < contadorLinhas; contadorColuna++)
            {

                Console.Write("*");

                //if (contadorColuna >= contadorLinhas)
                //    break;

            }

            Console.WriteLine();

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }

}