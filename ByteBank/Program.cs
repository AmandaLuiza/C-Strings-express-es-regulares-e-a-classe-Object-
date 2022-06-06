using System;
using System.Text.RegularExpressions;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            Console.ReadLine();

        }
        static void TestaString()
        {
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            //Olá, meu nome é Guilherme e você pode entrar em contato comigo
            //atraves do numero 8457-4456!

            //Meu nome é Guilherme, me ligue em 4784-4546   

            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";

            //string padrao = "[0-9]{4,5}[-][0-9]{4}";


            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            //879.546.120-20


            string textoDeTeste = "jsfksfzisolois 98457-5456 shgsklgsgl.dj";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();



            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));

            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadLine();


            Console.WriteLine(indiceByteBank == 0);
            Console.ReadLine();


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

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();


            //Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(termoBusca.ToLower());

            //Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf("termoBusca"));
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
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
    

