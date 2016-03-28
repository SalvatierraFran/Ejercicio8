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

            char rta = 's';

            do
            {
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

                Console.Write("Nombre\tAntigüedad\tValorHora\tSalarioBruto\tDescuentos\tSalarioNeto\n");
                Console.Write("{0}\t{1}\t\t{2:f2}\t\t{3:f2}\t\t{4:f2}\t\t{5:f2}", Nombre, Antiguedad, Valhora, TotalBruto, Descuentos, TotalNeto);

                Console.Write("\n\nDesea continuar ingresando? S/N: ");
                rta = char.Parse(Console.ReadLine());

                if (rta != 's' && rta != 'n' && rta != 'S' && rta != 'N')
                {
                    Console.Write("\nError. Reingrese: ");
                    rta = char.Parse(Console.ReadLine());
                }

            } while (rta == 's');
            Console.ReadKey();
        }
    }
}
