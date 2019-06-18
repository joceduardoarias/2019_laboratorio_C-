namespace FrmTest
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
            this.MostrarMensaje = new System.Windows.Forms.Button();
            this.txtCuadroTexto = new System.Windows.Forms.TextBox();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MostrarMensaje
            // 
            this.MostrarMensaje.Location = new System.Drawing.Point(332, 180);
            this.MostrarMensaje.Name = "MostrarMensaje";
            this.MostrarMensaje.Size = new System.Drawing.Size(75, 23);
            this.MostrarMensaje.TabIndex = 0;
            this.MostrarMensaje.Text = "button1";
            this.MostrarMensaje.UseVisualStyleBackColor = true;
            //this.MostrarMensaje.Click += new System.EventHandler(this.MostrarMensaje_Click);
            // 
            // txtCuadroTexto
            // 
            this.txtCuadroTexto.Location = new System.Drawing.Point(321, 140);
            this.txtCuadroTexto.Name = "txtCuadroTexto";
            this.txtCuadroTexto.Size = new System.Drawing.Size(100, 20);
            this.txtCuadroTexto.TabIndex = 1;
            
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(348, 110);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(46, 13);
            this.lblEtiqueta.TabIndex = 2;
            this.lblEtiqueta.Text = "Etiqueta";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.txtCuadroTexto);
            this.Controls.Add(this.MostrarMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarMensaje;
        private System.Windows.Forms.TextBox txtCuadroTexto;
        private System.Windows.Forms.Label lblEtiqueta;
    }
}

