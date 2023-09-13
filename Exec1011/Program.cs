using System; 
using System.Globalization;

namespace SAIDADEDADOS{
    internal class URI{
        static void Main(string[] args){
            double raio, volume, pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = (4.0/3) * pi * Math.Pow(raio,3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}