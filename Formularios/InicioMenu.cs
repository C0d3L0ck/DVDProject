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

namespace ProyectoIUJO
{
    public partial class InicioMenu : Form
    {
        public InicioMenu()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        bool pbool = false;
        SoundPlayer musica = new SoundPlayer("C:\\Users\\ELIAS\\source\\repos\\ProyectoIUJO\\ProyectoIUJO\\ProyectoIUJO\\IMG\\hola.wav");
        private void playBtn_Click(object sender, EventArgs e)
        {
            if (pbool == false)
            {
                musica.Play();
                pbool = true;
            }
            else
            {
                musica.Stop();
                pbool = false;
            }
        }

        private void InicioMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
