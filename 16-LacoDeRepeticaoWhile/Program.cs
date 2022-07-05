using System;

namespace _16_LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 16-Laço de REpetição While");

            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }
            Console.ReadLine();

            for (contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }
            Console.ReadLine();

            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
