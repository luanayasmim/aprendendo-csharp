using System;

namespace _8_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais");

            int idadeYasmim = 17;
            int qtdPessoas = 2;

            //Condicional de idade
            if (idadeYasmim >= 18)
            {
                Console.WriteLine($@"Pode entrar!
A Yasmim tem {idadeYasmim}");
            }
            else
            {
                //Condicional de Pessoas
                if (qtdPessoas > 1)
                {
                    Console.WriteLine("Esta acompanhado. Pode entrar!");
                }
                else
                {
                    Console.WriteLine($@"Não pode entrar!
A Yasmim tem {idadeYasmim} e não tem acompanhante");
                }
            }




            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
