using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class N_Aula
    {
        D_Aula d_Aula = new D_Aula();

        public void insertAulaN(E_Aula e_Aula)
        {
            d_Aula.insertAula(e_Aula);
        }

        public void updateAulaN(E_Aula e_Aula, String newId)
        {
            d_Aula.updateAula(e_Aula, newId);
        }

        public List<E_Aula> listarPorIdN(String buscar)
        {
            return d_Aula.listarPorId(buscar);
        }

        public List<E_Aula> listarPorEdificioN(int buscar)
        {
            return d_Aula.listarPorEdificio(buscar);
        }

        public void deleteAulaN(E_Aula e_Aula)
        {
            d_Aula.deleteAula(e_Aula);
        }


    }
}
