// See https://aka.ms/new-console-template for more information


//Una empresa desea evaluar mediante un programa en C# a través de una función cuadrática su demanda
//considerando la siguiente gráfica:
//Realizar la simulación para precios que van de 5 en 5 hasta 150. Presente los resultados tabulados y alineados
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Precio |p|\tDemanda |qd|");
        Console.WriteLine("============================");
        for (int p = 5; p <= 150; p += 5)
        {
            int qd = CDemanda(p);
            Console.WriteLine($"{p}\t\t{qd}");
        }
        Console.WriteLine("============================");
        Console.Write("Ingrese la cantidad de demanda: ");
        int demanda = int.Parse(Console.ReadLine());

        int precio = HallarPrecio(demanda);
        Console.WriteLine($"El precio para una demanda de {demanda} es: {precio}");
    }

    static int HallarPrecio(int qd)
    {
        double discriminante, monto, monto1;
        discriminante = Math.Sqrt(10000 - 4 * 1 * (2500 - qd));
        monto = (100 + discriminante) / 2; monto1 = (100 - discriminante) / 2;
        return (int)Math.Max(monto, monto1);
    }
    static int CDemanda(int p)
    {
        return p * p - 100 * p + 2500;
    }

}
