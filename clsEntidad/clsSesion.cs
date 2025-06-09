using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEntidad
{
    public static class clsSesion
    {
        public static int IdInspector { get; set; }
        public static string Usuario { get; set; }
        public static string Password { get; set; }
        public static string Correo { get; set; }
        public static string Cargo { get; set; }
        public static string Estado { get; set; }
        public static string VigenciaLicencia { get; set; }

        // Puedes agregar más propiedades que necesites guardar durante la sesión
    }
}
