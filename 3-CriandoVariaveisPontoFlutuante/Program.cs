using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3 - Variáveis com Ponto Flutuante");

            double salario = 1500.50;
            Console.WriteLine(salario);

            salario /= 5;
            Console.WriteLine(salario);

            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
