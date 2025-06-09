using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEntidad
{
    public class clsUsuario_CE
    {
      
        public int id_User { get; set; }
        public int IdInspector { get; set; }
        public int id_inspector { get; set; }
        public string VigenciaLicencia { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }

        public clsUsuario_CE(){ }
    }
}
