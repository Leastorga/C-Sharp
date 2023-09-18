namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int x = 1;

            for (int i = 1; i <= n; i ++)

            {
                int y = x + 1;
                int z = x + 2;
                Console.WriteLine(x + " "+ y + " "+ z + " PUM"); 

                x = z + 2;
            }
        }
    }
}