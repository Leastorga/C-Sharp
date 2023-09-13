using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace uri{
    class Program{
        static void Main(string[] args){

            int codPeca, qttdPeca, codPeca2, qttdPeca2;
            double preco, preco2, somaTotal;
            string[] entrada = Console.ReadLine().Split(' ');
            codPeca = int.Parse(entrada[0]);
            qttdPeca = int.Parse(entrada[1]);
            preco = double.Parse(entrada[2], CultureInfo.InvariantCulture);
            string[] entrada2 = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(entrada2[0]);
            qttdPeca2 = int.Parse(entrada2[1]);
            preco2 = double.Parse(entrada2[2], CultureInfo.InvariantCulture);
            
            somaTotal = qttdPeca * preco + qttdPeca2 * preco2;

            Console.WriteLine("VALOR A PAGAR: R$ " + somaTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}