using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIUJO.Clases
{
    public class ClientesColeccion
    {
        public static List<Clientes> Clients;

        public ClientesColeccion()
        {
            Clients = new List<Clientes>();
        }

        public void Registrar(string n, string a, string h, string c, DateTime fn, string correo, string np, string nh, DateTime fr)
        {
            Clientes clientitos = new Clientes(n,a,h,c,fn,correo,np,nh,fr);
            Clients.Add(clientitos);
        }
    }
}
