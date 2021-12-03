namespace PetFy.Modulo_Adopciones
{
    partial class ucAdopciones
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdoptante = new System.Windows.Forms.Label();
            this.lblAdoptado = new System.Windows.Forms.Label();
            this.lblIdAdoptante = new System.Windows.Forms.Label();
            this.lblIdAdoptado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdoptante
            // 
            this.lblAdoptante.AutoSize = true;
            this.lblAdoptante.Location = new System.Drawing.Point(47, 23);
            this.lblAdoptante.Name = "lblAdoptante";
            this.lblAdoptante.Size = new System.Drawing.Size(96, 13);
            this.lblAdoptante.TabIndex = 0;
            this.lblAdoptante.Text = "Nombre Adoptante";
            // 
            // lblAdoptado
            // 
            this.lblAdoptado.AutoSize = true;
            this.lblAdoptado.Location = new System.Drawing.Point(47, 54);
            this.lblAdoptado.Name = "lblAdoptado";
            this.lblAdoptado.Size = new System.Drawing.Size(93, 13);
            this.lblAdoptado.TabIndex = 1;
            this.lblAdoptado.Text = "Nombre Adoptado";
            // 
            // lblIdAdoptante
            // 
            this.lblIdAdoptante.AutoSize = true;
            this.lblIdAdoptante.Location = new System.Drawing.Point(28, 23);
            this.lblIdAdoptante.Name = "lblIdAdoptante";
            this.lblIdAdoptante.Size = new System.Drawing.Size(13, 13);
            this.lblIdAdoptante.TabIndex = 2;
            this.lblIdAdoptante.Text = "0";
            this.lblIdAdoptante.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdAdoptado
            // 
            this.lblIdAdoptado.AutoSize = true;
            this.lblIdAdoptado.Location = new System.Drawing.Point(28, 54);
            this.lblIdAdoptado.Name = "lblIdAdoptado";
            this.lblIdAdoptado.Size = new System.Drawing.Size(13, 13);
            this.lblIdAdoptado.TabIndex = 3;
            this.lblIdAdoptado.Text = "0";
            // 
            // ucAdopciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblIdAdoptado);
            this.Controls.Add(this.lblIdAdoptante);
            this.Controls.Add(this.lblAdoptado);
            this.Controls.Add(this.lblAdoptante);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucAdopciones";
            this.Size = new System.Drawing.Size(177, 97);
            this.Click += new System.EventHandler(this.ucAdopciones_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAdoptante;
        public System.Windows.Forms.Label lblAdoptado;
        public System.Windows.Forms.Label lblIdAdoptante;
        public System.Windows.Forms.Label lblIdAdoptado;
    }
}
