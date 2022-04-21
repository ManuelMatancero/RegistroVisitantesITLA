using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Visitantes
    {
        private int idVisitante;
        private String nombre;
        private String apellido;
        private String carrera;
        private int edificio;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private String motivoVisita;
        private String idAula;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public int Edificio { get => edificio; set => edificio = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string MotivoVisita { get => motivoVisita; set => motivoVisita = value; }
        public string IdAula { get => idAula; set => idAula = value; }
        public int IdVisitante { get => idVisitante; set => idVisitante = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
    }
}
