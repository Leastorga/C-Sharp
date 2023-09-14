namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int gremio = 0;
            int inter = 0;
            int empates = 0;
            int resposta = 1;


            while (resposta == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int pt1 = int.Parse(vet[0]);
                int pt2 = int.Parse(vet[1]);

                if (pt1 == pt2)
                {
                    empates += 1;
                }
                else if (pt1 > pt2)
                {
                    inter += 1;
                }
                else
                {
                    gremio += 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                resposta = int.Parse(Console.ReadLine());
            }

            int jogos = gremio + inter + empates;

            Console.WriteLine(jogos + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empates);

            if (inter > gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (gremio > inter)
            {
                Console.WriteLine("Gremio venceu mais");
            }else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
