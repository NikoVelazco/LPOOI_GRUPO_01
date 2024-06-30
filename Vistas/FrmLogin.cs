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
    public partial class FrmLogin : Form
    {

        WMPLib.WindowsMediaPlayer music;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public void playMusic(string link)
        {
            music = new WMPLib.WindowsMediaPlayer();
            music.URL = link;
            music.controls.play();
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
            Util.closeApp();
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
            Util.closeApp();
        }

        /**
         * Mueve la ventana
         * */
        private void pnlWindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            Util.DragForm(this);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            playMusic(Util.soundPath("Login-sound.mp3"));
        }
    }
}
