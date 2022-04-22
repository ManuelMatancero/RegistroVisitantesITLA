using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;


namespace CapaLogicaNegocio
{
    public class N_Visitante
    {
        D_Visitantes d_Visitantes = new D_Visitantes();
        //Insertar visitante
        public void insertVisitanteN(E_Visitantes e_Visitantes)
        {
            d_Visitantes.insertVisitante(e_Visitantes);
        }
        //Listar visitantes por nombre
        public List<E_Visitantes> listarVisitasPorNombN(string buscar)
        {
            return d_Visitantes.listarVisitasPorNomb(buscar);
        }
        //Listar visitantes por edificios
        public List<E_Visitantes> listarVisitasPorEdifN(int buscar)
        {
            return d_Visitantes.listarVisitasPorEdif(buscar);
        }

    }
}
