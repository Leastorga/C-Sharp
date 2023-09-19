using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            double soma = 0.0;
            double media = 0.0;


            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            //  LEITURA DE DADOS
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
                altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }
            // CALCULO DA ALTURA DAS PESSOAS
            for (int i = 0; i < n; i++)
            {
                soma = soma + altura[i];
            }
            media = soma / n;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            // PORCENTAGEM DE PESSOAS ABAIXO DE 16
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (idade[i] < 16)
                {
                    cont++;
                }
            }
            double porcento = (double) cont / n * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcento.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}