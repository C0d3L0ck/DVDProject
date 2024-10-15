using ProyectoIUJO.Clases;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoIUJO.Formularios
{
    public partial class PrestamosMenu : Form
    {
        public PrestamosMenu()
        {
            InitializeComponent();
        }
       

        
        private void PrestamosMenu_Load(object sender, EventArgs e)
        {

            diasDecimal.Text = dias.ToString();


            CargarClientes();
            CargarTitulos();

            string rutaArchivo = Path.Combine(directorioBase, "Prestamos.txt");
            FileInfo archivoInfo = new FileInfo(rutaArchivo);
            if (File.Exists(rutaArchivo) && archivoInfo.Length > 0)
            {
                LeerArchivo();
            }
            for (int i = 0; i < PrestamosColeccion.prestamos.Count; i++)  ////INICIOOOOOOOOOOO !! ///
            {
                int n = dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = PrestamosColeccion.prestamos[i].Cliente.ToString();
                dataGrid.Rows[i].Cells[1].Value = PrestamosColeccion.prestamos[i].Titulo.ToString();
                dataGrid.Rows[i].Cells[2].Value = PrestamosColeccion.prestamos[i].Cantidad.ToString();
                dataGrid.Rows[i].Cells[3].Value = PrestamosColeccion.prestamos[i].Fecha.ToString();
                dataGrid.Rows[i].Cells[4].Value = PrestamosColeccion.prestamos[i].Monto.ToString();
                dataGrid.Rows[i].Cells[5].Value = PrestamosColeccion.prestamos[i].Tipo.ToString();

            }
        }

        PrestamosColeccion pres = new PrestamosColeccion();
        int dolares;
        public void Costo()
        {
            int cantidadbox = Convert.ToInt32(cantidadBox.Value);

            string tipo = tipoLabel.Text;

            if (tipo == "Juego")
            {
                dias = +4;
                fecha.AddDays(dias);
                diasDecimal.Text = dias.ToString();
                dolares = 2 * cantidadbox;
                dolaresC.Text = dolares.ToString();
            }
            else if (tipo == "Película")
            {
                dias = +3;
                fecha.AddDays(dias);
                diasDecimal.Text = dias.ToString();
                dolares = 2 * cantidadbox;
                dolaresC.Text = dolares.ToString();
            }
            else if (tipo == "MP3")
            {
                dias = +7;
                fecha.AddDays(dias);
                diasDecimal.Text = dias.ToString();
                dolares = 2 * cantidadbox;
                dolaresC.Text = dolares.ToString();
            }
        }


        public void CargarClientes()
        {
            foreach (var Clientes in ClientesColeccion.Clients)
            {
                if (!clienteBox.Items.Contains(Clientes.Nombres))
                {
                    clienteBox.Items.Add(Clientes.Nombres);
                }
            }
        }

        public void CargarTitulos()
        {
            tituloBox.Items.Clear();
            for (int i = 0; i < DVDColeccion.DVDs.Count; i++)
            {
                tituloBox.Items.Add(DVDColeccion.DVDs[i].Titulo.ToString());
            }
        }

        public void SeleccionarTitulo()
        {
            int indiceSeleccionado = tituloBox.SelectedIndex;
            if (indiceSeleccionado >= 0 && DVDColeccion.DVDs[indiceSeleccionado].Prestamo == true)
            {
                DVD dvdSeleccionado = DVDColeccion.DVDs[indiceSeleccionado];
                inventarioValue.Text = dvdSeleccionado.Cantidad.ToString();
                cantidadBox.Maximum = dvdSeleccionado.Cantidad;
                tipoLabel.Text = dvdSeleccionado.Tipo;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            CargarClientes();
            CargarTitulos();
            dataGrid.Rows.Clear();

            for (int i = 0; i < PrestamosColeccion.prestamos.Count; i++) {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = PrestamosColeccion.prestamos[i].Cliente.ToString();
                dataGrid.Rows[i].Cells[1].Value = PrestamosColeccion.prestamos[i].Titulo.ToString();
                dataGrid.Rows[i].Cells[2].Value = PrestamosColeccion.prestamos[i].Cantidad.ToString();
                dataGrid.Rows[i].Cells[3].Value = PrestamosColeccion.prestamos[i].Fecha.ToString();
                dataGrid.Rows[i].Cells[4].Value = PrestamosColeccion.prestamos[i].Monto.ToString();
                dataGrid.Rows[i].Cells[5].Value = PrestamosColeccion.prestamos[i].Tipo.ToString();
            }
            
        }

        public void LeerArchivo()
        {
            using (StreamReader reader = new StreamReader("Prestamos.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(';');

                    Prestamos prestamitos = new Prestamos();
                    prestamitos.Cliente = Convert.ToString(parts[0]);
                    prestamitos.Titulo = Convert.ToString(parts[1]);
                    prestamitos.Cantidad = Convert.ToInt32(parts[2]);
                    prestamitos.Fecha = Convert.ToDateTime(parts[3]);
                    prestamitos.Monto = Convert.ToInt32(parts[4]);
                    prestamitos.Tipo = Convert.ToString(parts[5]);
                    PrestamosColeccion.prestamos.Add(prestamitos);

                }
            }
        }
           
            public void Data(){
                int n = dataGrid.Rows.Add();
                foreach (var datos in PrestamosColeccion.prestamos)
                {
                    dataGrid.Rows[n].Cells[0].Value = datos.Cliente.ToString();
                    dataGrid.Rows[n].Cells[1].Value = datos.Titulo.ToString();
                    dataGrid.Rows[n].Cells[2].Value = datos.Cantidad.ToString();
                    dataGrid.Rows[n].Cells[3].Value = datos.Fecha.ToString();
                    dataGrid.Rows[n].Cells[4].Value = datos.Monto.ToString();
                    dataGrid.Rows[n].Cells[5].Value = datos.Tipo.ToString();
                }
            }
        public string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
        public void registrarBtn_Click(object sender, EventArgs e)
        {
            foreach (var datos in DVDColeccion.DVDs)
            {
                if (datos.Cantidad != 0)
                {
                    if (datos.Titulo == tituloBox.Text)
                    {
                        datos.Cantidad -= Convert.ToInt32(cantidadBox.Value);
                        pres.Registrar(clienteBox.Text, tituloBox.Text, Convert.ToInt32(cantidadBox.Value), fecha, Convert.ToInt32(dolaresC.Text), tipoLabel.Text);

                        GuardarArchivoMenu();
                        GuardarArchivo();
                        Data();
                    }
                }
                else
                {
                    MessageBox.Show("No queda disponibilidad del artículo");
                }
            }
            SeleccionarTitulo();
        }
          
        public void GuardarArchivoMenu() // pendiente <<
        {
            using (StreamWriter writer = new StreamWriter("Archivo.txt", false))
            {
                foreach (var datos in DVDColeccion.DVDs)
                {
                    writer.WriteLine($"{datos.Codigo};{datos.Titulo};{datos.fechaEmision};{datos.Tipo};{datos.Cantidad};{datos.fechaIngreso};{datos.Prestamo};{datos.Descripcion}");
                }

            }
        }

        public void GuardarArchivo()
        {
            using (StreamWriter writer = new StreamWriter("Prestamos.txt", false))
            {
                foreach (var datos in PrestamosColeccion.prestamos)
                {
                    writer.WriteLine($"{datos.Cliente};{datos.Titulo};{datos.Cantidad};{datos.Fecha};{datos.Monto};{datos.Tipo}");
                }

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                int rowIndex = dataGrid.SelectedCells[0].RowIndex;
                dataGrid.Rows.RemoveAt(rowIndex);
                PrestamosColeccion.prestamos.RemoveAt(rowIndex);
                using (StreamWriter writer = new StreamWriter("Prestamos.txt", false))
                {
                    foreach (var datos in PrestamosColeccion.prestamos)
                    {
                        writer.WriteLine($"{datos.Cliente};{datos.Titulo};{datos.Cantidad};{datos.Fecha};{datos.Monto};{datos.Tipo}");
                    }
                }
            }
        }

        private void cantidadBox_ValueChanged(object sender, EventArgs e)
        {
            Costo();
            SeleccionarTitulo();
        }

        public DateTime fecha = DateTime.Now.AddDays(4);
        int dias;
        public void masBtn_Click(object sender, EventArgs e)
        {
              
            string tipo = tipoLabel.Text;

            if (tipo == "Juego")
            {
                
                dias += 4;
                
                fecha = fecha.AddDays(dias);
                dolares += 2;
                dolaresC.Text = dolares.ToString();
                diasDecimal.Text = dias.ToString();
            }
            else if (tipo == "Película")
            {
                dias += 3;
                fecha = fecha.AddDays(dias);
                dolares += 2;
                dolaresC.Text = dolares.ToString();
                diasDecimal.Text = dias.ToString();
            }
            else if (tipo == "MP3")
            {
                dias += 7;
                fecha = fecha.AddDays(dias);
                dolares += 2;
                dolaresC.Text = dolares.ToString();
                diasDecimal.Text = dias.ToString();
            }
        }

        private void menosBtn_Click(object sender, EventArgs e)
        {
            string tipo = tipoLabel.Text;

            if (tipo == "Juego" && dolares != 2 && dias != 4)
            {
                dias -= 4;
                fecha = fecha.AddDays(dias);
                dolares -= 2;
                dolaresC.Text = dolares.ToString();
                diasDecimal.Text = dias.ToString();
            }
            else if (tipo == "Película" && dolares != 2 && dias != 3)
            {
                dias -= 3;
                fecha = fecha.AddDays(dias);
                dolares -= 2;
                dolaresC.Text = dolares.ToString();
                diasDecimal.Text = dias.ToString();
            }
            else if (tipo == "MP3" && dolares != 2 && dias != 7)
            {
                dias -= 7;
                fecha = fecha.AddDays(dias);
                dolares -= 2;
                dolaresC.Text = dolares.ToString();
                diasDecimal.Text = dias.ToString();
            }
        }

        private void tituloBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarTitulo();
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
    }
}