namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N, multiplicacao, numero;

            N = int.Parse(Console.ReadLine());
            numero = 1;

            for (int i = 0; i <= 9; i++)
            {
                multiplicacao = numero * N;
                Console.WriteLine(numero + " x " + N + " = " + multiplicacao);
                numero += 1;                
            }
        }
    }
}