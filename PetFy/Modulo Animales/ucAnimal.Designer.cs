
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtAdicional = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNombre.Location = new System.Drawing.Point(26, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipo.Location = new System.Drawing.Point(71, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(24, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "tipo";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRaza.Location = new System.Drawing.Point(71, 64);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(27, 13);
            this.lblRaza.TabIndex = 5;
            this.lblRaza.Text = "raza";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloFecha.Location = new System.Drawing.Point(113, 64);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(55, 13);
            this.lblTituloFecha.TabIndex = 6;
            this.lblTituloFecha.Text = "Entrada:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(166, 66);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "01/01/21";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(222, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Información Adicional";
            // 
            // rtAdicional
            // 
            this.rtAdicional.BackColor = System.Drawing.Color.White;
            this.rtAdicional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtAdicional.Location = new System.Drawing.Point(225, 40);
            this.rtAdicional.Name = "rtAdicional";
            this.rtAdicional.ReadOnly = true;
            this.rtAdicional.Size = new System.Drawing.Size(276, 39);
            this.rtAdicional.TabIndex = 9;
            this.rtAdicional.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(29, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Raza:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSexo.Location = new System.Drawing.Point(153, 40);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(29, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(113, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sexo:";
            // 
            // ucAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PetFy.Properties.Resources.PerfilPerro;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtAdicional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloFecha);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNombre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucAnimal";
            this.Size = new System.Drawing.Size(520, 95);
            this.Click += new System.EventHandler(this.ucAnimal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.Label lblRaza;
        public System.Windows.Forms.Label lblTituloFecha;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox rtAdicional;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblSexo;
        public System.Windows.Forms.Label label4;
    }
}
