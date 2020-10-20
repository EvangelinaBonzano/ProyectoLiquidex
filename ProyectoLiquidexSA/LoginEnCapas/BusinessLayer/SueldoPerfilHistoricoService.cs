using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLiquidexSA.Entities;
using ProyectoLiquidexSA.DataAccessLayer;

namespace ProyectoLiquidexSA.BusinessLayer
{
    class SueldoPerfilHistoricoService
    {
        private SueldoPerfilHistoricoDao oSueldoPerfilHistoricoDao;
        public SueldoPerfilHistoricoService()
        {
            oSueldoPerfilHistoricoDao = new SueldoPerfilHistoricoDao();
        }
        public IList<SueldoPerfilHistorico> ConsultarPorIdBug(int idPerfil)
        {
            return oSueldoPerfilHistoricoDao.GetByIdPerfil(idPerfil);
        }
    }
}
