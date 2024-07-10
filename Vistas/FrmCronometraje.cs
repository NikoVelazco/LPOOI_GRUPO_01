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
    public partial class FrmCronometraje : Form
    {


        private string currentPattern = "";
        private string currentOrder = "Apellido";

        public FrmCronometraje()
        {
            
            InitializeComponent();
            getAllAthletes();
            getAllCompetitions();
        }
    
    
        public void getAllAthletes(){
            DataTable dataTableAthletes = TrabajarAtleta.listarAtletas(currentOrder, currentPattern);
            cmbAtletas.DisplayMember = "Apellido";
            cmbAtletas.ValueMember = "id";
            cmbAtletas.DataSource = dataTableAthletes;
            dataGridAtletas.DataSource = dataTableAthletes;
            dataGridAtletas.Columns["Atl_ID"].Visible = false;
        }
        
        public void getAllCompetitions(){

            DataTable dataTableCompetition = TrabajarCompetencia.getCompetencias();
            cmbCompetencias.DisplayMember = "Nombre";
            cmbCompetencias.ValueMember = "id";
            cmbCompetencias.DataSource = dataTableCompetition;
            dataGridCompetencia.DataSource = dataTableCompetition;
            dataGridCompetencia.Columns["id"].Visible = false;
            dataGridCompetencia.Columns["Cat_ID"].Visible = false;
            dataGridCompetencia.Columns["Dis_ID"].Visible = false;
           
        }

        private void dataGridAtletas_SelectionChanged(object sender, EventArgs e)
        {
            cmbAtletas.Text = dataGridAtletas.CurrentRow.Cells["Apellido"].Value.ToString();
        }

        private void dataGridCompetencia_SelectionChanged(object sender, EventArgs e)
        {
            cmbCompetencias.Text = dataGridCompetencia.CurrentRow.Cells["Nombre"].Value.ToString();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if(numericValidation()){
               
               DialogResult mensaje = MessageBox.Show("¿Estás seguro que quieres guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (mensaje == DialogResult.Yes)
               {
                   Evento es = createNewEvent();
                   MessageBox.Show(es.Eve_Estado);
               }
               else
               {
                   Util.clearTextBox(panelContenedor);
               }
           
        
           }else{
           
                MessageBox.Show("Debe ingresar valores numericos validos");
           }


        }

        public Evento createNewEvent()
        {
            Evento nuevoEvento = new Evento();
            nuevoEvento.Atl_ID = int.Parse(dataGridAtletas.CurrentRow.Cells["Atl_ID"].Value.ToString());
            nuevoEvento.Com_ID = int.Parse(dataGridCompetencia.CurrentRow.Cells["Id"].Value.ToString());
            nuevoEvento.Eve_HoraInicio = getInitialDateTime();
            nuevoEvento.Eve_HoraFin = getFinalDateTime();
            nuevoEvento.Eve_Estado = cmbEstado.Text;
            return nuevoEvento;
            
        }

        public DateTime getFinalDateTime() {
            DateTime calendarDateTime = calendarFinal.SelectionStart;

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
            DateTime calendarDateTime = calendarInicial.SelectionStart;

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

        private void btnAutoCompletarInicio_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime fecha = new DateTime(now.Year, now.Month, now.Day);
            calendarInicial.SetDate(fecha);
            txtHoraInicial.Text = now.Hour.ToString();
            txtMinutoInicial.Text = now.Minute.ToString();
            txtSegundoInicial.Text = now.Second.ToString();
        }

        private void btnAutoCompletarFinal_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime fecha = new DateTime(now.Year, now.Month, now.Day);
            calendarFinal.SetDate(fecha);
            txtHoraFinal.Text = now.Hour.ToString();
            txtMinutoFinal.Text = now.Minute.ToString();
            txtSegundoFinal.Text = now.Second.ToString();
        }

       



    
    
    
    
    }

}
