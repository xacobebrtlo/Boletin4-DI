namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbSuma = new System.Windows.Forms.RadioButton();
            this.radbResta = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rdbDivision = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblOperando = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(46, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(33, 20);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(104, 12);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(33, 20);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Checked = true;
            this.rdbSuma.Location = new System.Drawing.Point(14, 50);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new System.Drawing.Size(31, 17);
            this.rdbSuma.TabIndex = 3;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "+";
            this.rdbSuma.UseVisualStyleBackColor = true;
            this.rdbSuma.CheckedChanged += new System.EventHandler(this.rdbOperacion_CheckedChanged);
            // 
            // radbResta
            // 
            this.radbResta.AutoSize = true;
            this.radbResta.Location = new System.Drawing.Point(14, 74);
            this.radbResta.Name = "radbResta";
            this.radbResta.Size = new System.Drawing.Size(28, 17);
            this.radbResta.TabIndex = 4;
            this.radbResta.Text = "-";
            this.radbResta.UseVisualStyleBackColor = true;
            this.radbResta.CheckedChanged += new System.EventHandler(this.rdbOperacion_CheckedChanged);
            // 
            // rdbMultiplicacion
            // 
            this.rdbMultiplicacion.AutoSize = true;
            this.rdbMultiplicacion.Location = new System.Drawing.Point(14, 97);
            this.rdbMultiplicacion.Name = "rdbMultiplicacion";
            this.rdbMultiplicacion.Size = new System.Drawing.Size(29, 17);
            this.rdbMultiplicacion.TabIndex = 5;
            this.rdbMultiplicacion.Text = "*";
            this.rdbMultiplicacion.UseVisualStyleBackColor = true;
            this.rdbMultiplicacion.CheckedChanged += new System.EventHandler(this.rdbOperacion_CheckedChanged);
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Location = new System.Drawing.Point(14, 120);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new System.Drawing.Size(30, 17);
            this.rdbDivision.TabIndex = 6;
            this.rdbDivision.Text = "/";
            this.rdbDivision.UseVisualStyleBackColor = true;
            this.rdbDivision.CheckedChanged += new System.EventHandler(this.rdbOperacion_CheckedChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(143, 15);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "=";
            // 
            // lblOperando
            // 
            this.lblOperando.AutoSize = true;
            this.lblOperando.Location = new System.Drawing.Point(85, 15);
            this.lblOperando.Name = "lblOperando";
            this.lblOperando.Size = new System.Drawing.Size(13, 13);
            this.lblOperando.TabIndex = 8;
            this.lblOperando.Text = "+";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 174);
            this.Controls.Add(this.lblOperando);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rdbDivision);
            this.Controls.Add(this.rdbMultiplicacion);
            this.Controls.Add(this.radbResta);
            this.Controls.Add(this.rdbSuma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minutos:0 Segundos:0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbSuma;
        private System.Windows.Forms.RadioButton radbResta;
        private System.Windows.Forms.RadioButton rdbMultiplicacion;
        private System.Windows.Forms.RadioButton rdbDivision;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblOperando;
        private System.Windows.Forms.Timer timer1;
    }
}

