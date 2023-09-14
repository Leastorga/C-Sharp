namespace Name{
    class Program{

        public static void Main(string[] args){
            int senha, senhaCorreta;
        
            senha = int.Parse(Console.ReadLine());
            senhaCorreta = 2002;

            while (senha != senhaCorreta){
                if(senha != senhaCorreta){
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());                    
                }    
            }
                Console.WriteLine("Acesso Permitido");
        }
    }
}
