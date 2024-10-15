using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIUJO.Clases
{
    public class Prestamos
    {
        private string cliente;
        private string titulo;
        private int cantidad;
        private DateTime fecha;
        private int monto;
        private string tipo;
        public string Cliente { get { return cliente; } set { cliente = value; } }
        public string Titulo { get {  return titulo; } set {  titulo = value; } }
        public int Cantidad { get {  return cantidad; } set {  cantidad = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int Monto { get {  return monto; } set {  monto = value; } }
        public string Tipo { get { return tipo; } set {  tipo = value; } }

        public Prestamos()
        {
            Cliente = ""; Titulo = ""; Cantidad = 0; Fecha = DateTime.Now; Monto = 0; Tipo = "";
        }

        public Prestamos(string cliente, string t, int c, DateTime f, int m, string tipo)
        {

            this.Cliente = cliente; 
            this.Titulo = t;
            this.Cantidad = c;
            this.Fecha = f; 
            this.Monto = m;
            this.Tipo = tipo;
        } 
    }
}
