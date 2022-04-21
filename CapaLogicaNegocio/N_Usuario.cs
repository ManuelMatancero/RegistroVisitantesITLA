using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class N_Usuario
    {
        D_Usuarios d_Usuarios = new D_Usuarios();

        public void insertUsuarioN(E_Usuarios e_Usuario)
        {
            d_Usuarios.insertUsuario(e_Usuario);
        }

        public void updateUsuarioN(E_Usuarios e_Usuario)
        {
            d_Usuarios.updateUsuario(e_Usuario);
        }

        public void deleteusuarioN(E_Usuarios e_Usuario)
        {
            d_Usuarios.deleteUsuario(e_Usuario);
        }

        public List<E_Usuarios> listarUsPornombreN(String buscar)
        {
            return d_Usuarios.listarUsPornombre(buscar);    
        }

        public List<E_Usuarios> listarUsPorcodigoN(String buscar)
        {
            return d_Usuarios.listarUsPorcodigo(buscar);
        }

        public E_Usuarios usuarioLoginN(String codigoUsuario, String userPassword)
        {
            return d_Usuarios.usuarioLogin(codigoUsuario, userPassword);
        }
    }
}
