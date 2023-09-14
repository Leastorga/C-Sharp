
using System.Globalization;

namespace Name{
    class Program{
        public static void Main(string[] args){

            double idade, soma, media;
            int contagem;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            contagem = 0;

            while (idade >= 0){
                soma = soma + idade;
                contagem = contagem + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if(contagem == 0){
                Console.WriteLine("impossivel calcular");
            }else
            {
            media = soma / contagem;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));                
            }
        }
    }
}