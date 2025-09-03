internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        string Opcion;

        do
        {
            int Numero;
            bool NumeroPrimo = true;

            Console.Write("Ingresa un numero: ");
            Numero = int.Parse(Console.ReadLine());

            if (Numero <= 1)
            {
                NumeroPrimo = false;
            }
            else
            {
                for (int x = 2; x <= Math.Sqrt(Numero); x++)
                {
                    if (Numero % x == 0)
                    {
                        NumeroPrimo = false;
                        break;
                    }
                }
            }

            if (NumeroPrimo == true)
            {
                Console.WriteLine("=====Es un numero primo=====");
            }
            else
            {
                Console.WriteLine("=====No es un numero primo=====");
            }

            Console.Write("¿Quieres intentar con otro numero? (si/no): ");
            Opcion = Console.ReadLine().ToLower();

            Console.WriteLine(); // separación visual

        } while (Opcion == "si");
    }
}