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
        //Insertar edificio
        public void insertEdificioN(E_Edificio e_Edificio)
        {
            d_Edificio.insertEdificio(e_Edificio);
        }
        //Actualizar ediificio
        public void updateEdificioN(E_Edificio e_Edificio, int seleccion)
        {
            d_Edificio.updateEdificio(e_Edificio, seleccion);
        }
        //Listar edificios
        public List<E_Edificio> listarEdificiosN(int buscar)
        {
            return d_Edificio.listarEdificios(buscar);
        }
        //Listar edificios general
        public List<E_Edificio> listarEdificiosGN()
        {
            return d_Edificio.listarEdificiosG();
        }

    }
}
