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
    public partial class FrmGestionCompetencia : Form
    {
        private int idSeleccionado = 0;

        public FrmGestionCompetencia()
        {
            InitializeComponent();
        }

        private void FrmGestionCompetencia_Load(object sender, EventArgs e)
        {
            loadCompetencias();
            loadCategorias();
            loadDisciplinas();
            cmbEstado.SelectedIndex = 0;
            btnEditCompetencia.Enabled = false;
            Util.responsiveForm(panelGestorCompetencia);
        }

        private Competencia createCompetencia()
        {
            Competencia comp = new Competencia();

            comp.Com_Nombre = txtNombre.Text;
            comp.Com_Descripcion = txtDescripcion.Text;
            comp.Com_Organizador = txtOrganizador.Text;
            comp.Com_Ubicacion = txtUbicacion.Text;
            comp.Com_FechaInicio = dtpFechaInicio.Value;
            comp.Com_FechaFin = dtpFechaFin.Value;
            comp.Com_Sponsors = txtSponsors.Text;
            comp.Com_Estado = cmbEstado.SelectedItem.ToString();
            comp.Cat_ID = (int)cmbCategoria.SelectedValue;
            comp.Dis_ID = (int)cmbDisciplina.SelectedValue;

            return comp;
        }

        private void loadCategorias()
        {
            cmbCategoria.DataSource = TrabajarCategoria.GetAllCategorias();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = 0;
        }

        private void loadDisciplinas()
        {
            cmbDisciplina.DisplayMember = "Nombre";
            cmbDisciplina.ValueMember = "ID";
            cmbDisciplina.DataSource = TrabajarDisciplina.listarDisciplinas();
            cmbDisciplina.SelectedIndex = 0;
        }

        private void loadCompetencias()
        {
            dataGridCompetencia.DataSource = TrabajarCompetencia.getCompetencias();
            dataGridCompetencia.Columns["id"].Visible = false;
            dataGridCompetencia.Columns["Cat_ID"].Visible = false;
            dataGridCompetencia.Columns["Dis_ID"].Visible = false;
        }

        private void dataGridCompetencia_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCompetencia.SelectedRows.Count > 0 && !dataGridCompetencia.CurrentRow.IsNewRow)
            {
                txtNombre.Text = dataGridCompetencia.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridCompetencia.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtOrganizador.Text = dataGridCompetencia.CurrentRow.Cells["Organizador"].Value.ToString();
                txtUbicacion.Text = dataGridCompetencia.CurrentRow.Cells["Ubicacion"].Value.ToString();
                dtpFechaInicio.Value = (DateTime)dataGridCompetencia.CurrentRow.Cells["Fecha de Inicio"].Value;
                dtpFechaFin.Value = (DateTime)dataGridCompetencia.CurrentRow.Cells["Fecha de Finalizacion"].Value;
                txtSponsors.Text = dataGridCompetencia.CurrentRow.Cells["Sponsors"].Value.ToString();
                cmbCategoria.SelectedValue = dataGridCompetencia.CurrentRow.Cells["Cat_ID"].Value.ToString();
                cmbDisciplina.SelectedValue = dataGridCompetencia.CurrentRow.Cells["Dis_ID"].Value.ToString();
                cmbEstado.SelectedValue = dataGridCompetencia.CurrentRow.Cells["Estado"].Value.ToString();
                idSeleccionado = (int)dataGridCompetencia.CurrentRow.Cells["id"].Value;
                btnEditCompetencia.Enabled = true;
                btnGuardarCompetencia.Enabled = false;
            }
        }

        private void btnGuardarCompetencia_Click(object sender, EventArgs e)
        {
            if (Util.textBoxEmpty(panelGestorCompetencia))
            {
                MessageBox.Show("No se permite campos en blanco");
            }
            else
            {
                Util.startSound("alerta.mp3");
                if (Util.messageYesNo("¿Estás Seguro que quieres guardar los datos?", "Alta de Competencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Competencia nuevaCompetencia = createCompetencia();
                    TrabajarCompetencia.saveCompetencia(nuevaCompetencia);
                    loadCompetencias();
                    Util.clearTextBox(panelGestorCompetencia);
                }
            }
        }

        private void btnEditCompetencia_Click(object sender, EventArgs e)
        {
            if (Util.textBoxEmpty(panelGestorCompetencia))
            {
                MessageBox.Show("No se permite campos en blanco");
            }
            else
            {
                Util.startSound("alerta.mp3");
                if (Util.messageYesNo("¿Estás Seguro que quieres editar los datos?", "Editar Competencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Competencia nuevaCompetencia = createCompetencia();
                    nuevaCompetencia.Com_ID = idSeleccionado;
                    TrabajarCompetencia.editCompetencia(nuevaCompetencia);
                    loadCompetencias();
                    idSeleccionado = 0;
                    Util.clearTextBox(panelGestorCompetencia);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnDeleteCompetencia_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
                MessageBox.Show("Debe seleccionar una Competencia", "Advertencia");
            else
            {
                Util.startSound("alerta.mp3");
                if (Util.messageYesNo("¿Estás Seguro que quieres eliminar la competencia?", "Eliminar Competencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TrabajarCompetencia.deleteCompetencia(idSeleccionado);
                    loadCompetencias();
                    reset();
                }
            }
        }

        private void reset()
        {
            btnEditCompetencia.Enabled = false;
            btnGuardarCompetencia.Enabled = true;
            Util.clearTextBox(panelGestorCompetencia);
        }
    }
}
