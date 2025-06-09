using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDatos;
using clsEntidad;

namespace clsNegocio
{
    public class clsUsuario_CN
    {
        private clsUsuario_DB db = new clsUsuario_DB();

        public DataTable mtdListaUsuario()
        {
            return db.mtdListaUsuarios();
        }

        public DataTable mtdAutenticarUsuario(string usuario, string password)
        {
            return db.mtdAutenticarUsuario(usuario, password);
        }
        public void mtdAgregarUsuario(clsUsuario_CE o) 
        {
            db.mtdAgregarUsuarioSQL(o);
        }
        public DataTable mtdObtenerUsuarioPorNombre(string usuario)
        {
            clsUsuario_DB datos = new clsUsuario_DB();
            return datos.mtdObtenerUsuarioPorNombre(usuario);
        }
            
        public void mtdModificarUsuario(clsUsuario_CE o) 
        { db.mtdModificarUsuarioSQl(o); }

        public bool ExisteUsuarioPorInspectorID(int idInspector)
        {
            return db.ExisteUsuarioPorInspectorID(idInspector);
        }

    }
}
