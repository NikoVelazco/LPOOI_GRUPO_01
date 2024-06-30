using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vistas
{
    public static class Util
    {
        /**
         * Obtiene la fecha y hora actual del sistema
         * **/
        public static void getDateTime(Label lblTime, Label lblDate)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        /**
         * Apaga la aplicación
         * **/
        public static void closeApp()
        {
            DialogResult mensaje = MessageBox.Show("¿Estás seguro que queres salir de la aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /**
         * Mueve la ventana
         * */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void DragForm(Form form)
        {
            ReleaseCapture();
            SendMessage(form.Handle, 0x112, 0xf012, 0);
        }

        /**
         * Reproduce Sonido
         * */
        public static string soundPath(string nameMusic)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            var VistasDirectory = CurrentDirectory.Substring(0, CurrentDirectory.Length - 9);
            return VistasDirectory + "\\Recursos\\sounds\\" + nameMusic;
        }

    }
}
