﻿using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {

            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }

}