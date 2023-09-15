using System; 
namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split();
                int quantia = int.Parse(vet[0]);
                string tipo = vet[1];

                if (tipo == "C")
                {
                    coelhos = coelhos + quantia;
                }
                else if (tipo == "R")
                {
                    ratos = ratos + quantia;
                }
                else
                {
                    sapos = sapos + quantia;
                }

            }
            int total = coelhos + ratos + sapos;
            double pC = (double)coelhos / total * 100.00;
            double pR = (double)ratos / total * 100.00;
            double pS = (double)sapos / total * 100.00;
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + pC.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + pR.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + pS.ToString("F2") + " %");
        }
    }
}