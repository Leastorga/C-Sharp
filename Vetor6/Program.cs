namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];

            string[] elemento = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                nome[i] = elemento[0];
                idade[i] = int.Parse(elemento[1]);
            }

            int maior = idade[0];
            int contador = 0;
            for (int i = 0; i < n; i++)
            {
                if (idade[i] > maior )
                {
                    maior = idade[i];
                    contador = i;
                }
            }
            Console.WriteLine("Pessoas mais velha: " + nome[contador]);

        }
    }
}