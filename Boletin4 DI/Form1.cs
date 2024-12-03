#define a
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin4_DI
{
    public partial class Form1 : Form// Coor en todos los botones.  Diferencia tecla de char. Funcion unica mousemove
    {
        public Form1()
        {
            int x = 0; int y = 0;
            for (int i = 1; i <= 20; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Location = new Point(x, y);
                button.Size = new System.Drawing.Size(40, 20);
                button.Enabled = true;
                button.Click += new System.EventHandler(this.buttonClick);
                button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
                this.Controls.Add(button);
                if ((i % 4) == 0)
                {
                    x = 0;
                    y += 40;

                }
                else
                {
                    x += 40;
                }
            }

            InitializeComponent();
            KeyPreview = true;


        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(sender is Button))
            {
                this.Text = "X: " + e.Location.X + "Y: " + e.Location.Y;

            }
            else
            {
                this.Text = "X: " + (((Control)sender).Location.X + e.Location.X) + "Y: " + (((Control)sender).Location.Y + e.Location.Y);
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

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.Text = "" + btn.Text;
        }


        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        //private void Form1_Click(object sender, EventArgs e)
        //{
        //    if (e.Equals(MouseButtons.Left))
        //    {
        //        button1.BackColor = Color.Green;
        //    }
        //    if (sender is MouseButtons.Right)
        //    {
        //        button2.BackColor = Color.Red;
        //    }
        //}

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button1.BackColor = Color.Green;
                }
                else
                {
                    button2.BackColor = Color.Red;
                }
            }
            else
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button1.BackColor = SystemColors.Control;
                }
                else
                {
                    button2.BackColor = SystemColors.Control;
                }
            }
            else
            {
                button1.BackColor = SystemColors.Control;
                button2.BackColor = SystemColors.Control;
            }
        }





        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if a
            if (e.KeyChar != (char)Keys.Escape)
            {

                this.Text = e.KeyChar.ToString();

            }
            else
            {
                this.Text = "Mouse Tester";
            }

#endif
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
#if !a
            this.Text = e.KeyValue.ToString();
#endif
        }


    }

}




