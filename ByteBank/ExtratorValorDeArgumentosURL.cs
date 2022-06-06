using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        private int indiceEComercial;

        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }


            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;

            
            
        }

        //moedaOrigem=real&moedaDestino=dolar
        //MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR
        //moedaorigem
        //MoedaOrigem


        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); //VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); //MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; //moedaDestino=
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo); // x

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); //dolar
            int indiceEComercial = resultado.IndexOf('&');

            if(indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);

            
            //return _argumentos.Substring(indiceTermo + termo.Length);

           
        }
    }
}
    

