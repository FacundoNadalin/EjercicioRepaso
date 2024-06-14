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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(121, 72);
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
            this.lbpromedio.Location = new System.Drawing.Point(100, 46);
            this.lbpromedio.Name = "lbpromedio";
            this.lbpromedio.Size = new System.Drawing.Size(76, 20);
            this.lbpromedio.TabIndex = 1;
            this.lbpromedio.Text = "Promedio";
            this.lbpromedio.Click += new System.EventHandler(this.lbpromedio_Click);
            // 
            // btpromedio
            // 
            this.btpromedio.Location = new System.Drawing.Point(6, 34);
            this.btpromedio.Name = "btpromedio";
            this.btpromedio.Size = new System.Drawing.Size(75, 47);
            this.btpromedio.TabIndex = 2;
            this.btpromedio.Text = "Calcular";
            this.btpromedio.UseVisualStyleBackColor = true;
            this.btpromedio.Click += new System.EventHandler(this.btpromedio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btpromedio);
            this.groupBox1.Controls.Add(this.lbpromedio);
            this.groupBox1.Location = new System.Drawing.Point(121, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promedio";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrarAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Label lbpromedio;
        private System.Windows.Forms.Button btpromedio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

