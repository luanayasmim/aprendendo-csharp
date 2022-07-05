using System;

namespace _15_EncadeandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 15-Encadeando FOR");

            //Primeira Solução
            for (int contadorLinhas = 0; contadorLinhas<10; contadorLinhas++)
            {
                for(int contadorColunas=0; contadorColunas<10; contadorColunas++)
                {
                    Console.WriteLine("*");

                    if (contadorColunas >= contadorLinhas)
                        break;
                }
                Console.WriteLine();

            }

            //Segunda Solução
            for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();

            }


            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
