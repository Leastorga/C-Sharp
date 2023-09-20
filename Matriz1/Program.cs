namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] elemento = Console.ReadLine().Split(' ');
            int m = int.Parse(elemento[0]);
            int n = int.Parse(elemento[1]);
            
            int[,] matriz = new int[m,n];
            for (int i = 0; i < m; i++)
            {
                string[] elemento1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i,j] = int.Parse(elemento1[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        Console.WriteLine(matriz[i,j]);
                    }
                }
            }

        }
    }
}