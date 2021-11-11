
namespace PetFy
{
    partial class frmGestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestor));
            this.flpGestor = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGestorAnimales = new System.Windows.Forms.Button();
            this.btnGestorHistorialClinico = new System.Windows.Forms.Button();
            this.btnGestorPersonal = new System.Windows.Forms.Button();
            this.btnGestorAlmacen = new System.Windows.Forms.Button();
            this.btnGestorAdopciones = new System.Windows.Forms.Button();
            this.btnGestorUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpGestor
            // 
            this.flpGestor.AutoScroll = true;
            this.flpGestor.Location = new System.Drawing.Point(188, 72);
            this.flpGestor.Name = "flpGestor";
            this.flpGestor.Size = new System.Drawing.Size(586, 517);
            this.flpGestor.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(373, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(87, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo del modulo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(566, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 474);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGestorAnimales
            // 
            this.btnGestorAnimales.Location = new System.Drawing.Point(12, 72);
            this.btnGestorAnimales.Name = "btnGestorAnimales";
            this.btnGestorAnimales.Size = new System.Drawing.Size(170, 48);
            this.btnGestorAnimales.TabIndex = 7;
            this.btnGestorAnimales.Text = "Animales";
            this.btnGestorAnimales.UseVisualStyleBackColor = true;
            this.btnGestorAnimales.Click += new System.EventHandler(this.btnGestorAnimales_Click);
            // 
            // btnGestorHistorialClinico
            // 
            this.btnGestorHistorialClinico.Location = new System.Drawing.Point(12, 126);
            this.btnGestorHistorialClinico.Name = "btnGestorHistorialClinico";
            this.btnGestorHistorialClinico.Size = new System.Drawing.Size(170, 48);
            this.btnGestorHistorialClinico.TabIndex = 8;
            this.btnGestorHistorialClinico.Text = "Historial Clinico";
            this.btnGestorHistorialClinico.UseVisualStyleBackColor = true;
            this.btnGestorHistorialClinico.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnGestorPersonal
            // 
            this.btnGestorPersonal.Location = new System.Drawing.Point(12, 180);
            this.btnGestorPersonal.Name = "btnGestorPersonal";
            this.btnGestorPersonal.Size = new System.Drawing.Size(170, 48);
            this.btnGestorPersonal.TabIndex = 9;
            this.btnGestorPersonal.Text = "Personal";
            this.btnGestorPersonal.UseVisualStyleBackColor = true;
            this.btnGestorPersonal.Click += new System.EventHandler(this.btnPersonal_Click_1);
            // 
            // btnGestorAlmacen
            // 
            this.btnGestorAlmacen.Location = new System.Drawing.Point(12, 234);
            this.btnGestorAlmacen.Name = "btnGestorAlmacen";
            this.btnGestorAlmacen.Size = new System.Drawing.Size(170, 48);
            this.btnGestorAlmacen.TabIndex = 10;
            this.btnGestorAlmacen.Text = "Almacen";
            this.btnGestorAlmacen.UseVisualStyleBackColor = true;
            this.btnGestorAlmacen.Click += new System.EventHandler(this.btnGestorAlmacen_Click);
            // 
            // btnGestorAdopciones
            // 
            this.btnGestorAdopciones.Location = new System.Drawing.Point(12, 288);
            this.btnGestorAdopciones.Name = "btnGestorAdopciones";
            this.btnGestorAdopciones.Size = new System.Drawing.Size(170, 48);
            this.btnGestorAdopciones.TabIndex = 11;
            this.btnGestorAdopciones.Text = "Adopciones";
            this.btnGestorAdopciones.UseVisualStyleBackColor = true;
            this.btnGestorAdopciones.Click += new System.EventHandler(this.btnGestorAdopciones_Click);
            // 
            // btnGestorUsuarios
            // 
            this.btnGestorUsuarios.Location = new System.Drawing.Point(12, 342);
            this.btnGestorUsuarios.Name = "btnGestorUsuarios";
            this.btnGestorUsuarios.Size = new System.Drawing.Size(170, 48);
            this.btnGestorUsuarios.TabIndex = 12;
            this.btnGestorUsuarios.Text = "Usuarios";
            this.btnGestorUsuarios.UseVisualStyleBackColor = true;
            this.btnGestorUsuarios.Click += new System.EventHandler(this.btnRegistrousuarios_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(774, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 517);
            this.panel1.TabIndex = 0;
            // 
            // frmGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGestorUsuarios);
            this.Controls.Add(this.btnGestorAdopciones);
            this.Controls.Add(this.btnGestorAlmacen);
            this.Controls.Add(this.btnGestorPersonal);
            this.Controls.Add(this.btnGestorHistorialClinico);
            this.Controls.Add(this.btnGestorAnimales);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.flpGestor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestor";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(255)))), ((int)(((byte)(9)))));
            this.Load += new System.EventHandler(this.frmGestor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpGestor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGestorAnimales;
        private System.Windows.Forms.Button btnGestorHistorialClinico;
        private System.Windows.Forms.Button btnGestorPersonal;
        private System.Windows.Forms.Button btnGestorAlmacen;
        private System.Windows.Forms.Button btnGestorAdopciones;
        private System.Windows.Forms.Button btnGestorUsuarios;
        private System.Windows.Forms.Panel panel1;
    }
}