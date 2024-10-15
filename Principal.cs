using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoIUJO.Formularios;
using ProyectoIUJO.Clases;

namespace ProyectoIUJO
{
    public partial class Principal : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );

        static bool gerente = true;


        public Principal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            InicioMenu Iniciomenu = new InicioMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Iniciomenu.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Iniciomenu);
            Iniciomenu.Show();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Principal_Load(object sender, EventArgs e)
        {
            lblTittle.ForeColor = Color.FromArgb(158, 161, 176);

            if(gerente == true)
            {
                btnIngresos.Hide();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDVD_Click(object sender, EventArgs e)
        {
        }
        
        
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);


            lblTittle.Text = "Inicio";
            this.PnlFormLoader.Controls.Clear();
            InicioMenu Iniciomenu = new InicioMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Iniciomenu.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Iniciomenu);
            Iniciomenu.Show();
           
            

        }
        DVDMenuForm DVDMenu = new DVDMenuForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void btnDVD_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDVD.Height;
            PnlNav.Top = btnDVD.Top;
            PnlNav.Left = btnDVD.Left;
            btnDVD.BackColor = Color.FromArgb(46, 51, 73);

            lblTittle.Text = "DVD Menu";
            this.PnlFormLoader.Controls.Clear();
            DVDMenu.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(DVDMenu);
            DVDMenu.Show();
          


        }
        ClientesForm ClientesMenu = new ClientesForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void btnClientes_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnClientes.Height;
            PnlNav.Top = btnClientes.Top;
            PnlNav.Left = btnClientes.Left;
            btnClientes.BackColor = Color.FromArgb(46, 51, 73);

            lblTittle.Text = "Clientes";
            this.PnlFormLoader.Controls.Clear();
            
            ClientesMenu.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(ClientesMenu);
            ClientesMenu.Show();
           
        }
        PrestamosMenu Prestamosform = new PrestamosMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnPrestamos.Height;
            PnlNav.Top = btnPrestamos.Top;
            PnlNav.Left = btnPrestamos.Left;
            btnPrestamos.BackColor = Color.FromArgb(46, 51, 73);

            lblTittle.Text = "Prestamos";
            this.PnlFormLoader.Controls.Clear();
           
            Prestamosform.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Prestamosform);
            Prestamosform.Show();
           
        }
        IngresosMenu Ingresosmenu = new IngresosMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnIngresos.Height;
            PnlNav.Top = btnIngresos.Top;
            PnlNav.Left = btnIngresos.Left;
            btnIngresos.BackColor = Color.FromArgb(46, 51, 73);

            lblTittle.Text = "Ingresos";
            this.PnlFormLoader.Controls.Clear();
           
            Ingresosmenu.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Ingresosmenu);
            Ingresosmenu.Show();
        
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDVD_Leave(object sender, EventArgs e)
        {
            btnDVD.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClientes_Leave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPrestamos_Leave(object sender, EventArgs e)
        {
            btnPrestamos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnIngresos_Leave(object sender, EventArgs e)
        {
            btnIngresos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnTools.Height;
            PnlNav.Top = btnTools.Top;
            PnlNav.Left = btnTools.Left;
            btnTools.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnTools_Leave(object sender, EventArgs e)
        {
            btnTools.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
