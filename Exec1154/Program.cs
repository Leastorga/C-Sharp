
using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            double idade, media, soma;
            int contador;

            soma = 0.0;
            contador = 0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (idade > 0.0)
            {
                soma = soma + idade;
                contador += 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = soma / contador;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}