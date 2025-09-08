using Ejercicio_En_Clase_8_sep._2025_Ed;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Cuadrado miCuadrado = new Cuadrado(5.0, 10.0);
        
        Console.WriteLine("Ingresa el Valor Del Ancho: ");
        miCuadrado.Ancho = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el Valor Del Alto: ");
        miCuadrado.Alto = double.Parse(Console.ReadLine());

        Console.WriteLine("El Resultado del area es : " + miCuadrado.MostrarArea());
        Console.WriteLine("El Resultado del perimetro es : " + miCuadrado.MostrarPerimetro());
        Console.WriteLine("Las Dimensiones De este son : " + miCuadrado.MostrarDimensiones());
    }
}