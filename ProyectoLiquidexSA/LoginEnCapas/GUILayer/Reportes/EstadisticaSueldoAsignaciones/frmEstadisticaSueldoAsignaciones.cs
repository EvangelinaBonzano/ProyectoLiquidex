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

namespace ProyectoLiquidexSA.GUILayer.Reportes.EstadisticaSueldoAsignaciones
{
    public partial class frmEstadisticaSueldoAsignaciones : Form
    {
        public frmEstadisticaSueldoAsignaciones()
        {
            InitializeComponent();
        }

        private void frmEstadisticaSueldoAsignaciones_Load(object sender, EventArgs e)
        {

            this.CenterToParent();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT u.usuario AS Usuario, a.n_asignacion AS Asignacion, s.cantidad as Cantidad " +
                        " FROM SueldoAsignaciones s" +
                        " INNER JOIN Asignaciones a ON(s.id_asignacion= a.id_asignacion) " +
                        " INNER JOIN Usuarios u ON(s.id_usuario = u.id_usuario)" +
                        " WHERE s.borrado = 0 AND s.fecha BETWEEN'" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'" +
                        " GROUP BY u.usuario, a.n_asignacion, s.cantidad";

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                dtpFechaDesde.Focus();
                return;
            }
            else
            {
                rptEstadisticaSueldoAsignaciones.LocalReport.DataSources.Clear();
                rptEstadisticaSueldoAsignaciones.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticaSueldoAsignaciones", oDm.ConsultaSQL(sql)));
                rptEstadisticaSueldoAsignaciones.RefreshReport();
            }
        }
    }
}
