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
    public partial class FrmInscripcionEvento : Form
    {
        public FrmInscripcionEvento()
        {
            InitializeComponent();
        }

        private void FrmInscripcionEvento_Load(object sender, EventArgs e)
        {
            loadComboBoxWithAtletas();
            loadComboBoxWithCompetencias();
            loadListOfEventos();
        }

        /*---------*
         | Helpers |
         *---------*/

        private void loadListOfEventos()
        {
            dgvEvento.DataSource = TrabajarEvento.getAllEventos();
            dgvEvento.Columns["Id"].Visible = false;
        }

        private void loadComboBoxWithAtletas()
        {
            DataTable dataTable = TrabajarAtleta.getAllAtletas();
            dataTable.Columns.Add("Nombre_Completo", typeof(string), "Nombre + ' ' + Apellido");
            cmbListaAtletas.DataSource = dataTable;
            cmbListaAtletas.DisplayMember = "Nombre_Completo";
            cmbListaAtletas.ValueMember = "Id";
        }

        private void loadComboBoxWithCompetencias()
        {
            DataTable dataTable = TrabajarCompetencia.getAllowedCompetencias();
            cmbListaCompetencias.DataSource = dataTable;
            cmbListaCompetencias.DisplayMember = "Nombre";
            cmbListaCompetencias.ValueMember = "Id";
        }

        private void btnRegistrarEvento_Click(object sender, EventArgs e)
        {
            Boolean athleteWasFound = TrabajarAtleta.atletaIsFound(Int32.Parse(cmbListaAtletas.SelectedValue.ToString()));

            if (isEventoDateTimeBeforeCompetenciaDateTime())
            {
                //MessageBox.Show("Atleta encontrado :(");
                MessageBox.Show("No es posible agregar el evento");
            }
            else
            {
                TrabajarEvento.insertEvento(
                    Int32.Parse(cmbListaCompetencias.SelectedValue.ToString()),
                    Int32.Parse(cmbListaAtletas.SelectedValue.ToString())
                );
                loadListOfEventos();
            }
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {

        }

        private void cmbListaCompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // For testing
            DataTable dataTable = TrabajarCompetencia.getAllowedCompetencias();
            dtpHoraInicioCompetencia.Format = DateTimePickerFormat.Short;
            dtpHoraFinCompetencia.Format = DateTimePickerFormat.Short;
            dtpHoraInicioCompetencia.Value = Convert.ToDateTime(dataTable.Rows[cmbListaCompetencias.SelectedIndex]["Fecha_Inicio"]);
            dtpHoraFinCompetencia.Value = Convert.ToDateTime(dataTable.Rows[cmbListaCompetencias.SelectedIndex]["Fecha_Fin"]);
        }

        private Boolean isEventoDateTimeBeforeCompetenciaDateTime()
        {
            return (DateTime.Today <= dtpHoraInicioCompetencia.Value);
        }
    }
}
