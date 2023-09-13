using System;
using System.Globalization;

namespace uri{
    class Program{
        static void Main(string[] args){
            int velocidade, tempo;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());
            litros = (double)velocidade / 12 * tempo;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        
        }
    }
}