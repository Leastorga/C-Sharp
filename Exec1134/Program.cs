
namespace cla
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n1, alcool = 0, gasolina = 0, diesel = 0;

            n1 = int.Parse(Console.ReadLine());

            while (n1 != 4)
            {
                if (n1 == 3)
                {
                    diesel += 1;
                }
                else if (n1 == 1)
                {
                    alcool += 1;
                }
                else if (n1 == 2)
                {
                    gasolina += 1;
                }
                n1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}