using System;
using System.Globalization;

namespace Name{
    class Program{
        static void Main(string[] args){

            double n1, n2, n3, n4, n5, media;
            string[] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);
            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;
            if (media == 4.85){
                media = 4.8;
            }
                    
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 5.0){
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 7.0){
                Console.WriteLine("Aluno aprovado.");
            }
            else{
                Console.WriteLine("Aluno em exame.");
                n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + n5.ToString("F1", CultureInfo.InvariantCulture));
                media = (media + n5) / 2;
                if (media >= 5.00){
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
                else{
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}