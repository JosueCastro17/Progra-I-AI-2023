using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class CN_Usuario
    {
        private ConsultaUsuarios objconsultausuario = new ConsultaUsuarios();

        public List<Usuarios> Listar()
        {
            return objconsultausuario.Listar();
        }
    }
}
