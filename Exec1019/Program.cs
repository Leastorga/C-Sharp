// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System; 
using System.Globalization;

namespace SAIDADEDADOS{
    internal class URI{
        static void Main(string[] args){
            int entrada, resto, horas, minutos,segundos;
            
            entrada = int.Parse(Console.ReadLine());

            horas = entrada / 3600;
            resto = entrada % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}