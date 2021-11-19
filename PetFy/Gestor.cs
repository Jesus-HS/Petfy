using PetFy.Modulo_Almacen;
using PetFy.Modulo_Personal;
using PetFy.Modulo_Usuarios;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PetFy
{
    public partial class frmGestor : Form
    {
        static public string idElemento = String.Empty;
        Consultas consulta = new Consultas();
        DataTable dt;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public frmGestor()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (lblTitulo.Text)
            {
                case "Gestor de Animales":
                    frmAgregarAnimal frmAgregarAnimal = new frmAgregarAnimal();
                    frmAgregarAnimal.Show();
                    break;

                case "Gestor del Historial Clinico":
                    break;

                case "Gestor de Personal":
                    frmAgregarPersonal frmAgregarPersonal = new frmAgregarPersonal();
                    frmAgregarPersonal.ShowDialog();
                    break;

                case "Gestor de Almacen":
                    frmAgregarProducto frmAgregarProducto = new frmAgregarProducto();
                    frmAgregarProducto.ShowDialog();
                    break;

                case "Gestor de Adopciones":
                    break;

                case "Gestor de Usuarios":
                    frmAgregarusuario frmAgregarusuario = new frmAgregarusuario();
                    frmAgregarusuario.ShowDialog();
                    break;
            }
        }

        private void frmGestor_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Animales";
            imprimirAnimales();
        }

        private void btnGestorAnimales_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Animales";
            flpGestor.Controls.Clear();
            imprimirAnimales();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor del Historial Clinico";
        }

        private void btnPersonal_Click_1(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Personal";
            flpGestor.Controls.Clear();
            imprimirPersonal();
        }

        private void btnGestorAlmacen_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Almacen";
            flpGestor.Controls.Clear();
            imprimirAlmacen();
        }

        private void btnGestorAdopciones_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Adopciones";
        }

        private void btnRegistrousuarios_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de Usuarios";
            flpGestor.Controls.Clear();
            imprimirUsuarios();
        }

        private void imprimirAnimales()
        {
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo, fotoAnimal " +
                                                 "FROM animales " +
                                                 "JOIN Razas ON razas.idRaza = animales.idRaza " +
                                                 "JOIN tipos ON tipos.idTipo = animales.idTipo; ");
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
                //Si el valor de la columna genero animal es true significa que es macho, sino es hembra
                //la información de dicha columna es guardada en bit
                if (dt.Rows[i]["generoAnimal"].ToString() == "True")
                    usanimal.lblSexo.Text = "Macho";
                else
                    usanimal.lblSexo.Text = "Hembra";
                //Asignamos un margen al control de usuario para estetica
                //                            Ar  Iz Ab De
                usanimal.Margin = new Padding(10, 10, 0, 0);
                //Obtenemos la cadena de bytes de la foto grafia y almacenamos para convertir a imagen
                byte[] MisDatos = (byte[])dt.Rows[i]["fotoAnimal"];
                MemoryStream ms = new MemoryStream(MisDatos);
                //Asignamos la fotografia
                usanimal.pbAnimal.Image = Image.FromStream(ms);

                //Agregar el control (comentario)
                flpGestor.Controls.Add(usanimal);
                GC.Collect();
            }
        }
        private void imprimirPersonal()
        {
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla("SELECT *FROM personal; ");
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
                //Obtenemos la cadena de bytes de la foto grafia y almacenamos para convertir a imagen
                byte[] MisDatos = (byte[])dt.Rows[i]["fotoPersonal"];
                MemoryStream ms = new MemoryStream(MisDatos);
                //Asignamos la fotografia
                //uspersonal.pbPersonal.Image = Image.FromStream(ms);

                //Agregar el control (comentario)
                flpGestor.Controls.Add(uspersonal);
            }
        }
        private void imprimirAlmacen()
        {
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla("select * from productos;");
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                ucProducto ucproducto = new ucProducto();
                ucproducto.Name = dt.Rows[i]["idProducto"].ToString();
                ucproducto.lblNombre.Text = dt.Rows[i]["nombreProducto"].ToString();
                ucproducto.lblCantidad.Text = dt.Rows[i]["cantidad"].ToString();

                //Agregar el control (comentario)
                flpGestor.Controls.Add(ucproducto);
            }
        }
        private void imprimirUsuarios()
        {
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla("select idUsuario, nombreUsuario, contraseñaUsuario, rangos.nombreRango from usuarios JOIN rangos ON rangos.idRango = usuarios.idRango;");
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

                //Agregar el control (comentario)
                flpGestor.Controls.Add(ucusuario);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el elemento? id" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                MessageBox.Show("se elimino");
            else
                MessageBox.Show("No se elimino");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAgregarAnimal frm = new frmAgregarAnimal();
            frm.cmdAgregar.Text = "Modificar";
            switch (lblTitulo.Text)
            {
                case "Gestor de Animales":
                    
                    dt = consulta.obtenerTabla("SELECT idAnimal, nombreAnimal,caracteristicas,generoAnimal,fechaAnimal, razas.nombreRaza, tipos.nombreTipo, fotoAnimal FROM animales JOIN Razas ON razas.idRaza = animales.idRaza JOIN tipos ON tipos.idTipo = animales.idTipo WHERE idAnimal = '" + idElemento + "'");
                    frm.txtNombre.Text = dt.Rows[0]["nombreAnimal"].ToString();
                    frm.cbTipo.Text = dt.Rows[0]["nombreTipo"].ToString();
                    frm.cbRaza.Text = dt.Rows[0]["nombreRaza"].ToString();
                    if (dt.Rows[0]["generoAnimal"].ToString() == "1")
                        frm.rbMacho.Checked = true;
                    else
                        frm.rbHembra.Checked = true;

                    frm.rtCaracteristicas.Text = dt.Rows[0]["caracteristicas"].ToString();
                    byte[] MisDatos = (byte[])dt.Rows[0]["fotoAnimal"];
                    MemoryStream ms = new MemoryStream(MisDatos);
                    //Asignamos la fotografia
                    frm.pbFoto.Image = Image.FromStream(ms);
                    frm.Show();
                    break;

                case "Gestor del Historial Clinico":
                    break;

                case "Gestor de Personal":
                    frmAgregarPersonal frmAgregarPersonal = new frmAgregarPersonal();
                    frmAgregarPersonal.ShowDialog();
                    break;

                case "Gestor de Almacen":
                    frmAgregarProducto frmAgregarProducto = new frmAgregarProducto();
                    frmAgregarProducto.ShowDialog();
                    break;

                case "Gestor de Adopciones":
                    break;

                case "Gestor de Usuarios":
                    frmAgregarusuario frmAgregarusuario = new frmAgregarusuario();
                    frmAgregarusuario.ShowDialog();
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (lblTitulo.Text)
            {
                case "Gestor de Animales":

                    break;

                case "Gestor del Historial Clinico":
                    break;

                case "Gestor de Personal":
                    
                    break;

                case "Gestor de Almacen":
                    
                    break;

                case "Gestor de Adopciones":
                    break;

                case "Gestor de Usuarios":
                    
                    break;
            }
        }
    }
}
