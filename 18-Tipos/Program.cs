using _18_Tipos;
using static System.Console;

/*
    Criar um ConsoleApplication que receba um valor inteiro na Main;
    Criar um método void que receba esse inteiro e altere o seu valor para qualquer outro;
    Exibir o valor alterado.
*/

//Utilizando o ref
static void Adicionar(ref int x){
    x=x+20;
}

int a=2;
Adicionar(ref a);
WriteLine($"Utilizando o ref: {a}");

//Utilizando o return
static int Retornar(int x){
    return x+20;
}

int b=1;
b=Retornar(b); //Substituindo o valor
WriteLine($"Utilizando o return: {b}");
//---------------------------------------------------------------
/*
    Criar uma Console Application e uma classe Pessoa com os seguintes atributo:
        1)Nome
        2)Idade
        3)Documento
    No main crie uma instância de pessoa atribuindo dados a essas propriedades
    Crie um método void para alterar o Nome do objeto Pessoa
    De volta na Main, exiba no terminal o nome alterado
*/

static void TrocaNome(Pessoa p, string nomeNovo){
    p.Nome=nomeNovo;
}

Pessoa p1 = new Pessoa();
p1.Nome="Luana";
p1.Idade=18;
p1.Documento="Documento123";

//P2 recebe uma refêrencia de p1, ou seja ele troca o nome também
var p2 = p1; //Reference type

//Criando valores distintos e atribuindo o mesmo valor (cópia)
Pessoa p3 = new Pessoa();
p3.Nome=p1.Nome;
p3.Idade=p1.Idade;
p3.Documento=p1.Documento;

//Utilizando um método de atribuição de valores
var p4=p1.Copia();

TrocaNome(p1, "Yasmim");

WriteLine($@"Pessoa 1: {p1.Nome}
Pessoa 2: {p2.Nome}
Pessoa 3: {p3.Nome}
Pessoa 4: {p4.Nome}");

//Utilizando a struct
StrucPessoa sp1 = new StrucPessoa(){
    Nome="Fernanda",
    Idade=44,
    Documento="Documento321"
};

var sp2 = sp1;

sp1 = TrocaIdade(sp1, 45);

WriteLine($@"SP1 Idade: {sp1.Idade}
SP2 Idade: {sp2.Idade}");

static StrucPessoa TrocaIdade(StrucPessoa sp, int idadeNovo){
    sp.Idade=idadeNovo;
    return sp;
}

//---------------------------------------------------------------
/*
    Criar um Console Application com uma variável do tipo string e atribua um nome à esta variável.
    Criar um método void que receba essa variável e altere esse valor;
    No main, escreva no terminal o valor alterado.
*/
