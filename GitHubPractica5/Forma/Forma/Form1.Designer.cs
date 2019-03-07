namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota";
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(397, 54);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(100, 20);
            this.aluNota.TabIndex = 3;
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(163, 57);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(100, 20);
            this.aluNombre.TabIndex = 4;
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(92, 215);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(420, 122);
            this.listaAlumnos.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(616, 375);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.aluNombre);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aluNota;
        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.TextBox listaAlumnos;
    }
}

