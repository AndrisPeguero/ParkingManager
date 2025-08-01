using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemaDeParqueos
{
    public class Parqueo
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; } 
        public DateTime FechaRegistro { get; set; }
    }
}
