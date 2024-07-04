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
    public partial class FrmHome : Form
    {
        public Usuario userLogueado = new Usuario();
        private string nombreUser;
        public FrmHome(string nombreUser)
        {
            InitializeComponent();
            this.nombreUser = nombreUser;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            userLogueado = TrabajarUsuario.searchUserByNameUser(nombreUser);
            lblBienvenida.Text = "Bienvenido(a) " + userLogueado.Usu_ApellidoNombre;
            lblRol.Text = "Su rol es: " + TrabajarUsuario.getUserRol(nombreUser);
            imgUsuario.Image = userLogueado.Usu_Imagen;
            //lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
