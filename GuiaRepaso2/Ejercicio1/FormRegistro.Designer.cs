namespace Ejercicio_1
{
    partial class FormRegistro
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
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbnota = new System.Windows.Forms.TextBox();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbdni = new System.Windows.Forms.Label();
            this.lbnota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbnombre
            // 
            this.tbnombre.AccessibleName = "";
            this.tbnombre.Location = new System.Drawing.Point(130, 60);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 0;
            // 
            // tbnota
            // 
            this.tbnota.AccessibleName = "";
            this.tbnota.Location = new System.Drawing.Point(130, 180);
            this.tbnota.Name = "tbnota";
            this.tbnota.Size = new System.Drawing.Size(100, 20);
            this.tbnota.TabIndex = 1;
            // 
            // tbdni
            // 
            this.tbdni.AccessibleName = "tbdni";
            this.tbdni.Location = new System.Drawing.Point(130, 119);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(100, 20);
            this.tbdni.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleName = "";
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(141, 242);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbnombre
            // 
            this.lbnombre.AccessibleName = "";
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(59, 60);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(65, 20);
            this.lbnombre.TabIndex = 4;
            this.lbnombre.Text = "Nombre";
            // 
            // lbdni
            // 
            this.lbdni.AccessibleName = "";
            this.lbdni.AutoSize = true;
            this.lbdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdni.Location = new System.Drawing.Point(65, 119);
            this.lbdni.Name = "lbdni";
            this.lbdni.Size = new System.Drawing.Size(37, 20);
            this.lbdni.TabIndex = 5;
            this.lbdni.Text = "DNI";
            // 
            // lbnota
            // 
            this.lbnota.AccessibleName = "";
            this.lbnota.AutoSize = true;
            this.lbnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnota.Location = new System.Drawing.Point(65, 180);
            this.lbnota.Name = "lbnota";
            this.lbnota.Size = new System.Drawing.Size(43, 20);
            this.lbnota.TabIndex = 6;
            this.lbnota.Text = "Nota";
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 306);
            this.Controls.Add(this.lbnota);
            this.Controls.Add(this.lbdni);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbdni);
            this.Controls.Add(this.tbnota);
            this.Controls.Add(this.tbnombre);
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbdni;
        private System.Windows.Forms.Label lbnota;
        public System.Windows.Forms.TextBox tbnombre;
        public System.Windows.Forms.TextBox tbnota;
        public System.Windows.Forms.TextBox tbdni;
    }
}