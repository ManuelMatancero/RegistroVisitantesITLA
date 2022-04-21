using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Edificio
    {
        private int idEdificio;
        private String descripcionEdificio;

        public int IdEdificio { get => idEdificio; set => idEdificio = value; }
        public string DescripcionEdificio { get => descripcionEdificio; set => descripcionEdificio = value; }
    }
}
