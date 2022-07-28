using System;
using Colecoes.Helper;

//Declarando um array de inteiros com capacidade de 3 posições
int[] arrayInt = new int[3];
arrayInt[0] = 10;
arrayInt[1] = 20;
arrayInt[2] = int.Parse("30");

//Percorrendo um array com for
for (int i = 0; i < arrayInt.Length; i++)
{
    System.Console.WriteLine(arrayInt[i]);
}
//Percorrendo o array com o foreach
// foreach (int item in arrayInt)
// {
//     Console.WriteLine(arrayInt[item]);
// }
//----------------------------------------------------------------------------------------------------------------------------------
//Arrays Multidimencional / Matriz

//int[,] matriz = new int[numLinhas, numColunas];
int[,] matriz = new int[4, 2];
//Adicionando um valor
matriz[0, 0] = 5;

int[,] m = new int[4, 2]{
                {1, 2}, //Representa uma linha   
                {10, 20},
                {100, 200},
                {1000, 2000}
            };
/* Matriz m - 4 linhas e 2 colunas
    1       2
    10      20
    100     200
    1000    2000*/


//Percorrendo uma matriz
for (int x = 0; x < m.GetLength(0); x++) //Percorre uma linha
{
    for (int y = 0; y < m.GetLength(1); y++) //Percorre a coluna
    {
        System.Console.WriteLine(m[x, y]);
    }
}

//----------------------------------------------------------------------------------------------------------------------------------
//Algoritmo de Ordenação
//São conjuntos de instruções com a finalidade do organizar os valores de uma array
//https://visualgo.net/en
int[] array = new int[5] { 9, 2, 6, 2, 1 };
OperacoesArray op = new OperacoesArray();
System.Console.WriteLine("Array original:");
op.ImprimirArray(array);

//Ordenando
//op.BubbleSort(ref array);
op.Ordenar(ref array);

System.Console.WriteLine("Array ordenado:");
op.ImprimirArray(array);

//Copiando array
System.Console.WriteLine("Copiando Array:");
int[] arrayCopia = new int[10];
op.Copiar(ref array, ref arrayCopia);
op.ImprimirArray(arrayCopia);

//Parametro Exists
int valorProcurado = 2;
bool existe = op.Existe(array, valorProcurado);

if (existe)
    System.Console.WriteLine($"valor encontrado {valorProcurado}");
else
    System.Console.WriteLine($"valor não encontrado {valorProcurado}");


//Teste paramentro TrueForAll
bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
if (todosMaiorQue)
    System.Console.WriteLine($"Todos os valores são maiores que {valorProcurado}");
else
    System.Console.WriteLine("Existe algum valor menor que {0}", valorProcurado);

//Teste Find
int valorEncontrado = op.ObterValor(array, 100);
// Caso não seja encontrado o valor, a função irá retornar o valor padrão do tipo da variável
//Nesse caso como o tipo de variável e int, o valor será 0
if (valorEncontrado > 0)
    System.Console.WriteLine("Valor encontrado");
else
    System.Console.WriteLine("Valor não encontrado. Retorno da função {0}", valorEncontrado);

//Teste IndexOf
//Caso ele não encontre, o retorno será -1
//Se existir varias posições com o valor procurado, o IndexOf retorna o primeiro encontrado
int indice = op.ObterIndice(array, valorProcurado);
if (indice > -1)
    System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
else
    System.Console.WriteLine("Valor não encontrado no array!");

//Teste Resize
//Redimencionando um array
System.Console.WriteLine($"Capacidade Atual do Array:{array.Length}");
op.RedimencionarArray(ref array, array.Length * 2);
System.Console.WriteLine($"Capacidade do Array Redimencionado: {array.Length}");

//Teste ConvertAll
//Convertendo um array
string[] arrayString= op.ConverterString(ref array);
System.Console.WriteLine(arrayString);

//----------------------------------------------------------------------------------------------------------------------------------
/*Coleções Genericas
    No C# existem classes de coleções que agrupam valores
    Essas classes são padronizadas para as operações mais comuns como:
    -Ordenação 
    -Obter valor com expressões
    -Obter valor por índice
    -Trabalhar com tamanhos dinâmicos
*/

List<string> estados= new List<string>();
estados.Add("SP");
estados.Add("RJ");
estados.Add("MG");
estados.Add("ES");
System.Console.WriteLine($"A quantidade de estados cadastrados é:{estados.Count}");
foreach (var item in estados)
{
    System.Console.WriteLine(item);
}

OperacoesLista opLista = new OperacoesLista();
opLista.ImprimirLista(estados);

estados.Remove("RJ");
System.Console.WriteLine("Removendo o elemento");
opLista.ImprimirLista(estados);

string[] estadosArray = new string[2]{"MT", "MS"};
List<string> estadosList = new List<string>{"PA", "TO"};
estadosList.AddRange(estadosArray);

//----------------------------------------------------------------------------------------------------------------------------------
//Coleções específicas
/*
    As Coleções específicas implementam regras para sua ordem de acesso e manipulação de seus elementos.
        -Queue(Fila): Obedece a ordem FIFO(First In/ First Out)
        -Stack(Pilha): Obedece a ordem LIFO(Last In/ Last Out)
*/

//Implementando uma Queue
Queue<string> Fila = new Queue<string>();
Fila.Enqueue("Leonardo");
Fila.Enqueue("Lucas");
Fila.Enqueue("Eduardo");
Fila.Enqueue("Luana");

System.Console.WriteLine($"Pessoas na fila: {Fila.Count}");

while(Fila.Count>0){                           //Pega o primeiro elemento da fila
    System.Console.WriteLine($"Vez de: {Fila.Peek()}");
    //O método Dequeue remove o primeiro elemento da fila
    System.Console.WriteLine($"{Fila.Dequeue()} atendido");
}

System.Console.WriteLine($"Pessoas na fila: {Fila.Count}");

//Implementando uma Stack
Stack<string> Pilha = new Stack<string>();
Pilha.Push("Jogos Vorazes");
Pilha.Push("Em chamas");
Pilha.Push("A Esperança");
Pilha.Push("A Cantiga dos Pássaros e das Serpentes");

System.Console.WriteLine($"Quantidade de livros: {Pilha.Count}");

while(Pilha.Count>0){
    System.Console.WriteLine($"Proximo livro para a leitura: {Pilha.Peek()}");
    //O método pop remove ultimo elemento da pilha
    System.Console.WriteLine($"{Pilha.Pop()} lido com sucesso!");
}

System.Console.WriteLine($"Quantidade de livros: {Pilha.Count}");

//----------------------------------------------------------------------------------------------------------------------------------
//Dicionários
/*
    Um dicionário é uma coleção de chave e valor permitindo que se recupere rapidamente seus itens baseados em sua chave.
    O dicionário armazena a sua chave em hash (é uma identificação única)
*/
//        chave, valor
Dictionary<int, string> Dicionario = new Dictionary<int, string>();

Dicionario.Add(1, "SP"); //Não pode conter chave repetida
Dicionario.Add(2, "MG");
Dicionario.Add(3, "RJ");

foreach (KeyValuePair<int, string> item in Dicionario)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

System.Console.WriteLine("Valor original:");

//Acessando um valor
int valorBuscado=2;
System.Console.WriteLine(Dicionario[valorBuscado]);
//Atualizando o valor
Dicionario[valorBuscado]="ES";
System.Console.WriteLine(Dicionario[valorBuscado]);

//Removendo um valor 
System.Console.WriteLine("Removendo o valor");
Dicionario.Remove(valorBuscado);

foreach (KeyValuePair<int, string> item in Dicionario)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
//                                      saida
if(Dicionario.TryGetValue(valorBuscado, out string estadoEncontrado)){
    System.Console.WriteLine(estadoEncontrado);
}else{
    System.Console.WriteLine("Não existe no dicionário");
}

//----------------------------------------------------------------------------------------------------------------------------------
//Operações LINQ
/*
    O linguage-integrated-query é uma maneira de utilizar uma sintexe de consulta padronizada para coleções de objetos.
*/
int[] arrayNumeros = new int[5]{1, 2, 3, 4, 5};

//Sintaxe de consulta
//Selecionando os pares
var numerosPares =
    from num in arrayNumeros
    where num % 2 == 0
    orderby num
    select num;

var numPares = arrayNumeros.Where(x=>x%2==0).OrderBy(x=>x).ToList();

System.Console.WriteLine($"Números Pares Query: {string.Join(", ",numerosPares )}");
System.Console.WriteLine($"Números Pares Método: {string.Join(", ",numPares )}");

//Obtendo o valor mínimo, máximo e médio
var minimo=arrayNumeros.Min();
var maximo=arrayNumeros.Max();
var medio=arrayNumeros.Average();

System.Console.WriteLine($"Mínimo: {minimo} | Máximo: {maximo} | Médio: {medio}");

//Sum e Distinct
var sum = arrayNumeros.Sum();
System.Console.WriteLine($"Soma: {sum}");

int[] arrayDistinct = new int[10] {10, 9, 8, 4, 5, 6, 7, 8, 9, 10};
var _distinct = arrayDistinct.Distinct().ToArray();
System.Console.WriteLine($"Array original : {string.Join(", ", arrayDistinct)} | Distinct: {string.Join(", ", _distinct)}");
/*
    Comandos para o terminal

    cd Colecoes
    dotnet run
*/


