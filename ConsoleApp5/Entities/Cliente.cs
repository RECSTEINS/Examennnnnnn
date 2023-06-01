using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public string mz { get; set; }
        public string sm { get; set; }
        public string lt { get; set; }
        public DateTime fecha { get; set; }

        public List<Cliente> Infomarcion = new List<Cliente>();
    }
}
