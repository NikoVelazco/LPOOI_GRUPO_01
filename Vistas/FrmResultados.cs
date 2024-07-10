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
    public partial class FrmResultados : Form
    {
        public FrmResultados()
        {
            InitializeComponent();
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
            cmbListaCompetenciasParaResultados.SelectedIndex = -1;
            loadListOfCompetencias();
        }

        private void loadListOfCompetencias()
        {
            DataTable dataTable = TrabajarCompetencia.getAllowedCompetencias();

            cmbListaCompetenciasParaResultados.DataSource = dataTable;
            cmbListaCompetenciasParaResultados.DisplayMember = "Nombre";
            cmbListaCompetenciasParaResultados.ValueMember = "Id";
        }

        private void loadListOfResultados(int com_Id)
        {
            DataTable dataTable = TrabajarResultado.GetResultados(com_Id);
            
            dgvResultados.DataSource = dataTable;
            dgvResultados.Columns["Id"].Visible = false;
            dgvResultados.Columns["Hora_Inicio"].Visible = false;
            dgvResultados.Columns["Hora_Fin"].Visible = false;
        }

        private void cmbListaCompetenciasParaResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadListOfResultados(Utilidades.ParseStringToInt(cmbListaCompetenciasParaResultados.SelectedValue.ToString()));
            loadInformationLabels(Utilidades.ParseStringToInt(cmbListaCompetenciasParaResultados.SelectedValue.ToString()));
        }

        private void loadInformationLabels(int com_Id)
        {
            DataTable dataTable = TrabajarResultado.GetAtletasByCompetencia(com_Id);

            lblValorCantidadParticipantes.Text = (Convert.ToInt32(dataTable.Rows[0][0].ToString()) + Convert.ToInt32(dataTable.Rows[0][1].ToString()) + Convert.ToInt32(dataTable.Rows[0][2].ToString())).ToString();
            lblValorCantidadDescalificados.Text = dataTable.Rows[0][1].ToString();
            lblValorCantidadAbandonos.Text = dataTable.Rows[0][2].ToString();
        }
    }
}
