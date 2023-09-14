namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x, par;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    par = x + x + 2 + x + 4 + x + 6 + x + 8;
                }
                else
                {
                    par = x + 1 + x + 3 + x + 5 + x + 7 + x + 9;
                }
                Console.WriteLine(par);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}