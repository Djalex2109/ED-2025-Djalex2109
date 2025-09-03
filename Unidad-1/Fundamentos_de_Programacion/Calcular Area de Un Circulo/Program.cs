using Calcular_Area_de_Un_Circulo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Circulo miCirculo = new Circulo();
       
        Console.WriteLine("Ingrese el valor de radio:");
        miCirculo.Radio = double.Parse(Console.ReadLine());

        Console.WriteLine("El area del circulo es: " + miCirculo.Area());
    }
}