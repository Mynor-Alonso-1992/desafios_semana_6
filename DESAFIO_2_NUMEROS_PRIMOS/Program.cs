using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (EsPrimo(numero))
        {
            Console.WriteLine("El número ingresado es primo.");
        }
        else
        {
            Console.WriteLine("El número ingresado NO es primo.");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
