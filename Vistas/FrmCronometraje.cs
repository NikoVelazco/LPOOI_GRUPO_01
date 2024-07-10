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

            cmbAtletas.DisplayMember = "Apellido";
            cmbAtletas.ValueMember = "id";
            cmbAtletas.DataSource = TrabajarAtleta.getAllAtletas();
            dataGridAtletas.DataSource = TrabajarAtleta.listarAtletas(currentOrder, currentPattern);
            dataGridAtletas.Columns["Atl_ID"].Visible = false;
        }
        
        public void getAllCompetitions(){

            cmbCompetencias.DisplayMember = "Nombre";
            cmbCompetencias.ValueMember = "id";
            cmbCompetencias.DataSource = TrabajarCompetencia.getCompetencias();
            dataGridCompetencia.DataSource = TrabajarCompetencia.getCompetencias();
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
           int hora, segundos, minutos;
           if(int.TryParse(txtHora.Text, out hora) && int.TryParse(txtMinuto.Text, out minutos) && int.TryParse(txtSegundo.Text, out segundos)){
               
               DialogResult mensaje = MessageBox.Show("¿Estás seguro que quieres guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (mensaje == DialogResult.Yes)
               {
                    
               }
               else
               {
                   Util.clearTextBox(panelContenedor);
               }
           
        
           }else{
           
                MessageBox.Show("Debe ingresar valores numericos validos");
           }


        }

        

       

       

      
    
    
    
    
    
    
    
    }

}
