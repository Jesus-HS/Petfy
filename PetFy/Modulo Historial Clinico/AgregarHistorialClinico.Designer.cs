
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.flpGestor = new System.Windows.Forms.FlowLayoutPanel();
            this.flpHistoriales = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetFy.Properties.Resources.pdf;
            this.pictureBox1.Location = new System.Drawing.Point(36, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(34, 182);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(114, 23);
            this.btnAdjuntar.TabIndex = 1;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(183, 548);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // flpGestor
            // 
            this.flpGestor.AutoScroll = true;
            this.flpGestor.Location = new System.Drawing.Point(12, 289);
            this.flpGestor.Name = "flpGestor";
            this.flpGestor.Size = new System.Drawing.Size(469, 253);
            this.flpGestor.TabIndex = 3;
            // 
            // flpHistoriales
            // 
            this.flpHistoriales.AutoScroll = true;
            this.flpHistoriales.Location = new System.Drawing.Point(183, 12);
            this.flpHistoriales.Name = "flpHistoriales";
            this.flpHistoriales.Size = new System.Drawing.Size(298, 253);
            this.flpHistoriales.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 211);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // frmAgregarHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 583);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.flpHistoriales);
            this.Controls.Add(this.flpGestor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAgregarHistorialClinico";
            this.Text = "AgregarHistorialClinico";
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
        private System.Windows.Forms.TextBox txtNombre;
    }
}