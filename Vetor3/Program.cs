namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(vet[i]);
            }

            vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(vet[i]);
            }

            int[] c = new int[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i]; 
                Console.Write(c[i] + " ");
            }

        }
    }
}