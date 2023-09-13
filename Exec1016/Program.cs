using System;
using System.Globalization;

namespace uri{
    class Program{
        static void Main(string[] args){
            int quilometros, tempo;

            quilometros = int.Parse(Console.ReadLine());
            tempo = quilometros * 2;

            Console.WriteLine(tempo + " minutos");

        }
    }
}