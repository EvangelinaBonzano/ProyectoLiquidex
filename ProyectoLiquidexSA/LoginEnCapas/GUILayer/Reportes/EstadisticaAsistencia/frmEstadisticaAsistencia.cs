using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ProyectoLiquidexSA.GUILayer.Reportes.EstadisticaAsistencia
{
    public partial class frmEstadisticaAsistencia : Form
    {
        public frmEstadisticaAsistencia()
        {
            InitializeComponent();
        }

        private void lblFechaDesde_Click(object sender, EventArgs e)
        {

        }

        private void frmEstadisticaAsistencia_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql= " SELECT u.usuario AS Usuario, e.n_estados_asistencia AS Estado, COUNT(*) as Cantidad " +
                        " FROM AsistenciaUsuarios a" +
                        " INNER JOIN EstadosAsistencia e ON(a.id_estado_asistencia= e.id_estado_asistencia)" +
                        " INNER JOIN Usuarios u ON(a.id_usuario = u.id_usuario)" +
                        " WHERE a.borrado = 0 AND a.fecha BETWEEN'" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'" +
                        " GROUP BY u.usuario, e.n_estados_asistencia";

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                dtpFechaDesde.Focus();
                return;
            }
            else
            {
                rptEstadisticaAsistencia.LocalReport.DataSources.Clear();
                rptEstadisticaAsistencia.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticaAsistencia", oDm.ConsultaSQL(sql)));
                rptEstadisticaAsistencia.RefreshReport();
            }

        }
    }
}
