
namespace PetFy.Modulo_Historial_Clinico
{
    partial class frmAgregarHistorialClinico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarHistorialClinico));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.flpGestor = new System.Windows.Forms.FlowLayoutPanel();
            this.flpHistoriales = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetFy.Properties.Resources.pdf;
            this.pictureBox1.Location = new System.Drawing.Point(72, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(62, 260);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(114, 23);
            this.btnAdjuntar.TabIndex = 1;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(62, 315);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 37);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // flpGestor
            // 
            this.flpGestor.AutoScroll = true;
            this.flpGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.flpGestor.Location = new System.Drawing.Point(244, 318);
            this.flpGestor.Name = "flpGestor";
            this.flpGestor.Size = new System.Drawing.Size(346, 251);
            this.flpGestor.TabIndex = 3;
            // 
            // flpHistoriales
            // 
            this.flpHistoriales.AutoScroll = true;
            this.flpHistoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.flpHistoriales.Location = new System.Drawing.Point(250, 15);
            this.flpHistoriales.Name = "flpHistoriales";
            this.flpHistoriales.Size = new System.Drawing.Size(333, 253);
            this.flpHistoriales.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 289);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignar.Location = new System.Drawing.Point(371, 277);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(77, 29);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "v Asignar v";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // frmAgregarHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::PetFy.Properties.Resources.fondoHistorial;
            this.ClientSize = new System.Drawing.Size(608, 581);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.flpHistoriales);
            this.Controls.Add(this.flpGestor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarHistorialClinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Historial Clinico";
            this.Load += new System.EventHandler(this.frmAgregarHistorialClinico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.FlowLayoutPanel flpGestor;
        private System.Windows.Forms.FlowLayoutPanel flpHistoriales;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAsignar;
    }
}