using ProyectoIUJO.Formularios;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ProyectoIUJO
{
    public partial class DVDMenuForm : Form
    {
        public DVDMenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DVDMenuForm_Load(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(directorioBase, "Archivo.txt");
            FileInfo archivoInfo = new FileInfo(rutaArchivo);
            if (File.Exists(rutaArchivo) && archivoInfo.Length > 0)
            {
                LeerArchivo();
            }
                for (int i = 0; i < DVDColeccion.DVDs.Count; i++)  ////INICIOOOOOOOOOOO !! ///
                {
                    int n = dataGrid.Rows.Add();
                    dataGrid.Rows[i].Cells[0].Value = DVDColeccion.DVDs[i].Codigo.ToString();
                    dataGrid.Rows[i].Cells[1].Value = DVDColeccion.DVDs[i].Titulo.ToString();
                    dataGrid.Rows[i].Cells[2].Value = DVDColeccion.DVDs[i].fechaEmision.ToString();
                    dataGrid.Rows[i].Cells[3].Value = DVDColeccion.DVDs[i].Tipo.ToString();
                    dataGrid.Rows[i].Cells[4].Value = DVDColeccion.DVDs[i].Cantidad.ToString();
                    dataGrid.Rows[i].Cells[5].Value = DVDColeccion.DVDs[i].fechaIngreso.ToString();
                    dataGrid.Rows[i].Cells[6].Value = DVDColeccion.DVDs[i].Prestamo.ToString();
                    dataGrid.Rows[i].Cells[7].Value = DVDColeccion.DVDs[i].Imagen;
                    dataGrid.Rows[i].Cells[8].Value = DVDColeccion.DVDs[i].Descripcion.ToString();
                }

        }


        void Actualizar()
        {
            LeerArchivoSinGuardar();
            dataGrid.Rows.Clear();
            dataGrid.Rows.Add(DVDColeccion.DVDs.Count);

            for (int i = 0; i < DVDColeccion.DVDs.Count; i++)  ////ACTUALIZARRR ///
            {
                dataGrid.Rows[i].Cells[0].Value = DVDColeccion.DVDs[i].Codigo.ToString();
                dataGrid.Rows[i].Cells[1].Value = DVDColeccion.DVDs[i].Titulo.ToString();
                dataGrid.Rows[i].Cells[2].Value = DVDColeccion.DVDs[i].fechaEmision.ToString();
                dataGrid.Rows[i].Cells[3].Value = DVDColeccion.DVDs[i].Tipo.ToString();
                dataGrid.Rows[i].Cells[4].Value = DVDColeccion.DVDs[i].Cantidad.ToString();
                dataGrid.Rows[i].Cells[5].Value = DVDColeccion.DVDs[i].fechaIngreso.ToString();
                dataGrid.Rows[i].Cells[6].Value = DVDColeccion.DVDs[i].Prestamo.ToString();
                dataGrid.Rows[i].Cells[7].Value = DVDColeccion.DVDs[i].Imagen;
                dataGrid.Rows[i].Cells[8].Value = DVDColeccion.DVDs[i].Descripcion.ToString();
            }

        }

        DVDColeccion registrar = new DVDColeccion();
        bool P = false;
        private void registrarBtn_Click(object sender, EventArgs e)
        {
            
            if (prestamoYes.Checked)
            {
                P = true;
            }
            else
            {
                P = false;
            }

            string nuevaRuta = Path.Combine(directorioBase, nombreCarpeta, tituloText.Text + ".jpg");
            if (String.IsNullOrEmpty(tituloText.Text))
            {
                MessageBox.Show(string.Format("La barra de Título está vacia."));
            }
            else if (imgBtn.Image == null)
            {
                MessageBox.Show(string.Format("Falta ingresar una imagen"));
            }
            else if(File.Exists(nuevaRuta) && Path.GetFileNameWithoutExtension(nuevaRuta) == tituloText.Text)
            {
                MessageBox.Show(string.Format("Ya hay un Titulo con ese nombre con su respectiva Imagen"));
            }
            else
            {
                registrar.Registrar(codeText.Text, tituloText.Text, emisionDate.Value, tipoText.Text, Convert.ToInt32(cantidadText.Value), ingresoDate.Value, P, imgBtn.Image, descripcionText.Text);
                Datos();
                GuardarArchivo();
            }
        }

        void Datos()
        {
            dataGrid.Rows.Add();
            int index = dataGrid.Rows.Count - 1;
            foreach (var datos in DVDColeccion.DVDs)
            {
                dataGrid.Rows[index].Cells[0].Value = datos.Codigo.ToString();
                dataGrid.Rows[index].Cells[1].Value = datos.Titulo.ToString();
                dataGrid.Rows[index].Cells[2].Value = datos.fechaEmision.ToString();
                dataGrid.Rows[index].Cells[3].Value = datos.Tipo.ToString();
                dataGrid.Rows[index].Cells[4].Value = datos.Cantidad.ToString();
                dataGrid.Rows[index].Cells[5].Value = datos.fechaIngreso.ToString();
                dataGrid.Rows[index].Cells[6].Value = datos.Prestamo.ToString();
                dataGrid.Rows[index].Cells[7].Value = datos.Imagen;
                dataGrid.Rows[index].Cells[8].Value = datos.Descripcion.ToString();
            }
            
        }

        public void GuardarArchivo()
        {
            using (StreamWriter writer = new StreamWriter("Archivo.txt", false))
            {
                foreach (var datos in DVDColeccion.DVDs)
                {
                    writer.WriteLine($"{datos.Codigo};{datos.Titulo};{datos.fechaEmision};{datos.Tipo};{datos.Cantidad};{datos.fechaIngreso};{datos.Prestamo};{datos.Descripcion}");
                    string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
                    string nombreCarpeta = "Imagenes";
                    string nombreArchivo = datos.Titulo + ".jpg";
                    string nuevaRuta = Path.Combine(directorioBase, nombreCarpeta, nombreArchivo);
                        Directory.CreateDirectory(Path.GetDirectoryName(nuevaRuta));
                    if (datos.Imagen != null)
                    {
                        try
                        {
                            datos.Imagen.Save(nuevaRuta);
                        }
                        catch (Exception ex)
                        {
                        }
                    } 
                   
                }
            }
        }

        public string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
        public string nombreCarpeta = "Imagenes";

        public void LeerArchivo()
        {

            string rutaCarpeta = Path.Combine(directorioBase, nombreCarpeta);

            if (Directory.Exists(rutaCarpeta))
            {
                using (StreamReader reader = new StreamReader("Archivo.txt") )
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(';');

                            DVD dvd = new DVD();
                            dvd.Codigo = parts[0];
                            dvd.Titulo = parts[1];
                            dvd.fechaEmision = Convert.ToDateTime(parts[2]);
                            dvd.Tipo = parts[3];
                            dvd.Cantidad = Convert.ToInt32(parts[4]);
                            dvd.fechaIngreso = Convert.ToDateTime(parts[5]);
                            dvd.Prestamo = Convert.ToBoolean(parts[6]);
                            dvd.Descripcion = parts[7];
                            string nuevaRuta = Path.Combine(directorioBase, nombreCarpeta, dvd.Titulo + ".jpg");
                            if (File.Exists(nuevaRuta) && Path.GetFileNameWithoutExtension(nuevaRuta) == dvd.Titulo)
                            {
                                Bitmap nuevaImagen = new Bitmap(nuevaRuta);
                                dvd.Imagen = nuevaImagen;
                            }  
                            DVDColeccion.DVDs.Add(dvd);
                        
                    }
                }
            }
        }

        void LeerArchivoSinGuardar()
        {
            DVDColeccion.DVDs.Clear();
                using (StreamReader reader = new StreamReader("Archivo.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(';');

                        DVD dvd = new DVD();
                            dvd.Codigo = parts[0];
                            dvd.Titulo = parts[1];
                            dvd.fechaEmision = Convert.ToDateTime(parts[2]);
                            dvd.Tipo = parts[3];
                            dvd.Cantidad = Convert.ToInt32(parts[4]);
                            dvd.fechaIngreso = Convert.ToDateTime(parts[5]);
                            dvd.Prestamo = Convert.ToBoolean(parts[6]);
                            dvd.Descripcion = parts[7];
                            string nuevaRuta = Path.Combine(directorioBase, nombreCarpeta, dvd.Titulo + ".jpg");
                            if (File.Exists(nuevaRuta) && Path.GetFileNameWithoutExtension(nuevaRuta) == dvd.Titulo)
                            {
                                Bitmap nuevaImagen = new Bitmap(nuevaRuta);
                                dvd.Imagen = nuevaImagen;
                        DVDColeccion.DVDs.Add(dvd);
                    }
                 
                }
           }
            
        }

        private void prestamoYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imgBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif";
            openFileDialog1.Title = "Seleccionar una imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgBtn.Image = new Bitmap(openFileDialog1.FileName);
                imgBtn.Text = "";
            }
        }
        MostrarImagen mostrarImagen = new MostrarImagen();
        Consultar consulta = new Consultar();
        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (dataGrid.Rows[i].Cells[7].Selected == true)
                {
                    if (mostrarImagen == null || mostrarImagen.IsDisposed)
                    {
                        mostrarImagen = new MostrarImagen();
                    }
                    mostrarImagen.Show();
                    mostrarImagen.Mostrar((System.Drawing.Image)dataGrid.Rows[i].Cells[7].Value);

                }
            }
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (dataGrid.Rows[i].Cells[0].Selected == true)
                {
                    if (consulta == null || consulta.IsDisposed)
                    {
                        consulta = new Consultar();
                    }

                        consulta.Show();
                        consulta.Consultando($"Código: {dataGrid.Rows[i].Cells[0].Value.ToString()} \nTítulo: {dataGrid.Rows[i].Cells[1].Value.ToString()} \nFecha de emisión: {dataGrid.Rows[i].Cells[2].Value.ToString()} \nTipo: {dataGrid.Rows[i].Cells[3].Value.ToString()} \nCantidad: {dataGrid.Rows[i].Cells[4].Value.ToString()} \nIngreso: {dataGrid.Rows[i].Cells[5].Value.ToString()} \nPrestamo: {dataGrid.Rows[i].Cells[6].Value.ToString()} \nDescripción: {dataGrid.Rows[i].Cells[8].Value.ToString()}");
                   
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(directorioBase, "Archivo.txt");
            FileInfo archivoInfo = new FileInfo(rutaArchivo);
            if (File.Exists(rutaArchivo) && archivoInfo.Length > 0)
            {
                Actualizar();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                int rowIndex = dataGrid.SelectedCells[0].RowIndex;
                dataGrid.Rows.RemoveAt(rowIndex);
                DVDColeccion.DVDs.RemoveAt(rowIndex);
                using (StreamWriter writer = new StreamWriter("Archivo.txt", false))
                {
                    foreach (var datos in DVDColeccion.DVDs)
                    {
                        writer.WriteLine($"{datos.Codigo};{datos.Titulo};{datos.fechaEmision};{datos.Tipo};{datos.Cantidad};{datos.fechaIngreso};{datos.Prestamo};{datos.Descripcion}");
                    }
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
    }
}
