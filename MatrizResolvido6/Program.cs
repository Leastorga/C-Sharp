using System.Globalization;

namespace Name
{
    class MyClass
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double[,] matriz = new double[n, n];

            // leitura dos numeros para a matriz
            for (int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = double.Parse(element[j], CultureInfo.InvariantCulture);
                }
            }
            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            // soma dos positivos
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > 0)
                    {
                        soma += matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            // Linha escolhida
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (linha == i)
                    {
                        Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
            Console.WriteLine();

            // Coluna escolhida
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            // Diagonal principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //Matriz alterada
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0.0)
                    {
                        Console.Write((matriz[i, j] * matriz[i, j]).ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    else
                    {
                        Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}