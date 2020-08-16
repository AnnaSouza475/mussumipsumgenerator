using System;

namespace GeradorDeMussumIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            long quantidadePalavras;
            string frase = "";
            Random numeroAleatorio = new Random();
            string[] palavras = { "Mussum Ipsum", "cacilds", "euzis", "litrus", "mê faiz", "elementum", "tendi nada", "vitae", "quem manda na minha terra", "consequat" };
            Console.WriteLine("--------Gerador de Mussum Ipsum--------");
            Console.WriteLine("Digite a quantidade de Palavras desejadas:");
            quantidadePalavras = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i <= quantidadePalavras; i++)
            {
                frase = frase + " " + palavras[numeroAleatorio.Next(0, 9)];
            }
            Console.WriteLine(frase);

            Console.ReadKey();
        }
    }
}
