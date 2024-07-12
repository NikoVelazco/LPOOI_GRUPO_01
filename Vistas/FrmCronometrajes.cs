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
            pnlRegistroCronometrajeHoraFechaFin.Visible = true;
            initializeHoraFechaInicioEvento = DateTime.Now;
            lblValorHoraInicioEvento.Text = initializeHoraFechaInicioEvento.ToString("h:mm:ss tt");
            lblValorFechaInicioEvento.Text = initializeHoraFechaInicioEvento.ToString("dd MMMM yyyy");
            btnIniciarEvento.Enabled = false;
            btnAsignarFechaHoraInicio.Enabled = true;
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            int atletaId = (int)cmbListaAtletas.SelectedValue;
            int competenciaId = (int)cmbListaCompetencias.SelectedValue;
            
            dgvEventoSegunAtletaCompetencia.DataSource = TrabajarEvento.SearchEventoByAtletaAndCompetencia(atletaId, competenciaId);

            dgvEventoSegunAtletaCompetencia.Columns[0].Visible = false;
        }

        private void btnFinalizarEvento_Click(object sender, EventArgs e)
        {
            if (dgvEventoSegunAtletaCompetencia.RowCount > 0 && !dgvEventoSegunAtletaCompetencia.CurrentRow.IsNewRow)
            {
                initializeHoraFechaFinEvento = DateTime.Now;

                DialogResult confirmationMessage = MessageBox.Show(
                    "Desea asignar fecha-hora del fin del evento",
                    "Fin Evento",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmationMessage == DialogResult.Yes)
                {
                    int eventoId = (int)dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value;

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
                    MessageBox.Show(
                        "El Atleta ha finalizado el evento",
                        "Fin del evento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                    );

                    lblValorHoraFinEvento.Text = initializeHoraFechaFinEvento.ToString("h:mm:ss tt");
                    lblValorFechaFinEvento.Text = initializeHoraFechaFinEvento.ToString("dd MMMM yyyy");
                    loadEventoSegunAtletaCompetencia();
                }
            }
            else
            {
                MessageBox.Show(
                    "No es posible realizar esta operacíon, antes debe buscar un evento y seleccionarlo",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
                DialogResult confirmationMessage = MessageBox.Show(
                    "Desea asignar abandono al Atleta",
                    "Abandono",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmationMessage == DialogResult.Yes)
                {
                    TrabajarEvento.UpdateEventoEstado(int.Parse(dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value.ToString()), EventoEstado.ABANDONO);
                    MessageBox.Show(
                        "El Atleta ha abandonado el evento",
                        "Abandono",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                    );
                    loadEventoSegunAtletaCompetencia();
                }
            }
            else
            {
                MessageBox.Show(
                    "No es posible realizar esta operacíon, antes debe buscar un evento y seleccionarlo",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnActualizarEventoDescalificado_Click(object sender, EventArgs e)
        {
            if (dgvEventoSegunAtletaCompetencia.RowCount > 0 && !dgvEventoSegunAtletaCompetencia.CurrentRow.IsNewRow)
            {
                DialogResult confirmationMessage = MessageBox.Show(
                    "Desea descalificar al Atleta",
                    "Descalificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmationMessage == DialogResult.Yes)
                {
                    TrabajarEvento.UpdateEventoEstado(int.Parse(dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value.ToString()), EventoEstado.DESCALIFICADO);
                    MessageBox.Show(
                        "Atleta ha sido descalificado del evento",
                        "Descalificación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                    );

                    loadEventoSegunAtletaCompetencia();
                }
            }
            else
            {
                MessageBox.Show(
                    "No es posible realizar esta operacíon, antes debe buscar un evento y seleccionarlo",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnActualizarFechaInicio_Click(object sender, EventArgs e)
        {
            if (dgvEventoSegunAtletaCompetencia.RowCount > 0 && !dgvEventoSegunAtletaCompetencia.CurrentRow.IsNewRow)
            {
                dgvEventoSegunAtletaCompetencia.CurrentRow.Selected = true;

                if (string.IsNullOrWhiteSpace(Convert.ToString(dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Hora Fin"].Value)))
                {
                    DialogResult confirmationMessage = MessageBox.Show(
                        "Desea actualizar la fecha de inicio del evento",
                        "Actualizar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmationMessage == DialogResult.Yes)
                    {
                        int eventoId = (int)dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value;

                        initializeHoraFechaInicioEvento = Convert.ToDateTime(
                            dtpActualizarHoraInicio.Value.ToString("h:mm:ss tt") +
                            " " +
                            dtpActualizarFechaInicio.Value.ToString("MM/dd/yyyy")
                        );

                        TrabajarCronometraje.UpdateHoraInicioEvento(
                            eventoId,
                            initializeHoraFechaInicioEvento
                        );

                        MessageBox.Show(
                            "La hora del inicio del evento ha sido actualizada",
                            "Actualización",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None
                        );
                    }
                }
                else
                {
                    if (initializeHoraFechaInicioEvento <= Convert.ToDateTime(dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Hora Fin"].Value))
                    {
                        DialogResult confirmationMessage = MessageBox.Show(
                            "Desea actualizar la fecha de inicio del evento",
                            "Actualizar",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                         );

                        if (confirmationMessage == DialogResult.Yes)
                        {
                            int eventoId = (int)dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value;

                            initializeHoraFechaInicioEvento = Convert.ToDateTime(
                                dtpActualizarHoraInicio.Value.ToString("h:mm:ss tt") +
                                " " +
                                dtpActualizarFechaInicio.Value.ToString("MM/dd/yyyy")
                            );

                            TrabajarCronometraje.UpdateHoraInicioEvento(
                                eventoId,
                                initializeHoraFechaInicioEvento
                            );

                            MessageBox.Show(
                                "La hora del inicio del evento ha sido actualizada",
                                "Actualización",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.None
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "No es posible realizar esta operacíon, antes debe buscar un evento y seleccionarlo",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                loadEventoSegunAtletaCompetencia();
            }
            else
            {
                MessageBox.Show(
                    "No es posible realizar esta operacíon, antes debe buscar un evento y seleccionarlo",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnAsignarFechaHoraInicio_Click(object sender, EventArgs e)
        {
            if (dgvEventoSegunAtletaCompetencia.RowCount > 0 && !dgvEventoSegunAtletaCompetencia.CurrentRow.IsNewRow)
            {
                int eventoId = (int)dgvEventoSegunAtletaCompetencia.CurrentRow.Cells["Id"].Value;

                TrabajarCronometraje.UpdateHoraInicioEvento(
                        eventoId,
                        initializeHoraFechaInicioEvento
                );

                MessageBox.Show(
                    "La hora del inicio del evento ha sido asignada",
                    "Asigncación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                );

                loadEventoSegunAtletaCompetencia();
            }
            else
            {
                MessageBox.Show(
                    "No es posible realizar esta operacíon, antes debe buscar un evento y seleccionarlo",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
