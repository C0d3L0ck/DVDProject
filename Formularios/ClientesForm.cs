using System.IO;
using System;
using System.Windows.Forms;
using ProyectoIUJO.Clases;
using System.Drawing;

namespace ProyectoIUJO.Formularios
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }
        public string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(directorioBase, "Clientes.txt");
            FileInfo archivoInfo = new FileInfo(rutaArchivo);
            if (File.Exists(rutaArchivo) && archivoInfo.Length > 0)
            {
                LeerArchivo();
            }
            for (int i = 0; i < ClientesColeccion.Clients.Count; i++)  ////INICIOOOOOOOOOOO !! ///
            {
                int n = dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = ClientesColeccion.Clients[i].Nombres.ToString();
                dataGrid.Rows[i].Cells[1].Value = ClientesColeccion.Clients[i].Apellidos.ToString();
                dataGrid.Rows[i].Cells[2].Value = ClientesColeccion.Clients[i].dHabitacion.ToString();
                dataGrid.Rows[i].Cells[3].Value = ClientesColeccion.Clients[i].Cedula.ToString();
                dataGrid.Rows[i].Cells[4].Value = ClientesColeccion.Clients[i].fNacimiento.ToString();
                dataGrid.Rows[i].Cells[5].Value = ClientesColeccion.Clients[i].Correo.ToString();
                dataGrid.Rows[i].Cells[6].Value = ClientesColeccion.Clients[i].celularPersonal.ToString();
                dataGrid.Rows[i].Cells[7].Value = ClientesColeccion.Clients[i].celularCasa.ToString();
                dataGrid.Rows[i].Cells[8].Value = ClientesColeccion.Clients[i].fRegistro.ToString();
            }

        }



        private void registrarBtn_Click(object sender, System.EventArgs e)
        {
            Validaciones();
        }

       public void Validaciones()
        {
            if(String.IsNullOrEmpty(nombreBox.Text))
            {
                MessageBox.Show("La barra de nombre está vacia");
            }else if(String.IsNullOrEmpty(apellidoBox.Text))
            {
                MessageBox.Show("La barra de apellido está vacia");
            }else if (String.IsNullOrEmpty(habitacionBox.Text))
            {
                MessageBox.Show("La barra de dirección de habitación está vacia");
            }else if (String.IsNullOrEmpty(cedulaBox.Text)){
                MessageBox.Show("La barra de cédula está vacia");
            }else if(nacimientoDate.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento es mayor a la fecha actual");
            }else if (String.IsNullOrEmpty(correoBox.Text))
            {
                MessageBox.Show("La barra de correo está vacia");
            } else if (String.IsNullOrEmpty(nPersonalBox.Text))
            {
                MessageBox.Show("La barra de número personal está vacia");
            } else if (String.IsNullOrEmpty(nCasaBox.Text))
            {
                MessageBox.Show("La barra del número de la casa está vacia");
            }
            else
            {
                registrar.Registrar(nombreBox.Text, apellidoBox.Text, habitacionBox.Text, cedulaBox.Text, nacimientoDate.Value, correoBox.Text, nPersonalBox.Text, nCasaBox.Text, DateTime.Now);
                Datos();
                GuardarArchivo();
            }
        }

        public void Datos()
        {
            dataGrid.Rows.Add();
            int index = dataGrid.Rows.Count - 1;
            foreach (var datos in ClientesColeccion.Clients)
            {
                dataGrid.Rows[index].Cells[0].Value = datos.Nombres.ToString();
                dataGrid.Rows[index].Cells[1].Value = datos.Apellidos.ToString();
                dataGrid.Rows[index].Cells[2].Value = datos.dHabitacion.ToString();
                dataGrid.Rows[index].Cells[3].Value = datos.Cedula.ToString();
                dataGrid.Rows[index].Cells[4].Value = datos.fNacimiento.ToString();
                dataGrid.Rows[index].Cells[5].Value = datos.Correo.ToString();
                dataGrid.Rows[index].Cells[6].Value = datos.celularPersonal.ToString();
                dataGrid.Rows[index].Cells[7].Value = datos.celularCasa.ToString();
                dataGrid.Rows[index].Cells[8].Value = datos.fRegistro.ToString();
            }

        }

        ClientesColeccion registrar = new ClientesColeccion();
       public void GuardarArchivo()
        {
            using (StreamWriter writer = new StreamWriter("Clientes.txt", false))
            {
                foreach (var datos in ClientesColeccion.Clients)
                {
                    writer.WriteLine($"{datos.Nombres};{datos.Apellidos};{datos.dHabitacion};{datos.Cedula};{datos.fNacimiento};{datos.Correo};{datos.celularPersonal};{datos.celularCasa};{datos.fRegistro}");

                }

            }
        }
        public void LeerArchivo()
        {
            try
            {
                using (StreamReader reader = new StreamReader("Clientes.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(';');

                        Clientes clientes = new Clientes();
                        clientes.Nombres = parts[0];
                        clientes.Apellidos = parts[1];
                        clientes.dHabitacion = parts[2];
                        clientes.Cedula = parts[3];
                        clientes.fNacimiento = Convert.ToDateTime(parts[4]);
                        clientes.Correo = parts[5];
                        clientes.celularPersonal = parts[6];
                        clientes.celularCasa = parts[7];
                        clientes.fRegistro = Convert.ToDateTime(parts[8]);

                        ClientesColeccion.Clients.Add(clientes);

                    }
                }
            }catch (Exception ex)
            {

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                int rowIndex = dataGrid.SelectedCells[0].RowIndex;
                dataGrid.Rows.RemoveAt(rowIndex);
                ClientesColeccion.Clients.RemoveAt(rowIndex);
                using (StreamWriter writer = new StreamWriter("Clientes.txt", false))
                {
                    foreach (var datos in ClientesColeccion.Clients)
                    {
                        writer.WriteLine($"{datos.Nombres};{datos.Apellidos};{datos.dHabitacion};{datos.Cedula};{datos.fNacimiento};{datos.Correo};{datos.celularPersonal};{datos.celularCasa};{datos.fRegistro}");
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(directorioBase, "Clientes.txt");
            FileInfo archivoInfo = new FileInfo(rutaArchivo);
            if (File.Exists(rutaArchivo) && archivoInfo.Length > 0)
            {
                Actualizar();
            }
        }

        void Actualizar()
        {
            LeerArchivoSinGuardar();
            dataGrid.Rows.Clear();
            dataGrid.Rows.Add(ClientesColeccion.Clients.Count);

            for (int i = 0; i < ClientesColeccion.Clients.Count; i++)  ////ACTUALIZARRR ///
            {
                dataGrid.Rows[i].Cells[0].Value = ClientesColeccion.Clients[i].Nombres.ToString();
                dataGrid.Rows[i].Cells[1].Value = ClientesColeccion.Clients[i].Apellidos.ToString();
                dataGrid.Rows[i].Cells[2].Value = ClientesColeccion.Clients[i].dHabitacion.ToString();
                dataGrid.Rows[i].Cells[3].Value = ClientesColeccion.Clients[i].Cedula.ToString();
                dataGrid.Rows[i].Cells[4].Value = ClientesColeccion.Clients[i].fNacimiento.ToString();
                dataGrid.Rows[i].Cells[5].Value = ClientesColeccion.Clients[i].Correo.ToString();
                dataGrid.Rows[i].Cells[6].Value = ClientesColeccion.Clients[i].celularPersonal.ToString();
                dataGrid.Rows[i].Cells[7].Value = ClientesColeccion.Clients[i].celularCasa.ToString();
                dataGrid.Rows[i].Cells[8].Value = ClientesColeccion.Clients[i].fRegistro.ToString();
            }

        }

        void LeerArchivoSinGuardar()
        {
            ClientesColeccion.Clients.Clear();
            using (StreamReader reader = new StreamReader("Clientes.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(';');

                    Clientes clientes = new Clientes();
                    clientes.Nombres = parts[0];
                    clientes.Apellidos = parts[1];
                    clientes.dHabitacion = parts[2];
                    clientes.Cedula = parts[3];
                    clientes.fNacimiento = Convert.ToDateTime(parts[4]);
                    clientes.Correo = parts[5];
                    clientes.celularPersonal = parts[6];
                    clientes.celularCasa = parts[7];
                    clientes.fRegistro = Convert.ToDateTime(parts[8]);
                    ClientesColeccion.Clients.Add(clientes);

                }
            }

        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() == consultarBox.Text)
                    {
                        dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        row.Selected = true;
                        dataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                        return; // Detener la búsqueda una vez que se haya encontrado la fila deseada
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }


        Consultar consulta = new Consultar();
        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (dataGrid.Rows[i].Cells[0].Selected == true)
                {
                    if (consulta == null || consulta.IsDisposed)
                    {
                        consulta = new Consultar();
                    }

                    consulta.Show();
                    consulta.Consultando($"Nombres: {dataGrid.Rows[i].Cells[0].Value.ToString()} \nApellidos: {dataGrid.Rows[i].Cells[1].Value.ToString()} \nHabitación: {dataGrid.Rows[i].Cells[2].Value.ToString()} \nCédula:{dataGrid.Rows[i].Cells[3].Value.ToString()} \nFecha de Nacimiento: {dataGrid.Rows[i].Cells[4].Value.ToString()} \nCorreo: {dataGrid.Rows[i].Cells[5].Value.ToString()}\nNúmero personal: {dataGrid.Rows[i].Cells[6].Value.ToString()} \n Numero hogar: {dataGrid.Rows[i].Cells[7].Value.ToString()} \n Fecha de creación: {dataGrid.Rows[i].Cells[8].Value.ToString()}");

                }
            }
        }
    }
}
