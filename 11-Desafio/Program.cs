using System;

namespace _11_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as regras de alíquota. 
             * Ele descobriu no site da receita o seguinte:
             * De 1900.0 até 2800.0, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142;
             * De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
             * De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.*/

            double salario = 3300.0;

            if(salario>= 1900.0 && salario<= 2800.0)
            {
                Console.WriteLine("O IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142");
                Console.WriteLine(salario-salario * 0.075);
            }else if(salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("O IR é de 15% e pode deduzir na declaração o valor de R$ 350");
                Console.WriteLine(salario - salario * 0.15);
            }else if(salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("O IR é de 22.5% e pode deduzir na declaração o valor de R$ 636");
                Console.WriteLine(salario - salario * 0.225);
            }


            //Meses com Switch Case
            int mes = 12;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês é Março");
                    break;
                case 4:
                    Console.WriteLine("O mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }
            Console.ReadLine();

            /*
             * Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.
             */

            //Exemplo 1
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Exemplo 2
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }

            /*
             * Imprimir os fatoriais de 1 a 10!
             */

            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
        }
    }
}
