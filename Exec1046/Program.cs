
namespace Name{
    class Program{
        static void Main(string[]args){
            int inicio, fim, tempo;
            string[] vet = Console.ReadLine().Split(' ');
            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

            if (inicio == fim){
                tempo = 24;
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }else if(inicio > fim){
                tempo = 24 - inicio + fim;
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }else {
                tempo = fim - inicio;
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }
        }   
    }
}