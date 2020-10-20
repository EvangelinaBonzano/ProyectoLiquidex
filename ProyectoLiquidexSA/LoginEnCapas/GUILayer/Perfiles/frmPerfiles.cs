using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLiquidexSA.Entities;
using ProyectoLiquidexSA.BusinessLayer;

namespace ProyectoLiquidexSA.GUILayer.Perfiles
{
    public partial class frmPerfiles : Form
    {
        private PerfilService oPerfilService;


        public frmPerfiles()
        {
            InitializeComponent();
            InitializeDataGridView();
            oPerfilService = new PerfilService();

        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvPerfiles.ColumnCount = 2;
            dgvPerfiles.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvPerfiles.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvPerfiles.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvPerfiles.Columns[0].Name = "Id Perfil";
            dgvPerfiles.Columns[0].DataPropertyName = "IdPerfil";
            dgvPerfiles.Columns[0].Width = 80;
            // Definimos el ancho de la columna.

            dgvPerfiles.Columns[1].Name = "Nombre";
            dgvPerfiles.Columns[1].DataPropertyName = "nombre";
            dgvPerfiles.Columns[1].Width = 140;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = "";

            var filters = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                // Validar si el textBox 'Nombre' esta vacio.
                if (cboNombre.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("p.nombre", cboNombre.Text);
                    condiciones += " AND p.nombre LIKE " + "'%" + cboNombre.Text + "%'";
                }

                if (filters.Count > 0)
                {
                    //si agrego alguna condicion
                    //SIN PARAMETROS

                    MessageBox.Show("condiciones para el where del sql " + condiciones, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dgvPerfiles.DataSource = oPerfilService.ConsultarConFiltrosSinParametros(condiciones);

                    //CON PARAMETROS
                    //dgvPerfil.DataSource = oCursoService.ConsultarConFiltrosConParametros(filters);
                }
                else
                    MessageBox.Show("Debe ingresar al menos un dato.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                //selecciono el checkbox(todos)
                dgvPerfiles.DataSource = oPerfilService.ObtenerTodos();
                habilitar();
            }
        }

        private void habilitar()
        {
            //btnEditar.Enabled = true;
            //btnBorrar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMPerfil formulario = new frmABMPerfil();
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);

        }


        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                cboNombre.Enabled = false;
            }
            else
            {
                cboNombre.Enabled = true;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            //btnEditar.Enabled = false;
            //btnBorrar.Enabled = false;
            this.CenterToParent();
            LlenarCombo(cboNombre, oPerfilService.ObtenerTodos(), "nombre", "nombre");
        }

        
    }
}
