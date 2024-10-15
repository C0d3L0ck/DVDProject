using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoIUJO
{
    public class DVD
    {
        private string codigo;
        private string titulo;
        private DateTime fechaemision;
        private string tipo;
        private int cantidad;
        private DateTime fechaingreso;
        private bool prestamo;
        private Image imagen;
        private string descripcion;
        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public DateTime fechaEmision { get { return fechaemision; } set { fechaemision = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public DateTime fechaIngreso { get { return fechaingreso; } set { fechaingreso = value; } }
        public bool Prestamo { get { return prestamo; } set { prestamo = value; } }
        public Image Imagen { get { return imagen; } set { imagen = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public DVD()
        {
            Codigo = ""; Titulo = ""; fechaEmision = DateTime.Now; Tipo = ""; fechaIngreso = DateTime.Now;
            Prestamo = true; Cantidad = 0; Imagen = new Bitmap(1, 1); Descripcion = "";
        }

    public DVD(string c, string t, DateTime fE, string tipo, int can, DateTime fI, bool P, Image img, string descr)
        {
            Codigo = c; Titulo = t; fechaEmision = fE; Tipo = tipo; fechaIngreso = fI;
            Prestamo = P; Cantidad = can; Imagen = img; Descripcion = descr;
        }
    }
}
