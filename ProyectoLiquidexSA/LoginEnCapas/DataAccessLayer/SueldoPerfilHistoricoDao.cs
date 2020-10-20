using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLiquidexSA.Entities;
using System.Data;

namespace ProyectoLiquidexSA.DataAccessLayer
{
    class SueldoPerfilHistoricoDao
    {
        public IList<SueldoPerfilHistorico> GetByIdPerfil(int idPerfil)
        {
            List<SueldoPerfilHistorico> listadoPerfiles = new List<SueldoPerfilHistorico>();

            var strSql = String.Concat("SELECT s.id_perfil, ",
                                      "        s.fecha,",
                                      "        s.sueldo,",
                                      "        s.borrado,",
                                      "   FROM SueldoPerfilHistorico s",
                                      "  WHERE s.borrado = 0 AND s.id_perfil = " + idPerfil.ToString());

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultado.Rows)
            {
                listadoPerfiles.Add(MappingPerfil(row));
            }

            return listadoPerfiles;
        }

        private SueldoPerfilHistorico MappingPerfil(DataRow row)
        {
            SueldoPerfilHistorico oPerfil = new SueldoPerfilHistorico();
            oPerfil.Id_perfil = Convert.ToInt32(row["id_perfil"].ToString());
            oPerfil.Fecha = Convert.ToDateTime(row["fecha"].ToString());
            oPerfil.Sueldo = Convert.ToInt32(row["sueldo"].ToString());
            oPerfil.Borrado = Convert.ToBoolean(row["borrado"].ToString());
            

            return oPerfil;
        }
    }
}
