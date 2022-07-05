using System;

namespace _6_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 - Caracteres e Texto");

            //O tipo char armazena até 16 bits
            char letra = 'a';
            Console.WriteLine(letra);

            //Casting
            letra = (char)65;
            Console.WriteLine(letra);

            letra += (char) 1;
            Console.WriteLine(letra);

            letra += (char)(1+66);
            Console.WriteLine(letra);

            

            //String
            string primeiraFrase = "Alguma frase linda maravilhosa ";
            Console.WriteLine(primeiraFrase + 2022);

            //Podemos ter uma string vazia, porém não é aceito no char
            string vazia = "";
            //letra = '';

            //Quando se declara uma string com o @ ele identifica os espaços como caracteres
            string cursos = @"Cursos disponiveis:
                C#
                Python
                JavaScript 
                SQL";
            Console.WriteLine(cursos);

            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}
