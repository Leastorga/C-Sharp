namespace Name
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                double x = Math.Pow(i,2);
                double y = Math.Pow(i,3);
                Console.WriteLine(i + " " + x + " " + y );

                x ++;
                y ++;
                Console.WriteLine(i + " " + x + " "+ y);

            }
        }
    }
}