
namespace PetFy
{
    partial class ucAnimal
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
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnimal
            // 
            this.pbAnimal.Image = global::PetFy.Properties.Resources.ppDoge;
            this.pbAnimal.Location = new System.Drawing.Point(14, 12);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(91, 92);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 0;
            this.pbAnimal.TabStop = false;
            this.pbAnimal.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAnimal_Paint);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNombre.Location = new System.Drawing.Point(19, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSexo.Location = new System.Drawing.Point(21, 170);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(59, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo: sexo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipo.Location = new System.Drawing.Point(21, 196);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo: tipo";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRaza.Location = new System.Drawing.Point(21, 146);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(58, 13);
            this.lblRaza.TabIndex = 5;
            this.lblRaza.Text = "Raza: raza";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloFecha.Location = new System.Drawing.Point(21, 216);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(94, 13);
            this.lblTituloFecha.TabIndex = 6;
            this.lblTituloFecha.Text = "Fecha de entrada:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(22, 235);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "01/01/21";
            // 
            // ucAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloFecha);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbAnimal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucAnimal";
            this.Size = new System.Drawing.Size(171, 274);
            this.Click += new System.EventHandler(this.ucAnimal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbAnimal;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblSexo;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.Label lblRaza;
        public System.Windows.Forms.Label lblTituloFecha;
        public System.Windows.Forms.Label lblFecha;
    }
}
