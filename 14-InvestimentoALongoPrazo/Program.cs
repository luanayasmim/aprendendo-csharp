using System;

namespace _14_InvestimentoALongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 14 - Investindo à longo prazo");

            double fatorRendimento = 1.005;
            double investimento = 1000;
            
            //Encadeamento do laço de repetição FOR
            for(int anos = 1; anos <= 5; anos++)
            {
                for(int mes = 1; mes <= 12; mes++)
                {
                    investimento *= fatorRendimento;
                }

                fatorRendimento += 0.001;
            }

            Console.Write("Depois de 5 anos voê terá R$ " + investimento);

            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
