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

namespace ProyectoLiquidexSA.GUILayer.Reportes.EstadisticaDescuentosSueldo
{
    public partial class frmEstadisticaSueldosDescuento : Form
    {
        public frmEstadisticaSueldosDescuento()
        {
            InitializeComponent();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT u.usuario AS Usuario, d.n_descuento AS Descuento, s.cantidad as Cantidad " +
                        " FROM SueldoDescuentos s" +
                        " INNER JOIN Descuentos d ON(s.id_descuento= d.id_descuento)" +
                        " INNER JOIN Usuarios u ON(s.id_usuario = u.id_usuario)" +
                        " WHERE s.borrado = 0 AND s.fecha BETWEEN'" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'" +
                        " GROUP BY u.usuario, d.n_descuento, s.cantidad";

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                dtpFechaDesde.Focus();
                return;
            }
            else
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticaDescuentosSueldo", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
            }
        }

        private void frmEstadisticaSueldosDescuento_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
