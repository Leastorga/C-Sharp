using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            
            double soma = 0;
            int contador = 0;

            string[] elemento = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(elemento[i]);
                if (vet[i] % 2 == 0)
                {
                    soma = soma + vet[i];
                    contador ++;
                }
            }
            double media = soma / contador;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));            
        }
    }
}