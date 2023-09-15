namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {   double resultado;
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n ; i++)
            {
                if (i % 2 == 0)
                {
                    resultado = Math.Pow(i,2);
                    Console.WriteLine(i + "^2 = " + resultado);
                }
            }
        }
    }
}