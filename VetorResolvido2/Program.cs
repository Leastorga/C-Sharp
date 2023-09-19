using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] vet;
            double soma = 0.0;
            double media = 0.0;


            int n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] leitor = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(leitor[i], CultureInfo.InvariantCulture);
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
                soma = vet[i] + soma;
            }
            Console.WriteLine();

            media = soma / n;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}