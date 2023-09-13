using System; 
using System.Globalization;

namespace SAIDADEDADOS{
    internal class URI{
        static void Main(string[] args){
            int a, b, c, maiorAB, maiorC;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorAB = (a + b + Math.Abs(a-b))/ 2;
            maiorC =  (c + maiorAB + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maiorC + " eh o maior");

        }
    }
}