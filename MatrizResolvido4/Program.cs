namespace Name
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] elemento = Console.ReadLine().Split(' '); ;
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(elemento[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                { 
                    soma = soma + matriz[i, j];
                }                
            }
            Console.WriteLine(soma);
        }
    }
}