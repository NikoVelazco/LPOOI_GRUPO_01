using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ClasesBase
{
    public class Utilidades
    {
        public static int ParseStringToInt(string s)
        {
            int i;
            return int.TryParse(s, out i) ? i : -1;
        }
    }
}
