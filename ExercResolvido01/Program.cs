using System.Globalization;

namespace Name{
    class Program{
        static void Main(string[] args){
            double nota1, nota2, notaFinal;

            Console.WriteLine("Digite a nota do primeiro semestre:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota do segundo semestre:");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = nota1 + nota2;
            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

            if (notaFinal < 60.0){
                Console.WriteLine("REPROVADO!");
            }
        }
        
    }
    
}