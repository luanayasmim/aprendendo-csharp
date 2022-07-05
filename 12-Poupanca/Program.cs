using System;

namespace _12_Poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12 - Poupança");

            double investimento = 1000;


            //Rendimento de 0.5% (0.005) ao mês

            //Mês 1
            investimento = investimento + (investimento * 0.005);
            //Mês 2
            investimento = investimento + (investimento * 0.005);
            //Mês 3
            investimento = investimento + (investimento * 0.005);

            Console.WriteLine(investimento);

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
            Console.ReadLine();
        }
    }
}
