using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split();
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");

                }
                else
                {
                    double div = (double) x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}