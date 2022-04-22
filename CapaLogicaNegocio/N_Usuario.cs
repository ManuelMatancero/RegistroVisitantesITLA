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
        //Insertar usuario
        public void insertUsuarioN(E_Usuarios e_Usuario)
        {
            d_Usuarios.insertUsuario(e_Usuario);
        }
        //Actualizar usuario
        public void updateUsuarioN(E_Usuarios e_Usuario)
        {
            d_Usuarios.updateUsuario(e_Usuario);
        }
        //Eliminar Usuario
        public void deleteusuarioN(E_Usuarios e_Usuario)
        {
            d_Usuarios.deleteUsuario(e_Usuario);
        }
        //Listar usuarios por nombre
        public List<E_Usuarios> listarUsPornombreN(String buscar)
        {
            return d_Usuarios.listarUsPornombre(buscar);    
        }
        //Listar usuarios por codigo
        public List<E_Usuarios> listarUsPorcodigoN(String buscar)
        {
            return d_Usuarios.listarUsPorcodigo(buscar);
        }
        //Confirmar si el usuario esta en la base de datos y autenticarlo
        public E_Usuarios usuarioLoginN(String codigoUsuario, String userPassword)
        {
            return d_Usuarios.usuarioLogin(codigoUsuario, userPassword);
        }
    }
}
