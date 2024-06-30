using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
using System.Drawing;

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

    }
}
