using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public Form2(String ruta, String titulo)
        {
            InitializeComponent();
            Image imagen = System.Drawing.Image.FromFile(ruta);
            pictureBox1.Image = imagen;
            this.Size = pictureBox1.Size;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;
            this.Controls.Add(pictureBox1);
            this.Text = titulo;
        }
    }
}
