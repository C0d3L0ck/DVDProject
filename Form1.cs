using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace ProyectoIUJO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {     
            InitializeComponent();
            label1.Select();
            
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

 
        private void loginButton_Click(object sender, EventArgs e)
        {
           
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal(); 
            if(userBox.Text == "admin" || passBox.Text == "admin")
            {
                this.Hide();
                principal.ShowDialog();
                this.Dispose();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
