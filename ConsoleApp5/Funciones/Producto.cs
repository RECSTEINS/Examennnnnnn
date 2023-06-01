using ConsoleApp5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Funciones
{
    public class Producto
    {
        
        public void TotalCompra(List <Cliente> lista) 
        {
            Cliente ejecutar = new Cliente();
            Console.WriteLine("Ingrese el total de su compra");
            int total = int.Parse(Console.ReadLine());

            if (total < 1000)
            {
                Console.WriteLine("El total es: " + total);
                Console.WriteLine("Al ser un total menor a 1000 se tiene que pagar un envio (250)");
                int resultado = total + 250;

                Console.WriteLine("A continuación se presentan sus datos: ");
                

                foreach (Cliente item in lista) 
                {
                    Console.WriteLine("Nombre: " + item.nombre);
                    Console.WriteLine("Correo: " + item.correo);
                    Console.WriteLine("Mz: " + item.mz);
                    Console.WriteLine("SM: " + item.sm);
                    Console.WriteLine("Lt: " + item.lt);
                    Console.WriteLine("Fecha: " + item.fecha);
                    Console.WriteLine("Total: " + resultado);
                }
            }

            else
            {
                Console.WriteLine("El total es: " + total);
                Console.WriteLine("Al ser un total mayor a 1000 se le daran 3 meses sin intereses.");
                int resultado = total / 3;

                Console.WriteLine("A continuación se presentan sus datos: ");

                foreach (Cliente item in lista)
                {
                    Console.WriteLine("Nombre: " + item.nombre);
                    Console.WriteLine("Correo: " + item.correo);
                    Console.WriteLine("Mz: " + item.mz);
                    Console.WriteLine("SM: " + item.sm);
                    Console.WriteLine("Lt: " + item.lt);
                    Console.WriteLine("Fecha: " + item.fecha);
                    Console.WriteLine("Total: " + resultado);
                }
            }
        }
    }
}
