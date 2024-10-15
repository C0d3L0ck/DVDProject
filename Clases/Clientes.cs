using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIUJO.Clases
{
    public class Clientes
    {
        private string cedula;
        private string nombres;
        private string apellidos;
        private string dhabitacion;
        private DateTime fnacimiento;
        private string direccion;
        private string correo;
        private string celularpersonal;
        private string celularcasa;
        private DateTime fregistro;
        public string Cedula { get { return cedula; } set {  cedula = value; } }
        public string Nombres { get {  return nombres; } set {  nombres = value; } }
        public string Apellidos { get {  return apellidos; } set {  apellidos = value; } }
        public string dHabitacion { get { return dhabitacion; } set { dhabitacion = value; } }
        public DateTime fNacimiento { get { return fnacimiento; } set { fnacimiento = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Correo { get {  return correo; } set {  correo = value; } }
        public string celularPersonal { get { return celularpersonal; } set { celularpersonal = value; } }
        public string celularCasa { get { return celularcasa; } set { celularcasa = value; } }
        public DateTime fRegistro { get {  return fregistro; } set {  fregistro = value; } }

        public Clientes()
        {
            Cedula = ""; Nombres = ""; Apellidos = ""; dHabitacion = "";  fNacimiento = DateTime.Now;
            Direccion = ""; Correo = ""; celularPersonal = ""; celularCasa = "";
            fRegistro = DateTime.Now;
        }

        public Clientes(string nombres, string apellidos, string habitacion, string cedula, DateTime fnacimiento, string correo, string numeropersonal, string numerohogar, DateTime fregistro)
        {
            Nombres = nombres; Apellidos = apellidos; dHabitacion =habitacion; Cedula = cedula; fNacimiento = fnacimiento;
            Correo = correo; celularPersonal = numeropersonal; celularCasa = numerohogar; fRegistro = fregistro;
        }
    }
}
