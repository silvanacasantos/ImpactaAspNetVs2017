using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;   //biblioteca que possibilita utilizar comando como order by, sum, etc...

namespace AspNetVS2017.Capitulo01.Vetores.Teste
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];        //Outra opção --> string[] strings = new string [10];
            strings[0] = "Silvana";

            var decimais = new decimal[] {0.5m,1,1.59m};

            int[] inteiros = { 1, 58, 10, 0 };    //para inteiros não pode usar o var e já cria e insere o valor

            foreach (var inteiro in inteiros)    //for para quando você sabe a quantidade o foreach usar quando você não tem a quantidade
            {
                Console.WriteLine(inteiro);
            }

            Console.WriteLine($"Tamanho do verto: {inteiros.Length}");

            var soma = inteiros.Where(i => i > 1).Sum();

            Console.WriteLine(soma);
         }

        [TestMethod]
        public void RedirecionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m };

            Array.Resize(ref decimais,5);

            decimais[4] = 2.1m;  //como não tem console.writeline não tem saida quando executa o teste
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m, 0.4m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0],0.4m);
        }

        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m, 0.4m };
            Console.WriteLine(CalcularMedia(decimais));

            Console.WriteLine(CalcularMedia(2,3.5m,8));
        }
        //public decimal CalcularMedia(decimal x, decimal y) 
        //{
        //    return (x + y) / 2;
        //}

        //metodo para calcular media
        //utilizar params para quando for utilizar o metodo não será necessário
        public decimal CalcularMedia(params decimal[] valoresVetor)
        {
            decimal soma = 0;

            foreach (var item in valoresVetor)
            {
                soma += item;
            }

            return soma / valoresVetor.Length;

            //return valorX.Average();  se utilizar a biblioteca linq utilizar apenas a linha de comando abaixo.
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Silvana";

            foreach (var caractere in nome)
            {
                Console.WriteLine(caractere);
            }
            Assert.AreEqual(nome.First(), 'S'); //.first só funciona se tiver usando o linq
        }
  
    }
}
