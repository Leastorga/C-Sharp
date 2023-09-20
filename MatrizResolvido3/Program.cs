namespace Name
{
    class Name{
        public static void Main(string[] args)
        {
         int n = int.Parse(Console.ReadLine());

         int[,] a = new int [n,n];
         for (int i = 0; i < n; i++)
         {
            string[] elemento = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                a[i,j] = int.Parse(elemento[j]);
            }
         }   

         for (int i = 0; i < n; i++)
         {
            int maior = 0;
            for (int j = 0; j < n; j++)
            {            
                if (a[i,j] > maior)
                {
                    maior = a[i,j];
                }                
            }
            Console.WriteLine(maior);
         }
        }
    }
}