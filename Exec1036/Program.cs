﻿using System;
using System.Globalization;

namespace Name{
    class Program{
        static void Main(string[]args){
            double a, b, c, delta, x1, x2;
            
            string[] vet = Console.ReadLine().Split(' ');
            
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b,2) - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta))/ (2 * a);
            x2 = (-b - Math.Sqrt(delta))/ (2 * a) ;

            if (delta < 0 || a == 0){
                Console.WriteLine("Impossivel calcular");
            } else{
                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
                
            } 

        }
        
    }
    
}