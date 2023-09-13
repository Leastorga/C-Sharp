using System.Globalization;
using System;

namespace trabalhoLe{
    class Program{
        static void Main(string[] args){
            
            double A,R,pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            A = pi * R * R;

            Console.Write("A=" + A.ToString("F4",CultureInfo.InvariantCulture));
            
        }
    }
}