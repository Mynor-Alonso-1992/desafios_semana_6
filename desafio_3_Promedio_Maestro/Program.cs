using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los puntajes del alumno (entre 1 y 10), escriba 'fin' para terminar:");

        int totalPuntajes = 0;
        int cantidadPuntajes = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "fin")
            {
                break;
            }

            if (int.TryParse(input, out int puntaje))
            {
                if (puntaje >= 1 && puntaje <= 10)
                {
                    totalPuntajes += puntaje;
                    cantidadPuntajes++;
                }
                else
                {
                    Console.WriteLine("El puntaje debe estar entre 1 y 10. Intente nuevamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente nuevamente.");
            }
        }

        if (cantidadPuntajes > 0)
        {
            double promedio = (double)totalPuntajes / cantidadPuntajes;
            Console.WriteLine($"El puntaje promedio del alumno es: {promedio:F2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron puntajes válidos.");
        }
    }
}
