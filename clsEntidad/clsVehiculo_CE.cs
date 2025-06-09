using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsEntidad;


namespace clsEntidad
{
    public class clsVehiculo_CE
    {
        public int IdVehiculo { get; set; }
        public string CodigoVehiculo { get; set; }
        public int IdConductor { get; set; }
        public string NumeroPlaca { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string FechaRegistro { get; set; }
        public int NumeroAsientos { get; set; }
        public string Estado { get; set; }

        public clsVehiculo_CE() { }
    }
}
