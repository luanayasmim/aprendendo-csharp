using System;

namespace _9_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Condicionais - pt2");

            int idadeYasmim = 17;
            int qtdPessoas = 2;

            bool acompanhado = qtdPessoas > 1;

            //Condicional de idade
            if (idadeYasmim >= 18 || acompanhado)
            {
                Console.WriteLine($@"Pode entrar!
A Yasmim tem {idadeYasmim}");
            }
            else
            {
                Console.WriteLine($@"Não pode entrar!
A Yasmim tem {idadeYasmim} e não tem acompanhante");
            }




            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
