using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    //TODO   timer en titulo formulario, icono
    public delegate double Operation(double a, double b);
    public partial class Form1 : Form
    {

        private Dictionary<string, Operation> operaciones;
        double a;
        double b;
        int contador=56;

        public Form1()
        {
            InitializeComponent();
            timer1.Start(); 
            operaciones = new Dictionary<string, Operation>();
            operaciones.Add("+", (a, b) => a + b);
            operaciones.Add("-", (a, b) => a - b);
            operaciones.Add("*", (a, b) => a * b);
            operaciones.Add("/", (a, b) => a / b);
        }

        private void rdbOperacion_CheckedChanged(object sender, EventArgs e)
        {
            lblOperando.Text = ((RadioButton)sender).Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out a) && double.TryParse(txtNum2.Text, out b))
            {
                foreach (Control c in Controls)
                {
                    if (c is RadioButton)
                    {
                        foreach (KeyValuePair<string, Operation> operacion in operaciones)
                        {
                            if (lblOperando.Text == operacion.Key)
                            {

                                lblResultado.Text = "=" + operacion.Value(a, b);
                            }
                        }


                    }
                }

            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtNum1.Text, out int res))
            {
                txtNum1.BackColor = Color.White;

            }
            else
            {
                txtNum1.BackColor = Color.Red;
            }

            if (int.TryParse(txtNum2.Text, out int res2))
            {

                txtNum2.BackColor = Color.White;
            }
            else
            {
                txtNum2.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text =String.Format("{0:00} {1:00}", contador / 60, contador % 60) ;
            contador++;
        }
    }
}
