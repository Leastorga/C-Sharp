namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] elemento = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i,j] = int.Parse(elemento[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    soma = soma + a[i,j];
                }
                Console.WriteLine(soma);
            }
        }
    }
}