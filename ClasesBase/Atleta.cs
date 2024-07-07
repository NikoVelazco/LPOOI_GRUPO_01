using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Atleta
    {
        private int atl_ID;

        public int Atl_ID
        {
            get { return atl_ID; }
            set { atl_ID = value; }
        }
        private string atl_DNI;

        public string Atl_DNI
        {
            get { return atl_DNI; }
            set { atl_DNI = value; }
        }
        private string atl_Apellido;

        public string Atl_Apellido
        {
            get { return atl_Apellido; }
            set { atl_Apellido = value; }
        }
        private string atl_Nombre;

        public string Atl_Nombre
        {
            get { return atl_Nombre; }
            set { atl_Nombre = value; }
        }
        private string atl_Nacionalidad;

        public string Atl_Nacionalidad
        {
            get { return atl_Nacionalidad; }
            set { atl_Nacionalidad = value; }
        }
        private string atl_Entrenador;

        public string Atl_Entrenador
        {
            get { return atl_Entrenador; }
            set { atl_Entrenador = value; }
        }
        private string atl_Genero;

        public string Atl_Genero
        {
            get { return atl_Genero; }
            set { atl_Genero = value; }
        }
        private double atl_Altura;

        public double Atl_Altura
        {
            get { return atl_Altura; }
            set { atl_Altura = value; }
        }
        private double atl_Peso;

        public double Atl_Peso
        {
            get { return atl_Peso; }
            set { atl_Peso = value; }
        }
        private DateTime atl_FechaNac;

        public DateTime Atl_FechaNac
        {
            get { return atl_FechaNac; }
            set { atl_FechaNac = value; }
        }
        private string atl_Direccion;

        public string Atl_Direccion
        {
            get { return atl_Direccion; }
            set { atl_Direccion = value; }
        }
        private string atl_Email;

        public string Atl_Email
        {
            get { return atl_Email; }
            set { atl_Email = value; }
        }

        public override string ToString()
        {
            string atletaString = "ID: " + atl_ID + "\n" +
                                  "Nombre: " + atl_Nombre + "\n" +
                                  "Apellido: " + atl_Apellido + "\n" +
                                  "Fecha de Nacimiento: " + atl_FechaNac.ToString() + "\n" +
                                  "DNI: " + atl_DNI + "\n" +
                                  "Nacionalidad: " + atl_Nacionalidad + "\n" +
                                  "Entrenador: " + atl_Entrenador + "\n" +
                                  "Genero: " + atl_Genero + "\n" +
                                  "Altura: " + atl_Altura + "\n" +
                                  "Peso: " + atl_Peso + "\n" +
                                  "Dirección: " + atl_Direccion + "\n" +
                                  "Email: " + atl_Email + "\n";

            return atletaString;
        }
    }
}
