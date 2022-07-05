using System;

namespace _4_TestaPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.70;
            Console.WriteLine("Meu salário é"+salario);

            //int valor1 = 12.5;             // não compila.

            //int valor2 = 0.0;             // não compila.

            double teste = 125.50;        // compila

            //int valor3 = teste;           // não compila.


            int divisao = 7 / 5;
            Console.WriteLine(divisao);

            double divisaoDouble = 7.0 / 5;
            Console.WriteLine(divisaoDouble);


        }
    }
}
