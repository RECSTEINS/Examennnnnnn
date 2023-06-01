using ConsoleApp5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Funciones
{
    public class Usuario
    {
        public void PedirInfo()
        {
            Producto producto = new Producto();
            Console.WriteLine("Bienvenido, por favor ingrese su información.");
            Console.WriteLine("Nombre: ");
            string nombreC = Console.ReadLine();
            Console.WriteLine("Correo electronico: ");
            string correoC = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección");
            Console.WriteLine("Mz: ");
            string mzC = Console.ReadLine();
            Console.WriteLine("Sm: ");
            string smC = Console.ReadLine();
            Console.WriteLine("Lt: ");
            string ltC = Console.ReadLine();

            DateTime fechaC = DateTime.Now;

            Cliente agregarInfo = new Cliente();
            {
                agregarInfo.nombre = nombreC;
                agregarInfo.correo = correoC;
                agregarInfo.mz = mzC;
                agregarInfo.sm = smC;
                agregarInfo.lt = ltC;
                agregarInfo.fecha = fechaC;
            }

            agregarInfo.Infomarcion.Add(agregarInfo);
            

            Console.ReadKey();
            Console.Clear();
            producto.TotalCompra(agregarInfo.Infomarcion);
        }
        
    }
}
