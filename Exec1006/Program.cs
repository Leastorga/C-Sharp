using System;
using System.Globalization;

namespace uri1006 {
    class Program {
        static void Main(string[] args) {
            double A, B, C, Media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Media = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + Media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}