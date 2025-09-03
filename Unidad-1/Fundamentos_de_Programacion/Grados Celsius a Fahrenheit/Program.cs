using Grados_Celsius_a_Fahrenheit;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Temperatura miTemperatura = new Temperatura();
        
        Console.WriteLine("Ingrese la temperatura en grados Celsius:");
        miTemperatura.Celsius = double.Parse(Console.ReadLine());

        Console.WriteLine("La temperatura en grados Fahrenheit es: " + miTemperatura.ConvertirAFahrenheit()+ "°");
    }
}