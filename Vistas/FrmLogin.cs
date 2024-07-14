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
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        /**
         * Hora y Fecha
         * */

        private void dataTime_Tick(object sender, EventArgs e)
        {
            Util.getDateTime(lblTime, lblDate);
        }

        /**
         * Apaga la app
         * */
        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            Util.closeApp("alerta.mp3");
        }

        /**
         * Minimiza la app
         * */
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /**
         * Cierra la app
         * */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Util.closeApp("alerta.mp3");
        }

        /**
         * Mueve la ventana
         * */
        private void pnlWindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            Util.DragForm(this);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        /**
         * Login
         * */
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Usuario")
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUserName.Text;
            string contrasenia = txtPassword.Text;
            if (TrabajarUsuario.validarUsuario(usuario, contrasenia))
            {
                Util.startSound("sound-correct.mp3");
                Util.messageYesNo("Bienvenido(a) " + usuario, "Login Correcto", MessageBoxButtons.OK, MessageBoxIcon.None);
                FrmPrincipal oFrmPrincipal = new FrmPrincipal();
                oFrmPrincipal.txtUser.Text = usuario;
                oFrmPrincipal.txtRol.Text = TrabajarUsuario.getUserRol(usuario);
                oFrmPrincipal.Show();
                this.Hide();
            }
            else
            {
                Util.messageYesNo("Las crendenciales son incorrectas", "Login Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Recuperar contraseña form
         * */
        private void lblRecoverPassword_Click(object sender, EventArgs e)
        {
            Util.startSound("alerta.mp3");
            FrmRecoverEmail oFrmRecover = new FrmRecoverEmail();
            oFrmRecover.Show();
        }

    }
}
