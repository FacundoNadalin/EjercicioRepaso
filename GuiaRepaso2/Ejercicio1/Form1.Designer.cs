namespace Ejercicio_1
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
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.lbpromedio = new System.Windows.Forms.Label();
            this.btpromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(186, 93);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(111, 23);
            this.btnRegistrarAlumno.TabIndex = 0;
            this.btnRegistrarAlumno.Text = "RegistrarAlumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // lbpromedio
            // 
            this.lbpromedio.AutoSize = true;
            this.lbpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpromedio.Location = new System.Drawing.Point(262, 171);
            this.lbpromedio.Name = "lbpromedio";
            this.lbpromedio.Size = new System.Drawing.Size(76, 20);
            this.lbpromedio.TabIndex = 1;
            this.lbpromedio.Text = "Promedio";
            // 
            // btpromedio
            // 
            this.btpromedio.Location = new System.Drawing.Point(162, 159);
            this.btpromedio.Name = "btpromedio";
            this.btpromedio.Size = new System.Drawing.Size(75, 47);
            this.btpromedio.TabIndex = 2;
            this.btpromedio.Text = "Calcular";
            this.btpromedio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 255);
            this.Controls.Add(this.btpromedio);
            this.Controls.Add(this.lbpromedio);
            this.Controls.Add(this.btnRegistrarAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Label lbpromedio;
        private System.Windows.Forms.Button btpromedio;
    }
}

