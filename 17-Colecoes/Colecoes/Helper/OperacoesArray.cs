using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
                                    //ref fala que estamos utilizando a mesma variavel informada, sem criar uma nova
        public void BubbleSort(ref int[] array){
            int temp = 0;
            for (int i = 0; i < array.Length; i++) // Percorre o array
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        temp=array[j+1];
                        array[j+1]=array[j];
                        array[j]=temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array){
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array){
            Array.Sort(array);
        }
        public void Copiar(ref int[] array, ref int[] arrayDestino){
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor){
            return Array.Exists(array, elemento=> elemento==valor);
        }
        public bool TodosMaiorQue(int[] array, int valor){
                        //Compara todos os elementos da array e traz a verificação
            return Array.TrueForAll(array, elemento=>elemento>valor);
        }
        public int ObterValor(int[] array, int valor){
            return Array.Find(array, element=>element==valor);
        }
        public int ObterIndice(int[] array, int valor){
            return Array.IndexOf(array, valor);
        }
        public void RedimencionarArray(ref int[] array, int novoTamanho){
            Array.Resize(ref array, novoTamanho);
        }
        public string[] ConverterString(ref int[] array){
            return Array.ConvertAll(array, element=>element.ToString());
        }
    }
}