using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2 - Criando Variáveis");
            string nome = "Luana";
            int idade = 18;
            Console.WriteLine($"Meu nome é {nome} E eu tenho {idade} anos");
            string idadeString = "Minha idade é 18";
            Console.WriteLine(idadeString);

            //Contas
            idade -= 5;
            Console.WriteLine(idade);
            idade = idade * 2 - 4;
            Console.WriteLine(idade);
            idade /= 5;
            Console.WriteLine("Minha idade é "+idade);
            idade = (9 * 3) - 9;

            //Usando TEMPLATE LITERALS
            Console.WriteLine($"Minha idade é {idade}");
            
            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();

        }
    }
}
