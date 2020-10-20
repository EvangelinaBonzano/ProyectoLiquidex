using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLiquidexSA.Entities
{
    class SueldoPerfilHistorico
    {
        private int id_perfil;
        private DateTime fecha = DateTime.Today;
        private double sueldo;
        private bool borrado;

        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
    }
}
