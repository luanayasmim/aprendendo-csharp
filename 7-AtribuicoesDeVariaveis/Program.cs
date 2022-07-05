using System;

namespace _7_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Atribuições de Variaveis");

            int idade = 18;
            int idadeLuana = idade;

            Console.WriteLine(idadeLuana);

            idade = 19;


            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
