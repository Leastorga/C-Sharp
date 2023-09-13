using System;
using System.Globalization;

namespace uri{
    class Program{
        static void Main(string[] args){
            int distancia;
            double combustivel, combustivelGasto;

            distancia = int.Parse(Console.ReadLine());
            combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            combustivelGasto = distancia / combustivel;

            Console.WriteLine( combustivelGasto.ToString("F3", CultureInfo.InvariantCulture) +" km/l");

        }
    }
}