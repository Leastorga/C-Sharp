namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int maior = y;
            int menor = x;

            if (x > y)
            {
                maior = x;
                menor = y;
            }

            int soma = 0;
            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma =  soma + i; 
                }
            }
            Console.WriteLine(soma);
        }
    }
}