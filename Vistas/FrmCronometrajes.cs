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
    public partial class FrmCronometrajes : Form
    {
        private static DateTime initializeHoraInicioEvento;

        public FrmCronometrajes()
        {
            InitializeComponent();
        }


        private void FrmCronometrajes_Load(object sender, EventArgs e)
        {
            loadListOfCompetencias();
            loadListOfAtletas();
        }

        private void loadListOfAtletas()
        {
            DataTable dataTable = TrabajarAtleta.getAllAtletas();
            dataTable.Columns.Add("Atleta", typeof(string), "Nombre + ' ' + Apellido");
            cmbListaAtletas.DataSource = dataTable;
            cmbListaAtletas.DisplayMember = "Atleta";
            cmbListaAtletas.ValueMember = "Id";
        }

        private void loadListOfCompetencias()
        {
            DataTable dataTable = TrabajarCompetencia.getAllowedCompetencias();
            cmbListaCompetencias.DataSource = dataTable;
            cmbListaCompetencias.DisplayMember = "Nombre";
            cmbListaCompetencias.ValueMember = "Id";
        }

        private void loadEventoSegunAtletaCompetencia()
        {
            int atl_Id = Utilidades.ParseStringToInt(cmbListaAtletas.SelectedValue.ToString());
            int com_Id = Utilidades.ParseStringToInt(cmbListaCompetencias.SelectedValue.ToString());
            dgvEventoSegunAtletaCompetencia.DataSource = TrabajarCronometraje.SearchEventoByAtletaAndCompetencia(atl_Id, com_Id);
        }

        private void btnIniciarEvento_Click(object sender, EventArgs e)
        {
            pnlRegistroCronometrajeHoraInicio.Visible = true;
            pnlRegistroCronometrajeHoraFin.Visible = true;
            initializeHoraInicioEvento = DateTime.Now;
            lblValorHoraInicioEvento.Text = initializeHoraInicioEvento.ToString("hh:mm:ss");
            lblValorFechaInicioEvento.Text = initializeHoraInicioEvento.ToString("dd MMMM yyyy");
            btnIniciarEvento.Enabled = false;
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            int atl_Id = (int)cmbListaAtletas.SelectedValue;
            int com_Id = (int)cmbListaCompetencias.SelectedValue;
            
            dgvEventoSegunAtletaCompetencia.DataSource = TrabajarCronometraje.SearchEventoByAtletaAndCompetencia(atl_Id, com_Id);
            dgvEventoSegunAtletaCompetencia.Columns["Id"].Visible = false;
        }

        private void lblFinalizarEvento_Click(object sender, EventArgs e)
        {
            // Buscar evento y mostrarlo cuando se haga click
            int eve_Id = (int)dgvEventoSegunAtletaCompetencia.CurrentRow.Cells[0].Value;

            if (eve_Id > 0)
            {
                DateTime initializeHoraFinEvento = DateTime.Now;
                
                TrabajarCronometraje.UpdateHoraFinEvent(
                    eve_Id,
                    initializeHoraInicioEvento,
                    initializeHoraFinEvento
                );
                
                lblValorHoraFinEvento.Text = initializeHoraFinEvento.ToString("hh:mm:ss");
                lblValorFechaFinEvento.Text = initializeHoraFinEvento.ToString("dd MMMM yyyy");
                loadEventoSegunAtletaCompetencia();
            }

            lblUltimoParticipante.Text = "Último participante";
            lblUltimoParticipante.ForeColor = Color.Red;
        }

        private void dgvEventoSegunAtletaCompetencia_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            btnFinalizarEvento.Enabled = !btnFinalizarEvento.Enabled;
        }
    }
}
