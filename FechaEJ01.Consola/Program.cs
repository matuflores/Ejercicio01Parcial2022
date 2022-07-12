using FechaEJ01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaEJ01.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;

            Fecha hoy = "11/02/2020";
            Fecha sistema = new Fecha();

            Console.Write("Ingrese el dia: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mes: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el anio: ");
            anio = int.Parse(Console.ReadLine());

            
            var fecha1 = new Fecha(dia, mes, anio);
            var fecha2 = new Fecha(26, 7, 1996);
            var fecha3 = new Fecha(21, 12, 1998);
            var fecha4 = new Fecha(21, 12, 1998);

            if (fecha1.Validar())
            {
                Console.WriteLine($"Fecha validada: {fecha1.ToString()}");
            }
            else
            {
                Console.WriteLine("Fecha mal ingresada");
            }

            //Inicializar el constructor con las fecha de hoy
            Console.WriteLine($"Fecha del sistema {sistema.ToString()}");

            //Convertir de String a Fecha
            Console.WriteLine($"La fecha ingresada en string es {hoy.ToString()}");

            //Prueba del equals
            if (fecha4 == fecha3)
            {
                Console.WriteLine("Ambas fechas son iguales");
            }
            else
            {
                Console.WriteLine("Las fechas son distintas");
            }

            Console.ReadLine();
        }
    }
}
