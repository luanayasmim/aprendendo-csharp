using _18_Tipos;
using static System.Console;


internal class Program
{
    private static void Main(string[] args)
    {
       
    }

    

//-------------------------------------------------------------------------------------------------------------------------------------------
/*
    Criar um ConsoleApplication que receba um valor inteiro na Main;
    Criar um método void que receba esse inteiro e altere o seu valor para qualquer outro;
    Exibir o valor alterado.
*/
    static void Demo1(){
    //Utilizando o ref
        static void Adicionar(ref int x)
        {
            x = x + 20;
        }

        int a = 2;
        Adicionar(ref a);
        WriteLine($"Utilizando o ref: {a}");

        //Utilizando o return
        static int Retornar(int x)
        {
            return x + 20;
        }

        int b = 1;
        b = Retornar(b); //Substituindo o valor
        WriteLine($"Utilizando o return: {b}");
    }
//-------------------------------------------------------------------------------------------------------------------------------------------
/*
    Criar uma Console Application e uma classe Pessoa com os seguintes atributo:
        1)Nome
        2)Idade
        3)Documento
    No main crie uma instância de pessoa atribuindo dados a essas propriedades
    Crie um método void para alterar o Nome do objeto Pessoa
    De volta na Main, exiba no terminal o nome alterado
*/


    static void Demo2(){
        static void TrocaNome(Pessoa p, string nomeNovo)
        {
            p.Nome = nomeNovo;
        }

        Pessoa p1 = new Pessoa();
        p1.Nome = "Luana";
        p1.Idade = 18;
        p1.Documento = "Documento123";

        //P2 recebe uma refêrencia de p1, ou seja ele troca o nome também
        var p2 = p1; //Reference type

        //Criando valores distintos e atribuindo o mesmo valor (cópia)
        Pessoa p3 = new Pessoa();
        p3.Nome = p1.Nome;
        p3.Idade = p1.Idade;
        p3.Documento = p1.Documento;

        //Utilizando um método de atribuição de valores
        var p4 = p1.Copia();

        TrocaNome(p1, "Yasmim");

        WriteLine($@"Pessoa 1: {p1.Nome}
Pessoa 2: {p2.Nome}
Pessoa 3: {p3.Nome}
Pessoa 4: {p4.Nome}");

        //Utilizando a struct
        StrucPessoa sp1 = new StrucPessoa()
        {
            Nome = "Fernanda",
            Idade = 44,
            Documento = "Documento321"
        };

        var sp2 = sp1;

        sp1 = TrocaIdade(sp1, 45);

        WriteLine($@"SP1 Idade: {sp1.Idade}
SP2 Idade: {sp2.Idade}");

        static StrucPessoa TrocaIdade(StrucPessoa sp, int idadeNovo)
        {
            sp.Idade = idadeNovo;
            return sp;
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------
/*
    Criar um Console Application com uma variável do tipo string e atribua um nome à esta variável.
    Criar um método void que receba essa variável e altere esse valor;
    No main, escreva no terminal o valor alterado.
*/
    static void Demo3(){
        //O tipo string é reference type, porém se comporta como value type
        string name = "Yasmim";

        name = ChangeName(name, "Luana");
        WriteLine($"O nome é: {name}");

        static string ChangeName(string name, string newName)
        {
            name = newName;
            return newName;
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------
/*
    Criar um Console Application com uma variável do tipo array de int para armazenar os números pares de 0 à 8.
    Criar um método void que receba essa variável e altere o contéudo desse array para que ele fique armazenado o próximo número inteiro ímpar de cada elemento;
    No Main, escreva no terminal todos os números desse array.
*/
    static void Demo4(){
        //Reference type - Array int
        int[] numPares = new int[] { 0, 2, 4, 6, 8 };

        MudarParaImpar(numPares);

        WriteLine($"O ímpares são: {string.Join(", ", numPares)}");

        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i]++;
            }
        }


    }

//-------------------------------------------------------------------------------------------------------------------------------------------
/*
    Criar um Console Application para encontrar uma pessoa em uma Lista de Pessoas
    Criar um Console Application para encontra um número inteiro em um array
*/
    static void Demo5(){
    List<Pessoa> pessoas = new List<Pessoa>(){
        new Pessoa(){Nome="Gabriela"},
        new Pessoa(){Nome="Fernanda"},
        new Pessoa(){Nome="Fabiana"},
        new Pessoa(){Nome="Renato"},
        new Pessoa(){Nome="Arthur"}
    };

        WriteLine("Digite o nome que procura:");
        var nome = ReadLine();
        Pessoa pessoa = new Pessoa() { Nome = nome };
        var encotrado = BuscaPessoa(pessoas, pessoa);

        WriteLine(encotrado);

        static bool BuscaPessoa(List<Pessoa> lista, Pessoa nome)
        {
            foreach (var pessoa in lista)
            {
                if (pessoa.Nome == nome.Nome)
                    return true;
            }
            return false;
        }

        int[] arrayInt = new int[] { 0, 2, 4, 6, 8, 10 };
        WriteLine($"Digite o número que gostaria de encontrar: ");
        int num = int.Parse(ReadLine());

        var numEncontrado = BuscaNumero(arrayInt, num);

        if (numEncontrado >= 0)
            WriteLine($"O número digitado está na posição: {numEncontrado}");
        else
            WriteLine("Número não cadastrado!");

        static int BuscaNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                    return i;
            }
            return -1;
        }

        
        List<StrucPessoa> pessoasStruct = new List<StrucPessoa>(){
            new StrucPessoa(){Nome="Gabriela"},
            new StrucPessoa(){Nome="Fernanda"},
            new StrucPessoa(){Nome="Fabiana"},
            new StrucPessoa(){Nome="Renato"},
            new StrucPessoa(){Nome="Arthur"}
        };

        WriteLine("Informe a pessoa que gostaria de localizar:");
        var nomeStruct = ReadLine();
        var pessoaStruct = new StrucPessoa(){Nome=nome};
        var encontrado = EncontrarPessoa(pessoasStruct, pessoaStruct);

        if(encontrado)
            WriteLine("Pessoa Localizada");
        else
            WriteLine("Pessão não registrada");

        static bool EncontrarPessoa(List<StrucPessoa> pessoas, StrucPessoa pessoa){
            foreach (var ser in pessoas)
            {
                if(ser.Nome==pessoa.Nome)
                    return true;   
            }
            return false;
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------
//Aula 3
    static void Demo6(){
        Humano humano = new Humano();
        humano.Nome="Natália";
        humano.Idade=18;
        humano.EnderecoHumano=new Endereco(){
            Rua="Mandioca",
            Num=987,
            Bairro="São Marcos",
            Cidade="Itapecerica da Selva"
        };

        WriteLine(humano.EnderecoHumano.Rua);
    }

//-------------------------------------------------------------------------------------------------------------------------------------------
//Aula 4 - Comparando valores e referencias
    static void Demo7(){
         //Comparando TypeOf
        int a = 2;
        int b = 2;

        //Operação ternária
        bool teste = a==b ? teste=true : teste=false;

        WriteLine(teste); //True
        
        //Comparando ReferenceType
        Numero x = new Numero(5);
        Numero y = new Numero(5);

        bool comparacao = y==x ? comparacao=true : comparacao=false;

        WriteLine(comparacao); //False
        
        //Para fazer a comparação do valor dos números é necessario especificar

        if(x.Num==y.Num){
            WriteLine("Os números são iguais");
        }else{
            WriteLine("Os números se diferem");
        }
    }

    class Numero
    {
        public int Num { get; set; }
        public Numero(int num)
        {
            Num=num;
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------
//Aula 5
/*
    Garbage Collector
        Suporte para a criação e destruição de objetos na HEAP
        Cuida da Segurança, liberação da memória.
*/
}