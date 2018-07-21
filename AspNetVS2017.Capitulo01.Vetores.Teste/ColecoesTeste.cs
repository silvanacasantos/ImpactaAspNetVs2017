using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AspNetVS2017.Capitulo01.Vetores.Teste
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>(50);  //dentro do parenteses pode ser inserido o tamanho, é o vs faz o resize.
            inteiros.Add(5);
            inteiros.Add(3);
            inteiros.Add(28);
            //inteiros[10] = 27;

            var maisInteiros = new List<int>() {1,3,2,9};  //entre chaves evita copiar o comando "inteiros.Add(5);" por n vezes.

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0,32);

            //inteiros.Remove(3);   //remove o item

            inteiros.RemoveAll(i => i ==3);  //remove todos que tenham o conteúdo 3.

            inteiros.RemoveAt(0); //remove o conteúdo da posição

            inteiros.Sort();

            var primeiro = inteiros[0];

            var ultimo = inteiros[inteiros.Count - 1];

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro}");
            }
        }

        [TestMethod]
        public void DictionaryTeste()
        {
            //o vetor permite que voce escolha o tipo do indice, o indice não será um inteiro

            var feriados = new Dictionary<DateTime,string>();
            feriados.Add(new DateTime(2018,12,25),"Natal");
            feriados.Add(new DateTime(2019, 1, 01), "Ano Novo");
            feriados.Add(new DateTime(2019,1, 25), "Aniversario de São Paulo");

            var natal = feriados[new DateTime(2018, 12, 25)];

            foreach (var feriado in feriados)
            {
               // Console.WriteLine($"{feriado.Key.ToShortDateString()}:{feriado.Value}");  //$ significa string interpolada
                Console.WriteLine($"{feriado.Key.ToString("dd-MM-yyyy")}:{feriado.Value}");  //$ significa string interpolada

            }
            Console.WriteLine(feriados.ContainsKey(new DateTime(2018, 12, 25)));
            Console.WriteLine(feriados.ContainsValue("Ano Novo"));
        }

        [TestMethod]
        public void StackTeste()  //pilha p.e pilha de pratos --> quem interessa é a extremidade
        {
            var pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(4);
            pilha.Push(7);

            Assert.AreEqual(pilha.Pop(),7); //pop remove o elemento da lista
            Assert.AreEqual(pilha.Peek(),4); // peek verifica se o elemento é igual a 4 mas não remove. 

            Console.WriteLine($"A pilha está vazia? {pilha.Count == 0}");
        }

        [TestMethod]
        public void QueueTeste()
        {
            var fila = new Queue<int>();
            fila.Enqueue(1);
            fila.Enqueue(4);
            fila.Enqueue(2);

            Assert.AreEqual(fila.Dequeue(),1);  //removeu o registro da fila
            Assert.AreEqual(fila.Peek(), 4);    //verificou se o registro existe na fila




        }
    }
}
