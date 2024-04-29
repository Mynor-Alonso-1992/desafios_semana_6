using System;
using System.Collections.Generic;

class Caja
{
    public double Alto { get; set; }
    public double Ancho { get; set; }
    public double Profundidad { get; set; }

    public double CalcularVolumen()
    {
        return Alto * Ancho * Profundidad;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Caja> cajas = new List<Caja>();

        // Solicitar al usuario las dimensiones de cada caja
        Console.WriteLine("Ingrese las dimensiones de cada caja (alto, ancho, profundidad).");
        Console.WriteLine("Ingrese 'fin' para finalizar la entrada.");

        while (true)
        {
            Console.Write("Caja #{0}: ", cajas.Count + 1);
            string input = Console.ReadLine();

            if (input.ToLower() == "fin")
                break;

            string[] dimensiones = input.Split();
            if (dimensiones.Length != 3)
            {
                Console.WriteLine("Formato de entrada incorrecto. Por favor, ingrese tres valores separados por espacios.");
                continue;
            }

            if (double.TryParse(dimensiones[0], out double alto) &&
                double.TryParse(dimensiones[1], out double ancho) &&
                double.TryParse(dimensiones[2], out double profundidad))
            {
                cajas.Add(new Caja { Alto = alto, Ancho = ancho, Profundidad = profundidad });
            }
            else
            {
                Console.WriteLine("Valores ingresados no válidos. Por favor, ingrese números.");
            }
        }

        // Calcular el total del volumen
        double totalVolumen = 0;
        foreach (var caja in cajas)
        {
            totalVolumen += caja.CalcularVolumen();
        }

        // Calcular el volumen promedio
        double volumenPromedio = totalVolumen / cajas.Count;

        // Mostrar resultados
        Console.WriteLine("Total del volumen de las cajas: " + totalVolumen);
        Console.WriteLine("Volumen promedio de las cajas: " + volumenPromedio);
    }
}
