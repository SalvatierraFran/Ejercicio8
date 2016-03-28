using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 08";


            Console.Write("Ingrese valor hora: ");
            double Valhora = double.Parse(Console.ReadLine());

            Console.Write("Ingrese nombre: ");
            string Nombre = Console.ReadLine();

            Console.Write("Ingrese antigüedad: ");
            double Antiguedad = double.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad de horas trabajadas: ");
            double Canthoras = double.Parse(Console.ReadLine());

            double TotalBruto = (Canthoras * Valhora) + (Antiguedad * 150);

            double Descuentos = (TotalBruto * 13) / 100;

            double TotalNeto = TotalBruto - Descuentos;

            Console.WriteLine("");

            Console.Write("Nombre: " + Nombre);
            Console.Write("\nAntigüedad: " + Antiguedad);
            Console.Write("\nValor de hora: " + Valhora);
            Console.Write("\nCobrar en bruto: " + TotalBruto);
            Console.Write("\nDescuentos: " + Descuentos);
            Console.Write("\nValor neto a cobrar: " + TotalNeto);

            Console.ReadKey();
        }
    }
}
