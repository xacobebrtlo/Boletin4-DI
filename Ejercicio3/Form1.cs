using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3 //TODO icono, tamaño inicial, tosdos los archivos, imagen no valida
{
    public partial class Form1 : Form
    {
        public string filePath = "";
        public Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {

            this.openFileDialog1.Title = "Selecciona una Imagen";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Xacobe\\Desktop\\fotos";
            this.openFileDialog1.Filter = "Todas las imagenes|*.png;*.jpg|PNG|*.png|JPG|*.jpg|Todos los archivos|*.*";





            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = this.openFileDialog1.FileName;
                string tituloForm = this.openFileDialog1.SafeFileName;

                f2 = new Form2(filePath, tituloForm);

                //PictureBox pictureBox1 = new PictureBox();
                //pictureBox1.Size = f2.Size;
                //pictureBox1.Image = System.Drawing.Image.FromFile(this.filePath);
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox1.Dock = DockStyle.Fill;
                //f2.Controls.Add(pictureBox1);
                //f2.Resize += new System.EventHandler(Form2_Resize);


                if (!chkModal.Checked)
                {
                    f2.Show();
                }
                else
                {
                    f2.ShowDialog();
                }
            }


        }


        private void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                chkModal.ForeColor = Color.Red;
            }
            else
            {
                chkModal.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
