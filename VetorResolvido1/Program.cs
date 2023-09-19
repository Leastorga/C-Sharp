namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] vet;
            int n = int.Parse(Console.ReadLine());
            vet = new int[n];

          
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }                        

            for (int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}