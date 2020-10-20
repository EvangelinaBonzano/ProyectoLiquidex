using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLiquidexSA.Entities;
using ProyectoLiquidexSA.DataAccessLayer;

namespace ProyectoLiquidexSA.BusinessLayer
{
    public class PerfilService
    {
        private PerfilDao oPerfilDao;
        public PerfilService()
        {
            oPerfilDao = new PerfilDao();
        }
        public IList<Perfil> ObtenerTodos()
        {
            return oPerfilDao.GetAll();
        }

        internal IList<Perfil> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oPerfilDao.GetByFiltersSinParametros(condiciones);
        }

        internal object ObtenerPerfil(string perfil)
        {
            //SIN PARAMETROS
            return oPerfilDao.GetUserConParametros(perfil);

            //CON PARAMETROS
            // return oPerfilDao.GetUserConParametros(usuario);
        }

        internal bool CrearPerfil(Perfil oPerfil, SueldoPerfilHistorico oSueldoPerfilHistorico)
        {
            return oPerfilDao.Create(oPerfil, oSueldoPerfilHistorico);
        }

        internal bool ActualizarPerfil(Perfil oPerfilSelected)
        {
            return oPerfilDao.Update(oPerfilSelected);
        }

        internal bool BorrarPerfil(Perfil oPerfilSelected)
        {
            return oPerfilDao.Delete(oPerfilSelected);
        }

    }
}
