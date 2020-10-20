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
using ProyectoLiquidexSA.BusinessLayer;

namespace ProyectoLiquidexSA.GUILayer.Reportes.ReporteDescuentosSueldo
{
    public partial class frmReporteDescuentosSueldo : Form
    {
        private UsuarioService oUsuarioService;
        public frmReporteDescuentosSueldo()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
        }

        

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT   SueldoDescuentos.fecha, Usuarios.usuario, Descuentos.n_descuento, SueldoDescuentos.cantidad, " +
                         "          SueldoDescuentos.monto " +
                         " FROM     SueldoDescuentos " +
                         " INNER JOIN Descuentos ON SueldoDescuentos.id_descuento = Descuentos.id_descuento " +
                         " INNER JOIN Usuarios ON SueldoDescuentos.id_usuario = Usuarios.id_usuario";


            if (!chkTodos.Checked)
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    dtpFechaDesde.Focus();
                    return;
                }
                else
                {
                    sql += " AND SueldoDescuentos.fecha BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosDescuentosSueldo", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }

                if (cboNombresUsuario.Text != string.Empty)
                {
                    // Si el combo tiene un estado seleccionado, la recuperamos con el value
                    sql += "  AND Usuarios.id_usuario =" + cboNombresUsuario.SelectedValue.ToString();
                    cboNombresUsuario.SelectedIndex = -1;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosDescuentosSueldo", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();

                }

            }
            else
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosDescuentosSueldo", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
                chkTodos.Checked = false;
            }

        
        }

        private void frmReporteDescuentosSueldo_Load(object sender, EventArgs e)
        {

            this.CenterToParent();
            this.cargarCombo(cboNombresUsuario, oUsuarioService.ObtenerTodos(), "NombreUsuario", "IdUsuario");
        }

        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
    }
}
