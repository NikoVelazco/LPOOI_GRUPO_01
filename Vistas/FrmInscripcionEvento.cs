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

        /* # ==========================================================================
           # = Load Eventos (DataTable), Atletas (ComboBox) y Competencias (ComboBox) =
           # ========================================================================== */
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

        /* # =========================================
           # = Registrar, Anular y Acreditar Eventos =
           # ========================================= */
        private void btnRegistrarEvento_Click(object sender, EventArgs e)
        {
            Boolean athleteWasFound = TrabajarAtleta.atletaIsFound(Int32.Parse(cmbListaAtletas.SelectedValue.ToString()));

            if (athleteWasFound)
            {
                lblAtletaRegistrado.Visible = true;
                lblAtletaRegistrado.Text = "El atleta se encuentra inscripto a una competencia";
            }
            else
            {
                if (isEventoDateTimeBeforeCompetenciaDateTime())
                {
                    lblFechaCompetenciaIncorrecta.Visible = true;
                    lblFechaCompetenciaIncorrecta.Text = "Fecha incompatible con el evento";
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
        }

        private void btnAnularInscripcionEvento_Click(object sender, EventArgs e)
        {
            TrabajarEvento.cancelEvento(int.Parse(dgvAnularInscripcion.CurrentRow.Cells["Id"].Value.ToString()));
            loadListOfEventos();
        }

        private void btnRegistrarAcreditacionEvento_Click(object sender, EventArgs e)
        {
            TrabajarEvento.registerEvento(int.Parse(dgvRegistrarAcreditacion.CurrentRow.Cells["Id"].Value.ToString()));
            loadListOfEventos();
        }

        /* # ==========================================================================
           # = Load Eventos (DataTable), Atletas (ComboBox) y Competencias (ComboBox) =
           # ========================================================================== */
        private Boolean isEventoDateTimeBeforeCompetenciaDateTime()
        {
            DateTime dateTime = Convert.ToDateTime(txtFechaInicioCompetencia.Text);
            return (DateTime.Today <= dateTime);
        }

        private void txtBuscarAtleta_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = TrabajarEvento.searchAtletaByDNI(txtBuscarAtleta.Text);
            dgvAnularInscripcion.DataSource = dataTable;
            dgvAnularInscripcion.Columns["Id"].Visible = false;
            getInformacionAtleta(dataTable, txtInformacionAtletaAnularInscripcion);
        }

        private void txtBuscarAtleta_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.ForeColor = SystemColors.WindowText;
        }

        private void txtBuscarAtleta_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "DNI";
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        // For testing
        private void cmbListaCompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = TrabajarCompetencia.getAllowedCompetencias();

            DateTime dateTimeInicioCompetencia = Convert.ToDateTime(dataTable.Rows[cmbListaCompetencias.SelectedIndex]["Fecha_Inicio"]);
            DateTime dateTimeFinCompetencia = Convert.ToDateTime(dataTable.Rows[cmbListaCompetencias.SelectedIndex]["Fecha_Fin"]);
            
            txtFechaInicioCompetencia.Text = string.Format(dateTimeInicioCompetencia.ToString("dd - MMMM - yyyy"));
            txtHoraInicioCompetencia.Text = string.Format(dateTimeInicioCompetencia.ToString("hh:mm:ss tt"));

            txtFechaFinCompetencia.Text = string.Format(dateTimeInicioCompetencia.ToString("dd - MMMM - yyyy"));
            txtHoraFinCompetencia.Text = string.Format(dateTimeInicioCompetencia.ToString("hh:mm:ss tt"));
        }

        private void txtBuscarAtletaAcredicacion_TextChanged(object sender, EventArgs e)
        {   
            DataTable dataTable = TrabajarEvento.searchAtletaByDNI(txtBuscarAtletaAcredicacion.Text);
            dgvRegistrarAcreditacion.DataSource = dataTable;
            dgvRegistrarAcreditacion.Columns["Id"].Visible = false;
            dgvRegistrarAcreditacion.Columns["Atleta"].Visible = false;
            getInformacionAtleta(dataTable, txtInformacionAtletaAcreditarInscripcion);
            
        }

        private void txtBuscarAtletaAcredicacion_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.ForeColor = SystemColors.WindowText;
        }

        private void txtBuscarAtletaAcredicacion_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "DNI";
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void getInformacionAtleta(DataTable dataTable, TextBox textBox)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                textBox.Text = row["Atleta"].ToString();
            }
        }
    }
}
