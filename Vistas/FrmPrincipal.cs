using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /**
         * Obtiene la hora y fecha actual
         * */
        private void dateTimer_Tick(object sender, EventArgs e)
        {
            Util.getDateTime(lblTime, lblDate);
        }

        /**
         * Minimiza la Ventana
         * **/
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /**
         * Cierra la aplicación
         * */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Util.closeApp("alerta.mp3");
        }

        private void pnlWindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            Util.DragForm(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin oFrmLogin = new FrmLogin();
            oFrmLogin.Show();
            this.Close();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 200)
            {
                menuVertical.Width = 70;
            }
            else
            {
                menuVertical.Width = 200;
            }
        }
    }
}
