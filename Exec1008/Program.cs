using System;
using System.Globalization;

namespace uri1006 {
    class Program {
        static void Main(string[] args) {
            int numFuncionario, horasTrabalhadas;
            double ganhoHora, salario;

            numFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            ganhoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horasTrabalhadas * ganhoHora;

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}