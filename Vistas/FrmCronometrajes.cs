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
        private string currentPattern = "";
        private string currentOrder = "Apellido";
        private int idSeleccionado = 0;

        public FrmCronometrajes()
        {
            
            InitializeComponent();
            getAllAthletes();
            getAllCompetitions();
            cargaInicialEvento();
        }
    
    
        public void getAllAthletes(){
            DataTable dataTableAthletes = TrabajarAtleta.getAtletasAcreditados("Acreditado");
            cmbAtletas.DisplayMember = "Atleta";
            cmbAtletas.ValueMember = "Id";
            cmbAtletas.DataSource = dataTableAthletes;
           
        }
        
        public void getAllCompetitions(){

            DataTable dataTableCompetition = TrabajarCompetencia.getCompetencias();
            cmbCompetencias.DisplayMember = "Nombre";
            cmbCompetencias.ValueMember = "Id";
            cmbCompetencias.DataSource = dataTableCompetition;
           
        }

        private void dataGridAtletas_SelectionChanged(object sender, EventArgs e)
        {
            //cmbAtletas.Text = dataGridAtletas.CurrentRow.Cells["Apellido"].Value.ToString();
        }

        private void dataGridCompetencia_SelectionChanged(object sender, EventArgs e)
        {
            //cmbCompetencias.Text = dataGridCompetencia.CurrentRow.Cells["Nombre"].Value.ToString();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if(existeElEventoParaElAtletaConDichaCompetencia()){
                
                     if(numericValidation()){

                                if (datesValidation(getInitialDateTime(), getFinalDateTime()))
                                {

                                            DialogResult mensaje = MessageBox.Show("¿Estás seguro que quieres guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (mensaje == DialogResult.Yes)
                                            {
                                                
                                                TrabajarEvento.UpdateEventoEstado(idSeleccionado, cmbEstados.Text);
                                                TrabajarCronometraje.UpdateHoraInicioFinEvento(idSeleccionado, getInitialDateTime(), getFinalDateTime());
                                                

                                                MessageBox.Show("Cronometraje Guardado Con Exito...");

                                                cargaInicialEvento();
                                            }
                                            else
                                            {
                                                Util.clearTextBox(panelCronometraje);
                                            }

                                }
                                else {

                                    MessageBox.Show("La fecha inicial nunca debe ser superior a la final");
                
                                }
        
                   }else{
           
                        MessageBox.Show("Debe ingresar valores numericos validos");
                   }



            }else{
                MessageBox.Show("No existe Evento para dicho Atleta en dicha Competencia");
                
            }


        }

        public Evento createNewEvent()
        {
            Evento nuevoEvento = new Evento();
            nuevoEvento.Eve_ID = idSeleccionado;
            nuevoEvento.Atl_ID = Convert.ToInt32(cmbAtletas.SelectedValue);
            nuevoEvento.Com_ID = Convert.ToInt32(cmbCompetencias.SelectedValue);
            nuevoEvento.Eve_HoraInicio = getInitialDateTime();
            nuevoEvento.Eve_HoraFin = getFinalDateTime();
            nuevoEvento.Eve_Estado = cmbEstados.Text;
            return nuevoEvento;
            
        }

        /* CREACION DE DATETIMES PARA LAS FECHAS FINALES E INICIALES */

        public DateTime getFinalDateTime() {
            DateTime calendarDateTime = calendarFinal.Value;

            DateTime finalDateTime = new DateTime(
                    calendarDateTime.Year,
                    calendarDateTime.Month,
                    calendarDateTime.Day,
                    int.Parse(txtHoraFinal.Text),
                    int.Parse(txtMinutoFinal.Text),
                    int.Parse(txtSegundoFinal.Text)
                );

            return finalDateTime;
        }
                
        public DateTime getInitialDateTime() {
            DateTime calendarDateTime = calendarInicial.Value;

            DateTime initialDateTime = new DateTime(
                    calendarDateTime.Year,
                    calendarDateTime.Month,
                    calendarDateTime.Day,
                    int.Parse(txtHoraInicial.Text),
                    int.Parse(txtMinutoInicial.Text),
                    int.Parse(txtSegundoInicial.Text)
                );
            return initialDateTime;
        }

        /* VALIDACIONES */

        public bool numericValidation() {
            int hora, segundos, minutos;
            if (!(int.TryParse(txtHoraFinal.Text, out hora) && int.TryParse(txtMinutoFinal.Text, out minutos) && int.TryParse(txtSegundoFinal.Text, out segundos))) {
                return false;
            }
            if(!(int.TryParse(txtHoraInicial.Text, out hora) && int.TryParse(txtMinutoInicial.Text, out minutos) && int.TryParse(txtSegundoInicial.Text, out segundos))) {
                return false;
            }

            return true;
        }

        public bool datesValidation(DateTime dateInitial, DateTime dateFinal) {
            return dateFinal >= dateInitial;
        }

        public bool existeElEventoParaElAtletaConDichaCompetencia() { 
            if(dgvEventoSegunAtletaCompetencia.Rows.Count == 0){
                return false;
            }
            return true;
        }

        /* BOTONES */

        private void btnAutoCompletarInicio_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            calendarInicial.Value = now;
            txtHoraInicial.Text = now.Hour.ToString();
            txtMinutoInicial.Text = now.Minute.ToString();
            txtSegundoInicial.Text = now.Second.ToString();
        }

        private void btnAutoCompletarFinal_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            calendarFinal.Value = now;
            txtHoraFinal.Text = now.Hour.ToString();
            txtMinutoFinal.Text = now.Minute.ToString();
            txtSegundoFinal.Text = now.Second.ToString();
        }

        private void cmbAtletas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = TrabajarEvento.SearchEventoByAtletaAndCompetencia(Convert.ToInt32(cmbAtletas.SelectedValue), Convert.ToInt32(cmbCompetencias.SelectedValue));
            dgvEventoSegunAtletaCompetencia.DataSource = dataTable;
            cargarDatos(dataTable);
        }

        private void cmbCompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = TrabajarEvento.SearchEventoByAtletaAndCompetencia(Convert.ToInt32(cmbAtletas.SelectedValue), Convert.ToInt32(cmbCompetencias.SelectedValue));
            dgvEventoSegunAtletaCompetencia.DataSource = dataTable;
            cargarDatos(dataTable);
        }


        private void rdoIngresoManual_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            calendarFinal.Value = now;
            txtHoraFinal.Text = "";
            txtMinutoFinal.Text = "";
            txtSegundoFinal.Text = "";
        }

        private void ingesoManualInicial_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            calendarInicial.Value = now;
            txtHoraInicial.Text = "";
            txtMinutoInicial.Text = "";
            txtSegundoInicial.Text = "";
        }

        /*CARGA DE DATOS DEL DATAGRIDVIEW*/

        private void cargaInicialEvento()
        {
            DataTable dataTable = TrabajarEvento.SearchEventoByAtletaAndCompetencia(Convert.ToInt32(cmbAtletas.SelectedValue), Convert.ToInt32(cmbCompetencias.SelectedValue));
            dgvEventoSegunAtletaCompetencia.DataSource = dataTable;
            cargarDatos(dataTable);
        }

        public void cargarDatos(DataTable dataTable) { 
            if(existeElEventoParaElAtletaConDichaCompetencia()){
                
                dgvEventoSegunAtletaCompetencia.Columns["Id"].Visible = false;
                dgvEventoSegunAtletaCompetencia.Columns["Hora Inicio"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                dgvEventoSegunAtletaCompetencia.Columns["Hora Fin"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

                DataRow dataRow = dataTable.Rows[0];
                
                DateTime fechaInicial = (DateTime)dataRow["Hora Inicio"];
                cargarFechaInicial(fechaInicial);

                DateTime fechaFinal = (DateTime)dataRow["Hora Fin"];
                cargarFechaFinal(fechaFinal);

                cmbEstados.Text = dataRow["Estado"].ToString();

                idSeleccionado = Convert.ToInt32(dataRow["Id"]);
            }
        
        }

        public void cargarFechaInicial(DateTime dateTime) {
            txtHoraInicial.Text = dateTime.Hour.ToString();
            txtMinutoInicial.Text = dateTime.Minute.ToString();
            txtSegundoInicial.Text = dateTime.Second.ToString();
            calendarInicial.Value = dateTime;
        }

        public void cargarFechaFinal(DateTime dateTime) {
            txtHoraFinal.Text = dateTime.Hour.ToString();
            txtMinutoFinal.Text = dateTime.Minute.ToString();
            txtSegundoFinal.Text = dateTime.Second.ToString();
            calendarFinal.Value = dateTime;
        }

    }
}
