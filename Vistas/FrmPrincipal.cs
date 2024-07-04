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
    public partial class FrmPrincipal : Form
    {
        public Usuario userLogueado = new Usuario();

        public FrmPrincipal()
        {
            InitializeComponent();
            disabledButtonByRol();
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

        /**
         * Mueve la ventana
         * **/
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

        /**
         * Lleva al form home
         * */
        private void btnHome_Click(object sender, EventArgs e)
        {
            Util.openFormInPanel(new FrmHome(txtUser.Text), panelContenedor);
            imgUser.Visible = false;
        }

        /**
         * Lleva a la gestión de usuario
         * **/
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Util.openFormInPanel(new FrmGestionUsuario(), panelContenedor);
            imgUser.Visible = true;
        }

        /**
         * Pantalla Principal
         * */
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            userLogueado = TrabajarUsuario.searchUserByNameUser(txtUser.Text);
            Util.openFormInPanel(new FrmHome(txtUser.Text), panelContenedor);
            imgUser.Image = userLogueado.Usu_Imagen;
            imgUser.Visible = false;
            disabledButtonByRol();
        }

        public void disabledButtonByRol()
        {
            if (TrabajarUsuario.getRolCodigo(txtUser.Text) == 1)
            {
                Util.disabledButton(btnAtletas);
                Util.disabledButton(btnCategorias);
                Util.disabledButton(btnDisciplinas);
                Util.disabledButton(btnCompetencia);
                Util.disabledButton(btnEventos);
            }
            if (TrabajarUsuario.getRolCodigo(txtUser.Text) == 2)
            {
                Util.disabledButton(btnUsuarios);
                Util.disabledButton(btnCategorias);
                Util.disabledButton(btnDisciplinas);
                Util.disabledButton(btnEventos);
            }
            if (TrabajarUsuario.getRolCodigo(txtUser.Text) == 3)
            {
                Util.disabledButton(btnUsuarios);
            }
        }

    }
}
