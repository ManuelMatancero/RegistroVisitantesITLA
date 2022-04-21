using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class E_Usuarios
    {
        private int idUsuario;
        private String codUsuario;
        private String nombre;
        private String apellido;
        private DateTime fechaNacimiento;
        private String tipoUsuario;
        private String password;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string CodUsuario { get => codUsuario; set => codUsuario = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
