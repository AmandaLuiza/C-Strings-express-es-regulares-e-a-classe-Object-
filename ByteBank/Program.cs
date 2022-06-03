using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //pagina?argumentos
            //012345678

            // moedaOrigem=real&moedaDestino=dolar
            //
            //---------------



            


            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);
            Console.ReadLine();

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("valor"));

            Console.ReadLine();

            //Testando  o método Remove
            string testeRemocao = "primeiraParte&1233504950";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();


            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento" + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();


            //Testando o IsNullOrEmpty

            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "slfkjakgnfl";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();


            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

           //string temporaria = url + "sufixo";
            //url = temporaria;

            //url += "sufixo";

            Console.WriteLine(url);
            string argumentos  = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
