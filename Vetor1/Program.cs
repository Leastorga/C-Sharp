using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            double maior = 0.0;
            int contador = 0;
            int n = int.Parse(Console.ReadLine());
            double[] numero = new double[n];

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                numero[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);

                if (maior < numero[i])
                {
                    maior = numero[i];
                    contador++;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(contador);
        }
    }
}