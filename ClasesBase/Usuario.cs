using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;

        public Usuario(int idUsuario, string nombreUsuario, string contrasenia, string apellidoNombre, int rolCodigo)
        {
            this.usu_ID = idUsuario;
            this.usu_NombreUsuario = nombreUsuario;
            this.usu_Contrasenia = contrasenia;
            this.usu_ApellidoNombre = apellidoNombre;
            this.rol_Codigo = rolCodigo;
        }

        public Usuario() { }

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private string usu_NombreUsuario;

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        private string usu_Contrasenia;

        public string Usu_Contrasenia
        {
            get { return usu_Contrasenia; }
            set { usu_Contrasenia = value; }
        }
        private string usu_ApellidoNombre;

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        private int rol_Codigo;

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        private string usu_Email;

        public string Usu_Email
        {
            get { return usu_Email; }
            set { usu_Email = value; }
        }

        private Image usu_Imagen;

        public Image Usu_Imagen
        {
            get { return usu_Imagen; }
            set { usu_Imagen = value; }
        }

        public override string ToString()
        {
            string usuarioString = "ID: " + Usu_ID + "\n" +
                                  "Nombre Usaurio: " + Usu_NombreUsuario + "\n" +
                                  "Contraseña: " + Usu_Contrasenia + "\n" +
                                  "Apellido y Nombre: " + Usu_ApellidoNombre +
                                  "ID_Rol: " + Rol_Codigo + "\n";
            return usuarioString;
        }

    }
}