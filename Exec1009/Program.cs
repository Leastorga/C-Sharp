using System; 
using System.Globalization;

namespace SAIDADEDADOS{
    internal class URI{
        static void Main(string[] args){
            string nome;
            double salario, totalVendas, salarioTotal;
            

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            salarioTotal =  salario + totalVendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));    

        }
    }
}