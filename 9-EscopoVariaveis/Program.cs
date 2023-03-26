using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 9 - Escopo Variáveis");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        // string textoAdicional;

        if(acompanhado == true)
        {
            string textoAdicional = "João está acompanhado.";
        } 
        else
        {
            string textoAdicional = "João não está acompanhado.";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar.");
        }
        else
        {

            Console.WriteLine("Não pode entrar.");

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }

}