using System;

namespace _13_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13 - Calcula Poupança");

            double investimento = 1000;
            //Rendimento de 0.5% (0.005) ao mês

            /*
            int mes = 1;
            while (mes <= 12)
            {
                investimento = investimento + (investimento * 0.005);
                Console.WriteLine(investimento);
                //mes = mes + 1;
                //mes += 1;
                mes++;
            }


            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();*/

            for(int i=1; i<=12; i++)
            {
                investimento += (investimento * 0.005);
                Console.WriteLine(investimento);

            }

            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
