using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            double[] num = new double[n];
            double soma = 0.0;

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                num[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                soma = soma + num[i];
            }

            double media = soma / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            
            for (int i = 0; i < n; i++)
            {
                if (num[i] < media)
                {
                    Console.WriteLine(num[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}