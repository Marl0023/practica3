using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica3;

namespace Practica3
{
    class Program
    {
        static Mascota[] mascotas = new Mascota[10];
        static Servicio[] servicios = new Servicio[10];
        static Boleta[] boletas = new Boleta[10];

        static int mascotaCount = 0, servicioCount = 0, boletaCount = 0;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Menú Veterinaria ===");
                Console.WriteLine("1. Crear Servicio");
                Console.WriteLine("2. Eliminar Servicio");
                Console.WriteLine("3. Listar Servicios");
                Console.WriteLine("4. Crear Mascota");
                Console.WriteLine("5. Eliminar Mascota");
                Console.WriteLine("6. Listar Mascotas");
                Console.WriteLine("7. Crear Boleta");
                Console.WriteLine("8. Listar Boletas");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (servicioCount < servicios.Length)
                        {
                            servicios[servicioCount++] = Servicio.CrearServicio();
                        }
                        break;
                    case 2:
                        Servicio.EliminarServicio(servicios, ref servicioCount);
                        break;
                    case 3:
                        Servicio.ListarServicios(servicios, servicioCount);
                        break;
                    case 4:
                        if (mascotaCount < mascotas.Length)
                        {
                            mascotas[mascotaCount++] = Mascota.CrearMascota();
                        }
                        break;
                    case 5:
                        Mascota.EliminarMascota(mascotas, ref mascotaCount);
                        break;
                    case 6:
                        Mascota.ListarMascotas(mascotas, mascotaCount);
                        break;
                    case 7:
                        if (boletaCount < boletas.Length)
                        {
                            boletas[boletaCount++] = Boleta.CrearBoleta(mascotas, mascotaCount, servicios, servicioCount, boletaCount);
                        }
                        break;
                    case 8:
                        Boleta.ListarBoletas(boletas, boletaCount);
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 0);
        }
    }
}
