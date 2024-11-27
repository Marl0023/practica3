using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica3;

namespace Practica3
{
    public class Servicio
    {
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public override string ToString() => $"Descripción: {Descripcion}, Precio: {Precio:C}";

        public static Servicio CrearServicio()
        {
            Console.Write("Descripción del servicio: ");
            string descripcion = Console.ReadLine();
            Console.Write("Precio del servicio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            return new Servicio { Descripcion = descripcion, Precio = precio };
        }

        public static void ListarServicios(Servicio[] servicios, int count)
        {
            Console.WriteLine("=== Lista de Servicios ===");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}. {servicios[i]}");
            }
        }

        public static void EliminarServicio(Servicio[] servicios, ref int count)
        {
            ListarServicios(servicios, count);
            Console.Write("Seleccione el índice del servicio a eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    servicios[i] = servicios[i + 1];
                }
                servicios[--count] = null;
                Console.WriteLine("Servicio eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }
    }
}
