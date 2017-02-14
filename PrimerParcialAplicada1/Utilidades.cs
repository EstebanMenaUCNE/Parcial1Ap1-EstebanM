using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcialAplicada1
{
    public class Utilidades
    {
        public static int ToInt(string text)
        {
            int n = 0;
            int.TryParse(text, out n);
            return n;
        }

        public static float ToFloat(string text)
        {
            float n = 0;
            float.TryParse(text, out n);
            return n;
        }
    }
}
