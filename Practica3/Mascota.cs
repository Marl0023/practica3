using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica3;

namespace Practica3
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }

        public override string ToString() => $"Nombre: {Nombre}, Edad: {Edad}, Especie: {Especie}";

        public static Mascota CrearMascota()
        {
            Console.Write("Nombre de la mascota: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad de la mascota: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Especie de la mascota: ");
            string especie = Console.ReadLine();

            return new Mascota { Nombre = nombre, Edad = edad, Especie = especie };
        }

        public static void ListarMascotas(Mascota[] mascotas, int count)
        {
            Console.WriteLine("=== Lista de Mascotas ===");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}. {mascotas[i]}");
            }
        }

        public static void EliminarMascota(Mascota[] mascotas, ref int count)
        {
            ListarMascotas(mascotas, count);
            Console.Write("Seleccione el índice de la mascota a eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    mascotas[i] = mascotas[i + 1];
                }
                mascotas[--count] = null;
                Console.WriteLine("Mascota eliminada con éxito.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }
    }
}
