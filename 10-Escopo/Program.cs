using System;

namespace _10_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Escopo");
            int idadeYasmim = 17;
            int qtdPessoas = 2;

            bool acompanhado = qtdPessoas > 1;
            string textoAdicional;

            if (acompanhado == true)
            {
                //string textoAdicional = "Yasmim está acompanhada";
                textoAdicional = "Yasmim está acompanhada";
            }
            else
            {
                textoAdicional = "Yasmim não está acompanhada";
            }

            //Condicional de idade
            if (idadeYasmim >= 18 || acompanhado)
            {
                Console.WriteLine(textoAdicional);
                Console.WriteLine($@"Pode entrar!
A Yasmim tem {idadeYasmim}");
            }
            else
                Console.WriteLine($@"Não pode entrar!
A Yasmim tem {idadeYasmim} e não tem acompanhante");




            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
