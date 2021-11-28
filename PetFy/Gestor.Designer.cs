
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGestorAnimales = new System.Windows.Forms.Button();
            this.btnGestorHistorialClinico = new System.Windows.Forms.Button();
            this.btnGestorPersonal = new System.Windows.Forms.Button();
            this.btnGestorAlmacen = new System.Windows.Forms.Button();
            this.btnGestorAdopciones = new System.Windows.Forms.Button();
            this.btnGestorUsuarios = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDonaciones = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGestorDependencias = new System.Windows.Forms.Button();
            this.lblCerrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpGestor
            // 
            this.flpGestor.AutoScroll = true;
            this.flpGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.flpGestor.Location = new System.Drawing.Point(206, 111);
            this.flpGestor.Name = "flpGestor";
            this.flpGestor.Size = new System.Drawing.Size(563, 504);
            this.flpGestor.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Location = new System.Drawing.Point(352, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 17);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo del modulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(204, 68);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 14);
            this.txtBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::PetFy.Properties.Resources.iconoLupa;
            this.btnBuscar.Location = new System.Drawing.Point(411, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 38);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::PetFy.Properties.Resources.iconoAgregarr;
            this.btnAgregar.Location = new System.Drawing.Point(786, 575);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGestorAnimales
            // 
            this.btnGestorAnimales.BackColor = System.Drawing.Color.White;
            this.btnGestorAnimales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestorAnimales.FlatAppearance.BorderSize = 0;
            this.btnGestorAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorAnimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorAnimales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnGestorAnimales.Image = ((System.Drawing.Image)(resources.GetObject("btnGestorAnimales.Image")));
            this.btnGestorAnimales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorAnimales.Location = new System.Drawing.Point(23, 145);
            this.btnGestorAnimales.Name = "btnGestorAnimales";
            this.btnGestorAnimales.Size = new System.Drawing.Size(145, 28);
            this.btnGestorAnimales.TabIndex = 7;
            this.btnGestorAnimales.Text = "      Animales";
            this.btnGestorAnimales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorAnimales.UseVisualStyleBackColor = false;
            this.btnGestorAnimales.Click += new System.EventHandler(this.btnGestorAnimales_Click);
            // 
            // btnGestorHistorialClinico
            // 
            this.btnGestorHistorialClinico.BackColor = System.Drawing.Color.White;
            this.btnGestorHistorialClinico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestorHistorialClinico.FlatAppearance.BorderSize = 0;
            this.btnGestorHistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorHistorialClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorHistorialClinico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnGestorHistorialClinico.Image = global::PetFy.Properties.Resources.historialInactivo;
            this.btnGestorHistorialClinico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorHistorialClinico.Location = new System.Drawing.Point(23, 179);
            this.btnGestorHistorialClinico.Name = "btnGestorHistorialClinico";
            this.btnGestorHistorialClinico.Size = new System.Drawing.Size(145, 28);
            this.btnGestorHistorialClinico.TabIndex = 8;
            this.btnGestorHistorialClinico.Text = "      Historial Clinico";
            this.btnGestorHistorialClinico.UseVisualStyleBackColor = false;
            this.btnGestorHistorialClinico.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnGestorPersonal
            // 
            this.btnGestorPersonal.BackColor = System.Drawing.Color.White;
            this.btnGestorPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestorPersonal.FlatAppearance.BorderSize = 0;
            this.btnGestorPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnGestorPersonal.Image = global::PetFy.Properties.Resources.personalInactivo;
            this.btnGestorPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorPersonal.Location = new System.Drawing.Point(23, 213);
            this.btnGestorPersonal.Name = "btnGestorPersonal";
            this.btnGestorPersonal.Size = new System.Drawing.Size(145, 28);
            this.btnGestorPersonal.TabIndex = 9;
            this.btnGestorPersonal.Text = "      Personal";
            this.btnGestorPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorPersonal.UseVisualStyleBackColor = false;
            this.btnGestorPersonal.Click += new System.EventHandler(this.btnPersonal_Click_1);
            // 
            // btnGestorAlmacen
            // 
            this.btnGestorAlmacen.BackColor = System.Drawing.Color.White;
            this.btnGestorAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestorAlmacen.FlatAppearance.BorderSize = 0;
            this.btnGestorAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnGestorAlmacen.Image = global::PetFy.Properties.Resources.almacenInactivo;
            this.btnGestorAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorAlmacen.Location = new System.Drawing.Point(23, 247);
            this.btnGestorAlmacen.Name = "btnGestorAlmacen";
            this.btnGestorAlmacen.Size = new System.Drawing.Size(145, 28);
            this.btnGestorAlmacen.TabIndex = 10;
            this.btnGestorAlmacen.Text = "      Almacen";
            this.btnGestorAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorAlmacen.UseVisualStyleBackColor = false;
            this.btnGestorAlmacen.Click += new System.EventHandler(this.btnGestorAlmacen_Click);
            // 
            // btnGestorAdopciones
            // 
            this.btnGestorAdopciones.BackColor = System.Drawing.Color.White;
            this.btnGestorAdopciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestorAdopciones.FlatAppearance.BorderSize = 0;
            this.btnGestorAdopciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorAdopciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorAdopciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnGestorAdopciones.Image = global::PetFy.Properties.Resources.adopcionesInactivo1;
            this.btnGestorAdopciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorAdopciones.Location = new System.Drawing.Point(23, 281);
            this.btnGestorAdopciones.Name = "btnGestorAdopciones";
            this.btnGestorAdopciones.Size = new System.Drawing.Size(145, 28);
            this.btnGestorAdopciones.TabIndex = 11;
            this.btnGestorAdopciones.Text = "      Adopciones";
            this.btnGestorAdopciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorAdopciones.UseVisualStyleBackColor = false;
            this.btnGestorAdopciones.Click += new System.EventHandler(this.btnGestorAdopciones_Click);
            // 
            // btnGestorUsuarios
            // 
            this.btnGestorUsuarios.BackColor = System.Drawing.Color.White;
            this.btnGestorUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestorUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestorUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnGestorUsuarios.Image = global::PetFy.Properties.Resources.usuarioInactivo1;
            this.btnGestorUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorUsuarios.Location = new System.Drawing.Point(23, 315);
            this.btnGestorUsuarios.Name = "btnGestorUsuarios";
            this.btnGestorUsuarios.Size = new System.Drawing.Size(145, 28);
            this.btnGestorUsuarios.TabIndex = 12;
            this.btnGestorUsuarios.Text = "      Usuarios";
            this.btnGestorUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorUsuarios.UseVisualStyleBackColor = false;
            this.btnGestorUsuarios.Click += new System.EventHandler(this.btnRegistrousuarios_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(786, 461);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(40, 40);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(786, 507);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDonaciones
            // 
            this.btnDonaciones.Location = new System.Drawing.Point(37, 579);
            this.btnDonaciones.Name = "btnDonaciones";
            this.btnDonaciones.Size = new System.Drawing.Size(126, 33);
            this.btnDonaciones.TabIndex = 13;
            this.btnDonaciones.Text = "Donaciones";
            this.btnDonaciones.UseVisualStyleBackColor = true;
            this.btnDonaciones.Click += new System.EventHandler(this.btnDonaciones_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PetFy.Properties.Resources.Petfy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnGestorDependencias
            // 
            this.btnGestorDependencias.BackColor = System.Drawing.Color.White;
            this.btnGestorDependencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestorDependencias.FlatAppearance.BorderSize = 0;
            this.btnGestorDependencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorDependencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorDependencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnGestorDependencias.Image = global::PetFy.Properties.Resources.dependenciaInactiva1;
            this.btnGestorDependencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorDependencias.Location = new System.Drawing.Point(23, 349);
            this.btnGestorDependencias.Name = "btnGestorDependencias";
            this.btnGestorDependencias.Size = new System.Drawing.Size(145, 28);
            this.btnGestorDependencias.TabIndex = 15;
            this.btnGestorDependencias.Text = "      Dependencias";
            this.btnGestorDependencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorDependencias.UseVisualStyleBackColor = false;
            this.btnGestorDependencias.Click += new System.EventHandler(this.btnDependencias_Click);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblCerrar.Location = new System.Drawing.Point(813, 12);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(13, 16);
            this.lblCerrar.TabIndex = 16;
            this.lblCerrar.Text = "x";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // frmGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetFy.Properties.Resources.fondoPrograma;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(842, 640);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGestorDependencias);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDonaciones);
            this.Controls.Add(this.btnGestorUsuarios);
            this.Controls.Add(this.btnGestorAdopciones);
            this.Controls.Add(this.btnGestorAlmacen);
            this.Controls.Add(this.btnGestorPersonal);
            this.Controls.Add(this.btnGestorHistorialClinico);
            this.Controls.Add(this.btnGestorAnimales);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.flpGestor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.frmGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpGestor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGestorAnimales;
        private System.Windows.Forms.Button btnGestorHistorialClinico;
        private System.Windows.Forms.Button btnGestorPersonal;
        private System.Windows.Forms.Button btnGestorAlmacen;
        private System.Windows.Forms.Button btnGestorAdopciones;
        private System.Windows.Forms.Button btnGestorUsuarios;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDonaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGestorDependencias;
        private System.Windows.Forms.Label lblCerrar;
    }
}