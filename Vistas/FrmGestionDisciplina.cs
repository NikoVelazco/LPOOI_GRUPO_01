using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmGestionDisciplina : Form
    {
        //private string nombreUsuario;
        public FrmGestionDisciplina()
        {
            InitializeComponent();
        }

        
        /**
        * Cargar Disciplina
        * */
        private void CargarDisciplina()
        {
            dgvDisciplina.DataSource = TrabajarDisciplina.listarDisciplinas();
            dgvDisciplina.Columns["ID"].Visible = false;
        }

        private void FrmGestionDisciplina_Load(object sender, EventArgs e)
        {
            CargarDisciplina();
        }

        private void txtBusquedaDisc_TextChanged(object sender, EventArgs e)
        {
            dgvDisciplina.DataSource = TrabajarDisciplina.buscarDisciplina(txtBusquedaDisc.Text);
        }

        private void dgvDisciplina_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvDisciplina.SelectedRows.Count > 0 && !dgvDisciplina.CurrentRow.IsNewRow)
            {

                txtNombre.Text = dgvDisciplina.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvDisciplina.CurrentRow.Cells["Descripcion"].Value.ToString();

            }
        }

        /**
        * Limpiar campos cargados
        * */
       
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Util.clearTextBox(pnlGestion);
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
        }



        /**
        * Editar Disciplina
        * */

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Deseas modificar una Disciplina?", "Disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Disciplina oDis = new Disciplina();
                oDis.Dis_Nombre = txtNombre.Text;
                oDis.Dis_Descripcion = txtDescripcion.Text;
                oDis.Dis_ID = int.Parse(dgvDisciplina.CurrentRow.Cells["ID"].Value.ToString());

                TrabajarDisciplina.ModificarDisciplina(oDis);
                CargarDisciplina();

            }  
        }

        /**
        * Eliminar Disciplina
        * */

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Deseas eliminar ésta Disciplina?", "Disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                TrabajarDisciplina.eliminarDisciplina(int.Parse(dgvDisciplina.CurrentRow.Cells["ID"].Value.ToString()));
                CargarDisciplina();
            }
        }

        /**
        * Guardar Disciplina
        * */

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Deseas registrar una Disciplina?", "Disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Disciplina oDis = new Disciplina();
                oDis.Dis_Nombre = txtNombre.Text;
                oDis.Dis_Descripcion = txtDescripcion.Text;

                TrabajarDisciplina.altaDisciplina(oDis);
                CargarDisciplina();
            }
        }

        





    }
}
