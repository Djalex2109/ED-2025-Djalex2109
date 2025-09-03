internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Random NumAleatorio = new Random();
        int NumeroAdivinar = NumAleatorio.Next (1,50);
        int Intento = 0;
        int incremento = 0;

        Console.WriteLine("Adivina El Numero Que Estoy Pensando");

        do
        {
            Console.WriteLine("========Intentalo Hasta Adivinar========");
            Intento=int.Parse(Console.ReadLine());
            incremento++;

            if (Intento < NumeroAdivinar)
            {
                Console.WriteLine("El Numero Debe Ser Mayor");
            }
            else if (Intento > NumeroAdivinar)
            {
                Console.WriteLine("El Numero Debe Ser Menor");
            }
        } while (Intento!= NumeroAdivinar);

        Console.WriteLine("¡¡Adivinaste El Numero, Estos Fueron Tus Intentos:" + (incremento));          
    }
}