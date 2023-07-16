using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Venta
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Detalle { get; set; }
        public decimal Monto { get; set; }
        public decimal Total { get; set; }
    }
}
