using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            double n1, n2, n3, media;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split();
                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}