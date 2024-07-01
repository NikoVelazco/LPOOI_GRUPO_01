using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Net;
using System.Net.Mail;

namespace Vistas
{
    public partial class FrmRecoverEmail : Form
    {
        public FrmRecoverEmail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtRecover.Text == "" || !txtRecover.Text.Contains('@'))
                MessageBox.Show("El email no corresponde a un formato válido");
            else
            {
                string body = "";
                DataTable usuarios = TrabajarUsuario.buscarPorCorreo(txtRecover.Text);

                foreach (DataRow row in usuarios.Rows)
                {
                    string usuario = row["Usu_NombreUsuario"].ToString();
                    string pwd = row["Usu_Contraseña"].ToString();
                    body += string.Format("Usuario: {1}{0}Contraseña: {2}{0}{0}", Environment.NewLine, usuario, pwd);
                }
                RecoverEmail.Send(txtRecover.Text, "lpoo1.2024@outlook.com", "Recuperación de usuario y contraseña", body);
                this.Close();
            }
        }
    }
}
