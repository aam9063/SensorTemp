/*
Crea un programa en C# de ejecución en terminal, que utilizando una estructura while, tome la temperatura exterior leyéndola de un sensor cada hora durante 24 horas.
Al final del día, la estación meteorológica nos mostrará la temperatura más alta y la más baja a partir de las medidas tomadas cada hora.

📌 Nota: Simularemos la lectura del sensor con una entrada por consola del usuario.
*/

using System;

public class Program
{
    public static void Main()
    {
        double maxTemperature = double.MinValue;
        double minTemperature = double.MaxValue;
        int hours = 24;

        Console.WriteLine("Bienvenido a la estación meteorológica");
        Console.WriteLine("Por favor, ingrese la temperatura exterior cada hora:");

        int hour = 1;
        while (hour <= hours)
        {
            Console.Write($"Hora {hour}: ");
            if (double.TryParse(Console.ReadLine(), out double temperature))
            {
                maxTemperature = Math.Max(maxTemperature, temperature);
                minTemperature = Math.Min(minTemperature, temperature);
                hour++;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese una temperatura válida.");
            }
        }

        Console.WriteLine($"Temperatura más alta del día: {maxTemperature}°C");
        Console.WriteLine($"Temperatura más baja del día: {minTemperature}°C");
    }
}
