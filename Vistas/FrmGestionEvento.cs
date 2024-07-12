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
    public partial class FrmGestionEvento : Form
    {
        public FrmGestionEvento()
        {
            InitializeComponent();
        }

        private void FrmInscripcionEvento_Load(object sender, EventArgs e)
        {
            loadComboBoxWithAtletas();
            loadComboBoxWithCompetencias();
            loadListOfEventos();
        }

        private void loadListOfEventos()
        {
            dgvEvento.DataSource = TrabajarEvento.GetAllEventos();
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
            Boolean dateIsAllowed = isEventoDateTimeBeforeOrEqualToCompetenciaDateTime();

            if (athleteWasFound)
            {
                MessageBox.Show("El Atleta ya se encuentra inscripto a un evento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (dateIsAllowed)
            {
                MessageBox.Show("La fecha de la Competencia es incorrecta, debe ser anterior al día de hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!athleteWasFound && !dateIsAllowed)
            {
                DialogResult confirmationMessage = MessageBox.Show("Desea registrar inscripción del Atleta", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationMessage == DialogResult.Yes)
                {
                    TrabajarEvento.InsertEvento(
                        Int32.Parse(cmbListaCompetencias.SelectedValue.ToString()),
                        Int32.Parse(cmbListaAtletas.SelectedValue.ToString())
                    );
                    
                    MessageBox.Show("Atleta registrado correctamente", "Registro inscripción", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                    loadListOfEventos();    
                }
            }
        }

        private void btnAnularInscripcionEvento_Click(object sender, EventArgs e)
        {
            DialogResult confirmationMessage = MessageBox.Show("Desea anular inscripción del Atleta", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationMessage == DialogResult.Yes)
            {
                TrabajarEvento.UpdateEventoEstado(int.Parse(dgvAnularInscripcion.CurrentRow.Cells["Id"].Value.ToString()), EventoEstado.ANULADO);
                
                MessageBox.Show("Inscripción a evento anulada", "Anulación inscripción", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                loadListOfEventos();    
            }
        }

        private void btnRegistrarAcreditacionEvento_Click(object sender, EventArgs e)
        {
            DialogResult confirmationMessage = MessageBox.Show("Desea acreditar inscripción del Atleta", "Acreditar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationMessage == DialogResult.Yes)
            {
                TrabajarEvento.RegisterEvento(int.Parse(dgvRegistrarAcreditacion.CurrentRow.Cells["Id"].Value.ToString()));

                MessageBox.Show("Adreditación a evento confirmada", "Acreditar inscripción", MessageBoxButtons.OK, MessageBoxIcon.None);

                loadListOfEventos();    
            }
        }

        private Boolean isEventoDateTimeBeforeOrEqualToCompetenciaDateTime()
        {
            DateTime dateTime = Convert.ToDateTime(txtFechaInicioCompetencia.Text);
            return (DateTime.Today <= dateTime);
        }

        private void txtBuscarAtleta_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = TrabajarEvento.searchAtletaByDNI(txtBuscarAtleta.Text);
            dgvAnularInscripcion.DataSource = dataTable;
            dgvAnularInscripcion.Columns["Id"].Visible = false;
            getInformacionAtleta(dataTable, lblInformacionAtletaAnularInscripcion);
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
            getInformacionAtleta(dataTable, lblInformacionAtletaRegistrarAcreditacion);
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

        private void getInformacionAtleta(DataTable dataTable, Label label)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                label.Text = row["Atleta"].ToString();
            }
        }
    }
}
