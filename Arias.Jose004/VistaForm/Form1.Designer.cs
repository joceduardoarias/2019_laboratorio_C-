namespace VistaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2Apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1Edad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Dni = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3Experiencia = new System.Windows.Forms.NumericUpDown();
            this.Crear = new System.Windows.Forms.Button();
            this.Validar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3Experiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBox1Nombre
            // 
            this.textBox1Nombre.Location = new System.Drawing.Point(298, 73);
            this.textBox1Nombre.Name = "textBox1Nombre";
            this.textBox1Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox1Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textBox2Apellido
            // 
            this.textBox2Apellido.Location = new System.Drawing.Point(298, 102);
            this.textBox2Apellido.Name = "textBox2Apellido";
            this.textBox2Apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox2Apellido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Edad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DNI";
            // 
            // numericUpDown1Edad
            // 
            this.numericUpDown1Edad.Location = new System.Drawing.Point(298, 138);
            this.numericUpDown1Edad.Name = "numericUpDown1Edad";
            this.numericUpDown1Edad.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown1Edad.TabIndex = 8;
            // 
            // numericUpDown2Dni
            // 
            this.numericUpDown2Dni.Location = new System.Drawing.Point(298, 164);
            this.numericUpDown2Dni.Name = "numericUpDown2Dni";
            this.numericUpDown2Dni.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2Dni.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Experiencia";
            // 
            // numericUpDown3Experiencia
            // 
            this.numericUpDown3Experiencia.Location = new System.Drawing.Point(298, 198);
            this.numericUpDown3Experiencia.Name = "numericUpDown3Experiencia";
            this.numericUpDown3Experiencia.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown3Experiencia.TabIndex = 11;
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(230, 259);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 23);
            this.Crear.TabIndex = 12;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Validar
            // 
            this.Validar.Location = new System.Drawing.Point(378, 259);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(75, 23);
            this.Validar.TabIndex = 13;
            this.Validar.Text = "Validar";
            this.Validar.UseVisualStyleBackColor = true;
            this.Validar.Click += new System.EventHandler(this.Validar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Validar);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.numericUpDown3Experiencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2Dni);
            this.Controls.Add(this.numericUpDown1Edad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormDT";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3Experiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2Apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1Edad;
        private System.Windows.Forms.NumericUpDown numericUpDown2Dni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3Experiencia;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Validar;
    }
}

