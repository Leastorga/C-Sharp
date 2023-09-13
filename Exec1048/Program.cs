﻿using System;
using System.Globalization;

namespace Name{
    class Program{
        static void Main(string[] args){
            double salario, reajuste, percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00){
                percentual = 15;
            }
            else if (salario <= 800){
                percentual = 12;
            }
            else if (salario <= 1200.00){
                percentual = 10;
            }
            else if (salario <= 2000.00){
                percentual = 7;
            }
            else{
                percentual = 4;
            }
            reajuste = salario * (percentual / 100);
            salario += reajuste;
            Console.WriteLine("Novo salario: " + salario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}