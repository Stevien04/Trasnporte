using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEntidad
{
    public class clsMulta_CE
    {
        public int IdMultas { get; set; }
        public int IdConductor { get; set; }
        public string CodigoMulta { get; set; }
        public DateTime FechaMulta { get; set; }
        public string Monto { get; set; }
        public decimal? ValorUIT { get; set; }
        public string VehiDeposito { get; set; }
        public string EstadoMulta { get; set; }
        public string Observaciones { get; set; }
        public int IdInspectorResponsable { get; set; }
    }
}
