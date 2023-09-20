namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] element = Console.ReadLine().Split(' ');
            int m = int.Parse(element[0]);
            int n = int.Parse(element[1]);

            int[,] a = new int[m, n];
            
            for (int i = 0; i < m; i++)
            {
                string[] element1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(element1[j]);
                }
            }

            int[] vetor = new int[m];
            for (int i = 0; i < m; i++)
            {
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    soma = soma + a[i, j];
                }
                vetor[i] = soma;
                Console.WriteLine(vetor[i]);
            }
        }
    }
}