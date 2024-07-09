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
        private bool band = false;
        private DataTable totales = new DataTable();

        public FrmResultados()
        {
            InitializeComponent();
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
            loadCompetencias();
        }

        private void loadCompetencias()
        {
            cmbCompetencia.DataSource = TrabajarCompetencia.getCompetencias();
            cmbCompetencia.DisplayMember = "Nombre";
            cmbCompetencia.ValueMember = "Id";
            band = true;
        }

        private void cmbCompetencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band)
            {
                int comId = (int)cmbCompetencia.SelectedValue;
                dataGridResultados.DataSource = TrabajarEvento.getResultadosByComId(comId);
                asignarTotales(comId);
            }
        }

        private void asignarTotales(int id) 
        {
            this.totales = TrabajarEvento.getTotales(id);
            lblTotal.Text = this.totales.Rows[0][0].ToString();
            lblDescalificados.Text = this.totales.Rows[0][1].ToString();
            lblAbandonos.Text = this.totales.Rows[0][2].ToString();
        }
    }
}
