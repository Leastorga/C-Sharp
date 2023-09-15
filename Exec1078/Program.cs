namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N, multiplicacao, numero;

            N = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= 10; i++)
            {
                multiplicacao = i * N;
                Console.WriteLine(i + " x " + N + " = " + multiplicacao);             
            }
        }
    }
}