using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class N_Edificio
    {
        D_Edificio d_Edificio = new D_Edificio();

        public void insertEdificioN(E_Edificio e_Edificio)
        {
            d_Edificio.insertEdificio(e_Edificio);
        }

        public void updateEdificioN(E_Edificio e_Edificio, int seleccion)
        {
            d_Edificio.updateEdificio(e_Edificio, seleccion);
        }

        public List<E_Edificio> listarEdificiosN(int buscar)
        {
            return d_Edificio.listarEdificios(buscar);
        }
        public List<E_Edificio> listarEdificiosGN()
        {
            return d_Edificio.listarEdificiosG();
        }

    }
}
