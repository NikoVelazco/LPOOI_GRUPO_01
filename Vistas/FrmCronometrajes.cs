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
    /* #== Cronometrajes =================================================== */
    public partial class FrmCronometrajes : Form
    {
        private static DateTime initializeHoraFechaInicioEvento;
        private static DateTime initializeHoraFechaFinEvento;

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
            DataTable dataTable = TrabajarAtleta.getAtletasAcreditados(EventoEstado.ACREDITADO);
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
            int atletaId = Utilidades.ParseStringToInt(cmbListaAtletas.SelectedValue.ToString());
            int competenciaId = Utilidades.ParseStringToInt(cmbListaCompetencias.SelectedValue.ToString());
            dgvEventoSegunAtletaCompetencia.DataSource = TrabajarEvento.SearchEventoByAtletaAndCompetencia(atletaId, competenciaId);
        }

        private void btnIniciarEvento_Click(object sender, EventArgs e)
        {
            pnlRegistroCronometrajeHoraInicio.Visible = true;
            pnlRegistroCronometrajeHoraFin.Visible = true;
            initializeHoraFechaInicioEvento = DateTime.Now;
            lblValorHoraInicioEvento.Text = initializeHoraFechaInicioEvento.ToString("h:mm:ss tt");
            lblValorFechaInicioEvento.Text = initializeHoraFechaInicioEvento.ToString("dd MMMM yyyy");
            btnIniciarEvento.Enabled = false;
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            int atletaId = (int)cmbListaAtletas.SelectedValue;
            int competenciaId = (int)cmbListaCompetencias.SelectedValue;
            
            dgvEventoSegunAtletaCompetencia.DataSource = TrabajarEvento.SearchEventoByAtletaAndCompetencia(atletaId, competenciaId);

            dgvEventoSegunAtletaCompetencia.Columns[0].Visible = false;

            if (dgvEventoSegunAtletaCompetencia.RowCount > 0 && !dgvEventoSegunAtletaCompetencia.CurrentRow.IsNewRow)
            {
                btnFinalizarEvento.Enabled = !btnFinalizarEvento.Enabled;
                lblValorHoraFinEvento.Enabled = !lblValorHoraFinEvento.Enabled;
                lblValorFechaFinEvento.Enabled = !lblValorFechaFinEvento.Enabled;
            }
            else
            {
                btnFinalizarEvento.Enabled = false;
            }
        }

        private void btnFinalizarEvento_Click(object sender, EventArgs e)
        {
            initializeHoraFechaFinEvento = DateTime.Now;

            if (dgvEventoSegunAtletaCompetencia.RowCount > 0 && !dgvEventoSegunAtletaCompetencia.CurrentRow.IsNewRow)
            {
                int eventoId = (int)dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value;
                
                if (eventoId > 0)
                {
                    if (rdoIngresoManual.Checked)
                    {
                        initializeHoraFechaFinEvento = Convert.ToDateTime(
                            dtpIngresoHoraFinEvento.Value.ToString("h:mm:ss tt") +
                            " " +
                            dtpIngresoFechaFinEvento.Value.ToString("MM/dd/yyyy")
                        );

                        TrabajarCronometraje.UpdateHoraInicioFinEvento(
                            eventoId,
                            initializeHoraFechaInicioEvento,
                            initializeHoraFechaFinEvento
                        );
                    }
                    else
                    {
                        TrabajarCronometraje.UpdateHoraInicioFinEvento(
                            eventoId,
                            initializeHoraFechaInicioEvento,
                            initializeHoraFechaFinEvento
                        );
                    }

                    lblValorHoraFinEvento.Text = initializeHoraFechaFinEvento.ToString("h:mm:ss tt");
                    lblValorFechaFinEvento.Text = initializeHoraFechaFinEvento.ToString("dd MMMM yyyy");
                    loadEventoSegunAtletaCompetencia();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una competencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdoIngresoAutogenerado_CheckedChanged(object sender, EventArgs e)
        {
            pnlIngresarHoraFinEvento.Enabled = false;
            pnlIngresarFechaFinEvento.Enabled = false;
        }

        private void rdoIngresoManual_CheckedChanged(object sender, EventArgs e)
        {
            pnlIngresarHoraFinEvento.Enabled = !pnlIngresarHoraFinEvento.Enabled;
            pnlIngresarFechaFinEvento.Enabled = !pnlIngresarFechaFinEvento.Enabled;
        }

        private void ActualizarEventoAbandono_Click(object sender, EventArgs e)
        {
            if (dgvEventoSegunAtletaCompetencia.RowCount > 0 && !dgvEventoSegunAtletaCompetencia.CurrentRow.IsNewRow)
            {
                TrabajarEvento.UpdateEventoEstado(int.Parse(dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value.ToString()), EventoEstado.ABANDONO);
            }
            loadEventoSegunAtletaCompetencia();
        }

        private void btnActualizarEventoDescalificado_Click(object sender, EventArgs e)
        {
            if (dgvEventoSegunAtletaCompetencia.RowCount > 0 && !dgvEventoSegunAtletaCompetencia.CurrentRow.IsNewRow)
            {
                TrabajarEvento.UpdateEventoEstado(int.Parse(dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value.ToString()), EventoEstado.DESCALIFICADO);
            }
            loadEventoSegunAtletaCompetencia();
        }

        private void btnActualizarFechaInicio_Click(object sender, EventArgs e)
        {
            int eventoId = (int)dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value;

            initializeHoraFechaInicioEvento = Convert.ToDateTime(
                dtpActualizarHoraInicio.Value.ToString("h:mm:ss tt") +
                " " +
                dtpActualizarFechaInicio.Value.ToString("MM/dd/yyyy")
            );

            if (initializeHoraFechaInicioEvento <= Convert.ToDateTime(dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Hora Fin"].Value))
            {
                TrabajarCronometraje.UpdateHoraInicioEvento(
                    eventoId,
                    initializeHoraFechaInicioEvento
                );
            }
            else
            {
                MessageBox.Show("La fecha debe ser anterior a la fecha de fin del evento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadEventoSegunAtletaCompetencia();            
        }
    }
}
