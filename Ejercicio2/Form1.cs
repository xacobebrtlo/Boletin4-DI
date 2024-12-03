using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ejercicio2
{
    //TODO
    public partial class Form1 : Form//Etiquetas textbox.  Exce. imagen.      Revisar orden de tab.  Revisar rangos de colores  y excepcion.             
    {//No aparece en tskbar. Titulo.
        public Form1()
        {
            InitializeComponent();


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
        private void button1_Click(object sender, EventArgs e)
        {



            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;
            int.TryParse(textBox1.Text, out n1);
            int.TryParse(textBox2.Text, out n2);
            int.TryParse(textBox3.Text, out n3);
            if ((n1 >= 0 && n1 <= 255) && (n2 >= 0 && n2 <= 255) && (n3 >= 0 && n3 <= 255))
            {
                this.BackColor = Color.FromArgb(n1, n2, n3);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                txbImagen.ForeColor = Color.Black;
               
                lblImagen.Size = new Size(200, 200);
                lblImagen.Visible = true;
                lblImagen.Image = Image.FromFile(txbImagen.Text);
            }
            catch (FileNotFoundException ex)
            {
                txbImagen.ForeColor = Color.Red;
                txbImagen.Text = "No se encuentra la imágen"; 
            }


        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }
        private void txbImagen_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = button3;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {

                if (!(Controls[i] is Button))
                {
                    this.BackColor = Color.WhiteSmoke;
                    Controls[i].ResetText();
                }
                if (Controls[i] is Label)
                {
                    ((Label)Controls[i]).Image = default;//mejor fuera de bucle
                }

            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

            {
                ((Button)sender).BackColor = Color.LightBlue;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

            {
                ((Button)sender).BackColor = Color.Gainsboro;
            }
        }
    }
}
