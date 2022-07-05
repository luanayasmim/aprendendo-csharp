using System;

namespace _5_ConversoesDeOutrosTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5- Conversões de outros Tipos");

            double salario = 1459.53;
            Console.WriteLine(salario);

            //Casting
            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            //Tipo long
            //O tipo int só aceita valores até 32 bits
            //int x = 20000000000;
            //O tipo long consegue armazenar valores de 64 bits
            long x = 20000000000;
            Console.WriteLine(x);
            //O tipo short armazena valores de 16 bits
            short y = 20000;
            Console.WriteLine(y);
            //Para declarar valores do tipo float é necessario colocar um F após o valor para não ser confundido com o tipo Double
            float altura = 1.62f;
            Console.WriteLine(altura);


            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            float pontoFlutuante = 3.14f;

            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine(); 
        }
    }
}
