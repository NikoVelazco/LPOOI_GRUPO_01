using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Evento
    {
        private int eve_ID;

        public int Eve_ID
        {
            get { return eve_ID; }
            set { eve_ID = value; }
        }
        private string eve_Estado;

        public string Eve_Estado
        {
            get { return eve_Estado; }
            set { eve_Estado = value; }
        }
        private DateTime eve_HoraInicio;

        public DateTime Eve_HoraInicio
        {
            get { return eve_HoraInicio; }
            set { eve_HoraInicio = value; }
        }
        private DateTime eve_HoraFin;

        public DateTime Eve_HoraFin
        {
            get { return eve_HoraFin; }
            set { eve_HoraFin = value; }
        }
        private int com_ID;

        public int Com_ID
        {
            get { return com_ID; }
            set { com_ID = value; }
        }
        private int atl_ID;

        public int Atl_ID
        {
            get { return atl_ID; }
            set { atl_ID = value; }
        }

        public Evento()
        {
            //throw new System.NotImplementedException();
        }
    }
}
