using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIUJO
{
    public class DVDColeccion
    {
        public static List<DVD> DVDs;


        public DVDColeccion()
        {
           DVDs = new List<DVD>();
        }

        public void Registrar(string c, string t, DateTime fE, string tipo, int cantidad, DateTime fI, bool P, Image img, string descr)
        {
            DVD dvd = new DVD(c, t, fE, tipo, cantidad, fI, P, img, descr);
            DVDs.Add(dvd);
        }
    }
}
