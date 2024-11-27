using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica3;

namespace Practica3
{
    public class Boleta
    {
        public string Codigo { get; set; }
        public Mascota Mascota { get; set; }
        public Servicio Servicio1 { get; set; }
        public Servicio Servicio2 { get; set; }
        public decimal Total { get; private set; }

        public void CalcularTotal()
        {
            Total = Servicio1.Precio + Servicio2.Precio;
        }

        public override string ToString() =>
            $"Código: {Codigo}, Mascota: {Mascota.Nombre}, Servicio 1: {Servicio1.Descripcion}, Servicio 2: {Servicio2.Descripcion}, Total: {Total:C}";

        public static Boleta CrearBoleta(Mascota[] mascotas, int mascotaCount, Servicio[] servicios, int servicioCount, int boletaCount)
        {
            Mascota.ListarMascotas(mascotas, mascotaCount);
            Console.Write("Seleccione el índice de la mascota: ");
            int mascotaIndex = int.Parse(Console.ReadLine());

            if (mascotaIndex >= 0 && mascotaIndex < mascotaCount)
            {
                Mascota mascotaSeleccionada = mascotas[mascotaIndex];

                Servicio.ListarServicios(servicios, servicioCount);
                Console.Write("Seleccione el índice del primer servicio: ");
                int servicio1Index = int.Parse(Console.ReadLine());
                Console.Write("Seleccione el índice del segundo servicio: ");
                int servicio2Index = int.Parse(Console.ReadLine());

                if (servicio1Index >= 0 && servicio1Index < servicioCount &&
                    servicio2Index >= 0 && servicio2Index < servicioCount)
                {
                    Servicio servicio1 = servicios[servicio1Index];
                    Servicio servicio2 = servicios[servicio2Index];

                    Boleta nuevaBoleta = new Boleta
                    {
                        Codigo = $"B{boletaCount + 1:D3}",
                        Mascota = mascotaSeleccionada,
                        Servicio1 = servicio1,
                        Servicio2 = servicio2
                    };
                    nuevaBoleta.CalcularTotal();

                    return nuevaBoleta;
                }
                else
                {
                    Console.WriteLine("Índices de servicios inválidos.");
                }
            }
            else
            {
                Console.WriteLine("Índice de mascota inválido.");
            }
            return null;
        }

        public static void ListarBoletas(Boleta[] boletas, int count)
        {
            Console.WriteLine("=== Lista de Boletas ===");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}. {boletas[i]}");
            }
        }
    }
}
