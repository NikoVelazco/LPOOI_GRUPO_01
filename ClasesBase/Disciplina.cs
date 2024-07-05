using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Disciplina
    {
        private static int idCont = 1;

        public Disciplina()
        {
            this.dis_ID = idCont;
            idCont++;
        }

        private int dis_ID; /*Preguntar si se puede cambiar a entero*/

        public int Dis_ID
        {
            get { return dis_ID; }
            set { dis_ID = value; }
        }
        private string dis_Nombre;

        public string Dis_Nombre
        {
            get { return dis_Nombre; }
            set { dis_Nombre = value; }
        }
        private string dis_Descripcion;

        public string Dis_Descripcion
        {
            get { return dis_Descripcion; }
            set { dis_Descripcion = value; }
        }

        public override string ToString()
        {
            string disciplinaString = "ID: " + Dis_ID + "\n" +
                                  "Nombre Disciplina: " + Dis_Nombre + "\n" +
                                  "Descripcion: " + Dis_Descripcion;
            return disciplinaString;
        }

    }
}
