using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIUJO.Clases
{
    public class PrestamosColeccion
    {
        public static List<Prestamos> prestamos = new List<Prestamos>();
       
        public PrestamosColeccion(){
            prestamos = new List<Prestamos>();
        }

        public void Registrar(string cliente, string t, int c, DateTime f, int m, string tipo)
        {
            Prestamos pres = new Prestamos(cliente, t, c, f, m, tipo);
            prestamos.Add(pres);
        }
    }

    
}
