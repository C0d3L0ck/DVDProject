using ProyectoIUJO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIUJO.Formularios
{
    public partial class IngresosMenu : Form
    {
        public IngresosMenu()
        {
            InitializeComponent();
        }

        private void cantidadBox_ValueChanged(object sender, EventArgs e)
        {

        }
        private void consultarBtn_Click_1(object sender, EventArgs e)
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

        private void IngresosMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PrestamosColeccion.prestamos.Count; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = PrestamosColeccion.prestamos[i].Monto;
                dataGrid.Rows[i].Cells[1].Value = PrestamosColeccion.prestamos[i].Fecha;

            }


        }   
        
        private void updateBtn_Click(object sender, EventArgs e)
        {
            int monto = 0;
            dataGrid.Rows.Clear();
            for (int i = 0; i < PrestamosColeccion.prestamos.Count; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = PrestamosColeccion.prestamos[i].Monto;
                dataGrid.Rows[i].Cells[1].Value = PrestamosColeccion.prestamos[i].Fecha;

            }

            for (int i = 0; i < PrestamosColeccion.prestamos.Count; i++)
            {
                monto += PrestamosColeccion.prestamos[i].Monto;
                ingresosLabel.Text = monto.ToString();
            }

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
    }
}
