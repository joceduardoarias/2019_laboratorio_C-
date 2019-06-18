namespace FrmTest
{
    partial class FormTest2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBoton = new System.Windows.Forms.Button();
            this.btnBoton2 = new System.Windows.Forms.Button();
            this.btnBoton3 = new System.Windows.Forms.Button();
            this.Operar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.Location = new System.Drawing.Point(399, 68);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(75, 23);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "button1";
            this.btnBoton.UseVisualStyleBackColor = true;
            // 
            // btnBoton2
            // 
            this.btnBoton2.Location = new System.Drawing.Point(399, 117);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(75, 23);
            this.btnBoton2.TabIndex = 1;
            this.btnBoton2.Text = "button2";
            this.btnBoton2.UseVisualStyleBackColor = true;
            // 
            // btnBoton3
            // 
            this.btnBoton3.Location = new System.Drawing.Point(399, 166);
            this.btnBoton3.Name = "btnBoton3";
            this.btnBoton3.Size = new System.Drawing.Size(75, 23);
            this.btnBoton3.TabIndex = 2;
            this.btnBoton3.Text = "button3";
            this.btnBoton3.UseVisualStyleBackColor = true;
            // 
            // Operar
            // 
            this.Operar.Location = new System.Drawing.Point(540, 127);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(75, 23);
            this.Operar.TabIndex = 3;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            this.Operar.Click += new System.EventHandler(this.Operar_Click);
            // 
            // FormTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.btnBoton3);
            this.Controls.Add(this.btnBoton2);
            this.Controls.Add(this.btnBoton);
            this.Name = "FormTest2";
            this.Text = "FormTest2";
            this.Load += new System.EventHandler(this.FormTest2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.Button btnBoton2;
        private System.Windows.Forms.Button btnBoton3;
        private System.Windows.Forms.Button Operar;
    }
}