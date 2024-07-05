using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Categoria
    {
        public Categoria()
        {
        }

        private int cat_ID;

        public int Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }
        private string cat_Nombre;

        public string Cat_Nombre
        {
            get { return cat_Nombre; }
            set { cat_Nombre = value; }
        }
        private string cat_Descripcion;

        public string Cat_Descripcion
        {
            get { return cat_Descripcion; }
            set { cat_Descripcion = value; }
        }

        public override string ToString()
        {
            string categoriaString = "ID: " + cat_ID + "\n" +
                                     "Nombre Categoria: " + cat_Nombre + "\n" +
                                     "Descripcion: " + cat_Descripcion;
            return categoriaString;
        }
    }
}
