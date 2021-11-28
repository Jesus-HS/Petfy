
namespace PetFy
{
    partial class frmAgregarAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRaza = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.rbHembra = new System.Windows.Forms.RadioButton();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.rtCaracteristicas = new System.Windows.Forms.RichTextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Animales";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRaza);
            this.groupBox1.Controls.Add(this.lblRaza);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.rbHembra);
            this.groupBox1.Controls.Add(this.rbMacho);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Principal";
            // 
            // cbRaza
            // 
            this.cbRaza.FormattingEnabled = true;
            this.cbRaza.Location = new System.Drawing.Point(116, 77);
            this.cbRaza.Name = "cbRaza";
            this.cbRaza.Size = new System.Drawing.Size(126, 21);
            this.cbRaza.TabIndex = 12;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(15, 85);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(35, 13);
            this.lblRaza.TabIndex = 11;
            this.lblRaza.Text = "Raza:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(116, 47);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(126, 21);
            this.cbTipo.TabIndex = 10;
            // 
            // rbHembra
            // 
            this.rbHembra.AutoSize = true;
            this.rbHembra.Location = new System.Drawing.Point(180, 104);
            this.rbHembra.Name = "rbHembra";
            this.rbHembra.Size = new System.Drawing.Size(62, 17);
            this.rbHembra.TabIndex = 9;
            this.rbHembra.TabStop = true;
            this.rbHembra.Text = "Hembra";
            this.rbHembra.UseVisualStyleBackColor = true;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Location = new System.Drawing.Point(116, 104);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 8;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(15, 106);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Location = new System.Drawing.Point(12, 187);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(79, 13);
            this.lblCaracteristicas.TabIndex = 2;
            this.lblCaracteristicas.Text = "Caracteristicas:";
            // 
            // rtCaracteristicas
            // 
            this.rtCaracteristicas.Location = new System.Drawing.Point(97, 183);
            this.rtCaracteristicas.Name = "rtCaracteristicas";
            this.rtCaracteristicas.Size = new System.Drawing.Size(180, 94);
            this.rtCaracteristicas.TabIndex = 3;
            this.rtCaracteristicas.Text = "";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdAgregar.Location = new System.Drawing.Point(15, 297);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(262, 36);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = false;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // frmAgregarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(287, 340);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.rtCaracteristicas);
            this.Controls.Add(this.lblCaracteristicas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAgregarAnimal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRaza;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.RadioButton rbHembra;
        public System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCaracteristicas;
        public System.Windows.Forms.RichTextBox rtCaracteristicas;
        public System.Windows.Forms.Button cmdAgregar;
        public System.Windows.Forms.ComboBox cbRaza;
    }
}