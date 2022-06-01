using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //pagina?argumentos
            //012345678

            string url = "paginas?argumentos";

           //string temporaria = url + "sufixo";
            //url = temporaria;

            //url += "sufixo";

            Console.WriteLine(url);
            string argumentos  = url.Substring(8);
            Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }
}
