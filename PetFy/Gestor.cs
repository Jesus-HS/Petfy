using PetFy.Modulo_Almacen;
using PetFy.Modulo_Historial_Clinico;
using PetFy.Modulo_Personal;
using PetFy.Modulo_Usuarios;
using PetFy.Modulo_Adopciones;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PetFy
{
    public partial class frmGestor : Form
    {
        static public string idUsuario = String.Empty;
        static public string idElemento = String.Empty;
        static public string idElementoSecundario = String.Empty;
        Consultas consulta = new Consultas();
        DataTable dt;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public frmGestor(string id)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            idUsuario = id;
        }
        private void frmGestor_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Animales";
            btnGestorAnimales.Image = Properties.Resources.huellaActiva;
            btnGestorAnimales.ForeColor = Color.FromArgb(123, 44, 191);
            imprimirAnimales("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo; ");
        }

        #region Botones del menu
        private void btnGestorAnimales_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Animales";
            btnGestorAnimales.Image = Properties.Resources.huellaActiva;
            btnGestorHistorialClinico.Image = Properties.Resources.historialInactivo;
            btnGestorPersonal.Image = Properties.Resources.personalInactivo;
            btnGestorAlmacen.Image = Properties.Resources.almacenInactivo;
            btnGestorAdopciones.Image = Properties.Resources.adopcionesInactivo;
            btnGestorUsuarios.Image = Properties.Resources.usuarioInactivo;
            btnGestorDependencias.Image = Properties.Resources.dependenciaInactiva;

            btnGestorAnimales.ForeColor = Color.FromArgb(123, 44, 191);
            btnGestorHistorialClinico.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorPersonal.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorAlmacen.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorAdopciones.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorUsuarios.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorDependencias.ForeColor = Color.FromArgb(212, 212, 212);
            imprimirAnimales("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo; ");
            
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor del Historial Clinico";

            btnGestorAnimales.Image = Properties.Resources.huellaInactiva;
            btnGestorHistorialClinico.Image = Properties.Resources.historialActivo;
            btnGestorPersonal.Image = Properties.Resources.personalInactivo;
            btnGestorAlmacen.Image = Properties.Resources.almacenInactivo;
            btnGestorAdopciones.Image = Properties.Resources.adopcionesInactivo;
            btnGestorUsuarios.Image = Properties.Resources.usuarioInactivo;
            btnGestorDependencias.Image = Properties.Resources.dependenciaInactiva;

            btnGestorAnimales.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorHistorialClinico.ForeColor = Color.FromArgb(123, 44, 191);
            btnGestorPersonal.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorAlmacen.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorAdopciones.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorUsuarios.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorDependencias.ForeColor = Color.FromArgb(212, 212, 212);
            imprimirAnimales("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo, historial.contenidoHistorial FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo JOIN historial ON historial.idHistorial = animales.idHistorial");
        }
        private void btnPersonal_Click_1(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Voluntarios";

            btnGestorAnimales.Image = Properties.Resources.huellaInactiva;
            btnGestorHistorialClinico.Image = Properties.Resources.historialInactivo;
            btnGestorPersonal.Image = Properties.Resources.personalActivo;
            btnGestorAlmacen.Image = Properties.Resources.almacenInactivo;
            btnGestorAdopciones.Image = Properties.Resources.adopcionesInactivo;
            btnGestorUsuarios.Image = Properties.Resources.usuarioInactivo;
            btnGestorDependencias.Image = Properties.Resources.dependenciaInactiva;

            btnGestorAnimales.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorHistorialClinico.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorPersonal.ForeColor = Color.FromArgb(123, 44, 191);
            btnGestorAlmacen.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorAdopciones.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorUsuarios.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorDependencias.ForeColor = Color.FromArgb(212, 212, 212);

            imprimirPersonal("SELECT *FROM personal; ");
        }
        private void btnGestorAlmacen_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Almacen";

            btnGestorAnimales.Image = Properties.Resources.huellaInactiva;
            btnGestorHistorialClinico.Image = Properties.Resources.historialInactivo;
            btnGestorPersonal.Image = Properties.Resources.personalInactivo;
            btnGestorAlmacen.Image = Properties.Resources.almacenActivo;
            btnGestorAdopciones.Image = Properties.Resources.adopcionesInactivo;
            btnGestorUsuarios.Image = Properties.Resources.usuarioInactivo;
            btnGestorDependencias.Image = Properties.Resources.dependenciaInactiva;

            btnGestorAnimales.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorHistorialClinico.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorPersonal.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorAlmacen.ForeColor = Color.FromArgb(123, 44, 191);
            btnGestorAdopciones.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorUsuarios.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorDependencias.ForeColor = Color.FromArgb(212, 212, 212);

            imprimirAlmacen("select * from productos;");
        }
        private void btnGestorAdopciones_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Adopciones";

            btnGestorAnimales.Image = Properties.Resources.huellaInactiva;
            btnGestorHistorialClinico.Image = Properties.Resources.historialInactivo;
            btnGestorPersonal.Image = Properties.Resources.personalInactivo;
            btnGestorAlmacen.Image = Properties.Resources.almacenInactivo;
            btnGestorAdopciones.Image = Properties.Resources.adopcionesActivo;
            btnGestorUsuarios.Image = Properties.Resources.usuarioInactivo;
            btnGestorDependencias.Image = Properties.Resources.dependenciaInactiva;

            btnGestorAnimales.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorHistorialClinico.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorPersonal.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorAlmacen.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorAdopciones.ForeColor = Color.FromArgb(123, 44, 191);
            btnGestorUsuarios.ForeColor = Color.FromArgb(212, 212, 212);
            btnGestorDependencias.ForeColor = Color.FromArgb(212, 212, 212);
            imprimirAdopciones("SELECT *from adopciones inner join animales ON animales.idAnimal = adopciones.idAnimal inner join adoptantes ON adoptantes.idAdoptante = adopciones.idAdoptante");
        }
        private void btnRegistrousuarios_Click(object sender, EventArgs e)
        {
            dt = consulta.obtenerTabla("select idUsuario, nombreUsuario, contraseñaUsuario, rangos.nombreRango from usuarios JOIN rangos ON rangos.idRango = usuarios.idRango WHERE idUsuario = '" + idUsuario + "';");
            if (dt.Rows[0]["nombreRango"].ToString() == "Administrador")
            {
                lblTitulo.Text = "Gestor de Usuarios";

                btnGestorAnimales.Image = Properties.Resources.huellaInactiva;
                btnGestorHistorialClinico.Image = Properties.Resources.historialInactivo;
                btnGestorPersonal.Image = Properties.Resources.personalInactivo;
                btnGestorAlmacen.Image = Properties.Resources.almacenInactivo;
                btnGestorAdopciones.Image = Properties.Resources.adopcionesInactivo;
                btnGestorUsuarios.Image = Properties.Resources.usuarioActivo;
                btnGestorDependencias.Image = Properties.Resources.dependenciaInactiva;

                btnGestorAnimales.ForeColor = Color.FromArgb(212, 212, 212);
                btnGestorHistorialClinico.ForeColor = Color.FromArgb(212, 212, 212);
                btnGestorPersonal.ForeColor = Color.FromArgb(212, 212, 212);
                btnGestorAlmacen.ForeColor = Color.FromArgb(212, 212, 212);
                btnGestorAdopciones.ForeColor = Color.FromArgb(212, 212, 212);
                btnGestorUsuarios.ForeColor = Color.FromArgb(123, 44, 191);
                btnGestorDependencias.ForeColor = Color.FromArgb(212, 212, 212);

                imprimirUsuarios("select idUsuario, nombreUsuario, contraseñaUsuario, rangos.nombreRango from usuarios JOIN rangos ON rangos.idRango = usuarios.idRango;");
            }
            else
            {
                MessageBox.Show("Solo el administrador puede visualizar esta area.");
            }
        }
        private void btnDonaciones_Click(object sender, EventArgs e)
        {
            frmDonaciones frmDonaciones = new frmDonaciones();
            frmDonaciones.ShowDialog();
        }
        private void btnDependencias_Click(object sender, EventArgs e)
        {
            dt = consulta.obtenerTabla("select idUsuario, nombreUsuario, contraseñaUsuario, rangos.nombreRango from usuarios JOIN rangos ON rangos.idRango = usuarios.idRango WHERE idUsuario = '" + idUsuario + "';");
            if(dt.Rows[0]["nombreRango"].ToString() == "Administrador")
            {
                frmDependencias frmDependencias = new frmDependencias();
                frmDependencias.ShowDialog();
            }
            else
            {
                MessageBox.Show("Solo el administrador puede visualizar esta area.");
            }
        }

        #endregion

        #region Gestión de los elementos, agregar, eliminar, editar, buscar.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (lblTitulo.Text)
            {
                case "Gestor de Animales":
                    frmAgregarAnimal frmAgregarAnimal = new frmAgregarAnimal();
                    frmAgregarAnimal.Show();
                    break;

                case "Gestor del Historial Clinico":
                    frmAgregarHistorialClinico frmahc = new frmAgregarHistorialClinico();
                    frmahc.Show();
                    break;

                case "Gestor de Voluntarios":
                    frmAgregarPersonal frmAgregarPersonal = new frmAgregarPersonal();
                    frmAgregarPersonal.ShowDialog();
                    break;

                case "Gestor de Almacen":
                    frmAgregarProducto frmAgregarProducto = new frmAgregarProducto();
                    frmAgregarProducto.ShowDialog();
                    break;

                case "Gestor de Adopciones":
                    frmAgregarAdopcion frmagregaradopcion = new frmAgregarAdopcion();
                    frmagregaradopcion.ShowDialog();
                    break;

                case "Gestor de Usuarios":
                    frmAgregarusuario frmAgregarusuario = new frmAgregarusuario();
                    frmAgregarusuario.ShowDialog();
                    break;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (lblTitulo.Text)
            {
                case "Gestor de Animales":
                    try
                    {
                        if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idElemento != string.Empty)
                        {
                            consulta.Consulta("DELETE FROM animales WHERE idAnimal='" + idElemento + "'");
                            imprimirAnimales("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo; ");
                            idElemento = string.Empty;
                            MessageBox.Show("Se elimino");
                        }
                        else
                            MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "Mostrar mensaje al desarrollador"); }
                    
                    break;

                case "Gestor del Historial Clinico":
                    try
                    {
                        if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idElemento != string.Empty)
                        {
                            consulta.Consulta("UPDATE animales SET idHistorial = NULL WHERE idAnimal = '" + idElemento + "'");
                            imprimirAnimales("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo, historial.contenidoHistorial FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo JOIN historial ON historial.idHistorial = animales.idHistorial");
                            idElemento = string.Empty;
                            MessageBox.Show("Se elimino");
                        }
                        else
                            MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "Mostrar mensaje al desarrollador"); }
                    break;

                case "Gestor de Voluntarios":
                    try
                    {
                        if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idElemento != string.Empty)
                        {
                            consulta.Consulta("DELETE FROM personal WHERE idPersonal='" + idElemento + "'");
                            imprimirPersonal("SELECT *FROM personal; ");
                            idElemento = string.Empty;
                            MessageBox.Show("Se elimino");
                        }
                        else
                            MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "Mostrar mensaje al desarrollador"); }
                    break;

                case "Gestor de Almacen":
                    try
                    {
                        if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idElemento != string.Empty)
                        {
                            consulta.Consulta("DELETE FROM productos WHERE idProducto='" + idElemento + "'");
                            imprimirAlmacen("SELECT * FROM productos;");
                            idElemento = string.Empty;
                            MessageBox.Show("Se elimino");
                        }
                        else
                            MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "Mostrar mensaje al desarrollador"); }
                    break;

                case "Gestor de Adopciones":
                    try
                    {
                        if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idElemento != string.Empty)
                        {
                            consulta.Consulta("DELETE FROM adopciones WHERE idAdoptante='" + idElemento + "' AND idAnimal = '" + idElementoSecundario + "'");
                            imprimirAdopciones("SELECT *from adopciones inner join animales ON animales.idAnimal = adopciones.idAnimal inner join adoptantes ON adoptantes.idAdoptante = adopciones.idAdoptante");
                            idElemento = string.Empty;
                            idElementoSecundario = string.Empty;
                            MessageBox.Show("Se elimino");
                        }
                        else
                            MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "Mostrar mensaje al desarrollador"); }
                    break;

                case "Gestor de Usuarios":
                    try
                    {
                        if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idElemento != string.Empty)
                        {
                            consulta.Consulta("DELETE FROM usuarios WHERE idUsuario='" + idElemento + "'");
                            imprimirUsuarios("select idUsuario, nombreUsuario, contraseñaUsuario, rangos.nombreRango from usuarios JOIN rangos ON rangos.idRango = usuarios.idRango;");
                            idElemento = string.Empty;
                            MessageBox.Show("Se elimino");
                        }
                        else
                            MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString(), "Mostrar mensaje al desarrollador"); }
                    break;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idElemento != string.Empty)
                {
                    switch (lblTitulo.Text)
                    {
                        case "Gestor de Animales":
                            frmAgregarAnimal frm = new frmAgregarAnimal();
                            frm.cmdAgregar.Text = "Modificar";
                            dt = consulta.obtenerTabla("SELECT idAnimal, nombreAnimal,caracteristicas,generoAnimal,fechaAnimal, razas.nombreRaza, tipos.nombreTipo FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo WHERE idAnimal = '" + idElemento + "'");
                            frm.cmdAgregar.Name = dt.Rows[0]["idAnimal"].ToString();
                            frm.txtNombre.Text = dt.Rows[0]["nombreAnimal"].ToString();
                            frm.cbTipo.Text = dt.Rows[0]["nombreTipo"].ToString();
                            frm.cbRaza.Text = dt.Rows[0]["nombreRaza"].ToString();
                            if (dt.Rows[0]["generoAnimal"].ToString() == "1")
                                frm.rbMacho.Checked = true;
                            else
                                frm.rbHembra.Checked = true;

                            frm.rtCaracteristicas.Text = dt.Rows[0]["caracteristicas"].ToString();
                            frm.Show();
                            break;

                        case "Gestor del Historial Clinico":
                            break;

                        case "Gestor de Voluntarios":
                            frmAgregarPersonal frmap = new frmAgregarPersonal();
                            frmap.btnAgregar.Text = "Modificar";
                            dt = consulta.obtenerTabla("SELECT *FROM personal WHERE idPersonal = '" + idElemento + "'");
                            frmap.Name = idElemento;
                            frmap.txtNombre.Text = dt.Rows[0]["nombrePersonal"].ToString();
                            frmap.txtNumero.Text = dt.Rows[0]["numeroPersonal"].ToString();
                            frmap.txtDireccion.Text = dt.Rows[0]["direccionPersonal"].ToString();
                            frmap.ShowDialog();
                            break;

                        case "Gestor de Almacen":
                            frmAgregarProducto frmAgregarProducto = new frmAgregarProducto();
                            frmAgregarProducto.btnAgregar.Text = "Modificar";
                            dt = consulta.obtenerTabla("SELECT * FROM productos WHERE idProducto = '" + idElemento + "'");
                            frmAgregarProducto.Name = dt.Rows[0]["idProducto"].ToString();
                            frmAgregarProducto.txtNombre.Text = dt.Rows[0]["nombreProducto"].ToString();
                            frmAgregarProducto.nudCantidad.Value = Convert.ToDecimal(dt.Rows[0]["cantidad"].ToString());
                            frmAgregarProducto.ShowDialog();
                            break;

                        case "Gestor de Adopciones":
                            MessageBox.Show("Por favor de editarlo desde el boton de agregar");
                            break;

                        case "Gestor de Usuarios":
                            frmAgregarusuario frmagregarusuario = new frmAgregarusuario();
                            dt = consulta.obtenerTabla("select idUsuario, nombreUsuario, contraseñaUsuario, rangos.nombreRango from usuarios JOIN rangos ON rangos.idRango = usuarios.idRango WHERE idUsuario = '" + idElemento + "';");
                            frmagregarusuario.btnAgregar.Text = "Modificar";
                            frmagregarusuario.Name = dt.Rows[0]["idUsuario"].ToString();
                            frmagregarusuario.txtUsuario.Text = dt.Rows[0]["nombreUsuario"].ToString();
                            frmagregarusuario.txtContraseña.Text = dt.Rows[0]["contraseñaUsuario"].ToString();
                            frmagregarusuario.txtConfirmarContraseña.Text = dt.Rows[0]["contraseñaUsuario"].ToString();
                            frmagregarusuario.cbRango.Text = dt.Rows[0]["nombreRango"].ToString();

                            frmagregarusuario.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No seleccionaste nada", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text != "")
            {
                switch (lblTitulo.Text)
                {
                    case "Gestor de Animales":
                        if (txtBuscar.Text != "")
                            imprimirAnimales("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo WHERE nombreAnimal='" + txtBuscar.Text + "'; ");
                        else
                            MessageBox.Show("Escriba el nombre que desea buscar");
                        break;

                    case "Gestor del Historial Clinico":
                        if (txtBuscar.Text != "")
                            imprimirAnimales("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo, historial.contenidoHistorial FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo JOIN historial ON historial.idHistorial = animales.idHistorial WHERE nombreAnimal='" + txtBuscar.Text + "'");
                        else
                            MessageBox.Show("Escriba el nombre que desea buscar");
                        break;

                    case "Gestor de Voluntarios":
                        if (txtBuscar.Text != "")
                            imprimirPersonal("SELECT *FROM personal WHERE nombrePersonal = '" + txtBuscar.Text + "'; ");
                        else
                            MessageBox.Show("Escriba el nombre que desea buscar");
                        break;

                    case "Gestor de Almacen":
                        if (txtBuscar.Text != "")
                            imprimirAlmacen("select * from productos WHERE nombreProducto = '" + txtBuscar.Text + "'; ");
                        else
                            MessageBox.Show("Escriba el nombre que desea buscar");
                        break;

                    case "Gestor de Adopciones":
                        if (txtBuscar.Text != "")
                            MessageBox.Show("");
                        else
                            MessageBox.Show("Escriba el nombre que desea buscar");
                        break;

                    case "Gestor de Usuarios":
                        if (txtBuscar.Text != "")
                            imprimirUsuarios("select idUsuario, nombreUsuario, contraseñaUsuario, rangos.nombreRango from usuarios JOIN rangos ON rangos.idRango = usuarios.idRango WHERE nombreUsuario = '" + txtBuscar.Text + "';");
                        else
                            MessageBox.Show("Escriba el nombre que desea buscar");
                        break;
                }
            }
            else
            {
                MessageBox.Show("No ha introducido ningun nombre");
            }
        }
        #endregion
        
        private void imprimirAnimales(string query)
        {
            flpGestor.Controls.Clear();
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                //Declaramos la tarjeta del perro
                //Asi no usamos uno solo para estar sobreescribiendo
                ucAnimal usanimal = new ucAnimal();
                //Le asignamos el id del animal a la tarjeta para identificarla
                usanimal.Name = dt.Rows[i]["idAnimal"].ToString();
                //Asignamos la información del animal en sus campos correspondientes
                usanimal.lblNombre.Text = dt.Rows[i]["nombreAnimal"].ToString();
                usanimal.lblRaza.Text = dt.Rows[i]["nombreRaza"].ToString();
                usanimal.lblTipo.Text = dt.Rows[i]["nombreTipo"].ToString();
                usanimal.lblFecha.Text = dt.Rows[i]["fechaAnimal"].ToString();
                usanimal.rtAdicional.Text = dt.Rows[i]["caracteristicas"].ToString();
                //Si el valor de la columna genero animal es true significa que es macho, sino es hembra
                //la información de dicha columna es guardada en bit
                if (dt.Rows[i]["generoAnimal"].ToString() == "True")
                    usanimal.lblSexo.Text = "Macho";
                else
                    usanimal.lblSexo.Text = "Hembra";
                //Asignamos un margen al control de usuario para estetica
                //                            Iz  Ar Ab De
                usanimal.Margin = new Padding(0, 5, 5, 10);

                //Agregar el control (comentario)
                flpGestor.Controls.Add(usanimal);
                GC.Collect();
            }
        }
        private void imprimirPersonal(string query)
        {
            flpGestor.Controls.Clear();
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                //Declaramos la tarjeta del personal
                //Asi no usamos uno solo para estar sobreescribiendo
                ucPersonal uspersonal = new ucPersonal();
                //Le asignamos el id del personal a la tarjeta para identificarla
                uspersonal.Name = dt.Rows[i]["idPersonal"].ToString();
                //Asignamos la información del animal en sus campos correspondientes
                uspersonal.lblNombre.Text = dt.Rows[i]["nombrePersonal"].ToString();
                uspersonal.lblDireccion.Text = dt.Rows[i]["direccionPersonal"].ToString();
                uspersonal.lblNumero.Text = dt.Rows[i]["numeroPersonal"].ToString();

                //Asignamos un margen al control de usuario para estetica
                //                            Ar  Iz Ab De
                uspersonal.Margin = new Padding(10, 10, 0, 0);
                //Asignamos la fotografia
                //uspersonal.pbPersonal.Image = Image.FromStream(ms);

                //Agregar el control (comentario)
                flpGestor.Controls.Add(uspersonal);
            }
        }
        private void imprimirAlmacen(string query)
        {
            flpGestor.Controls.Clear();
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                ucProducto ucproducto = new ucProducto();
                ucproducto.Name = dt.Rows[i]["idProducto"].ToString();
                ucproducto.lblNombre.Text = dt.Rows[i]["nombreProducto"].ToString();
                ucproducto.lblCantidad.Text = dt.Rows[i]["cantidad"].ToString();
                ucproducto.btnEliminar.Visible = false;

                //Agregar el control (comentario)
                flpGestor.Controls.Add(ucproducto);
            }
        }
        private void imprimirUsuarios(string query)
        {
            flpGestor.Controls.Clear();
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                ucUsuario ucusuario = new ucUsuario();
                ucusuario.Name = dt.Rows[i]["idUsuario"].ToString();
                ucusuario.lblNombre.Text = dt.Rows[i]["nombreUsuario"].ToString();
                ucusuario.lblContraseña.Text = dt.Rows[i]["contraseñaUsuario"].ToString();
                ucusuario.lblRango.Text = dt.Rows[i]["nombreRango"].ToString();
                ucusuario.Margin = new Padding(5, 5, 5, 10);
                //Agregar el control (comentario)
                flpGestor.Controls.Add(ucusuario);
            }
        }
        private void imprimirAdopciones(string query)
        {
            flpGestor.Controls.Clear();
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                ucAdopciones ucAdopciones = new ucAdopciones();
                ucAdopciones.lblAdoptado.Text = dt.Rows[i]["nombreAnimal"].ToString();
                ucAdopciones.lblIdAdoptado.Text = dt.Rows[i]["idAnimal"].ToString();
                ucAdopciones.lblAdoptante.Text = dt.Rows[i]["nombreAdoptante"].ToString();
                ucAdopciones.lblIdAdoptante.Text = dt.Rows[i]["idAdoptante"].ToString();

                //Asignamos un margen al control de usuario para estetica
                //                            Ar  Iz Ab De
                ucAdopciones.Margin = new Padding(10, 10, 0, 0);
                //Asignamos la fotografia
                //uspersonal.pbPersonal.Image = Image.FromStream(ms);

                //Agregar el control (comentario)
                flpGestor.Controls.Add(ucAdopciones);
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
