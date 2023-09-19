namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int contador = 0;
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {

                num[i] = int.Parse(vet[i]);

                if (num[i] % 2 == 0)
                {
                    Console.Write(num[i] + " ");
                    contador++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(contador);

        }
    }
}