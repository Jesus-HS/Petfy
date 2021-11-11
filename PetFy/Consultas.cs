using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetFy
{
    public class Consultas
    {

        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DataTable dt;
        private SqlDataAdapter da;

        /// <summary> 
        /// Realiza una conexion a la tabla
        /// </summary>
        public Consultas()
        {
            try
            {//bkdoyaci_petfy Petfy123
                cn = new SqlConnection("Data Source=PetfyDB.mssql.somee.com; " +
                    "Initial Catalog=PetfyDB; " +
                    "User ID=Petfy_SQLLogin_1;" +
                    "Password=6wzp3brymh;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se logro acceder a la base de datos" + ex);
            }
        }

        /// <summary> 
        /// Recibe solo 1 parametro, para consulta sobre insertar, borrar o modificar
        /// </summary>
        public void Consulta(string consulta)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand(consulta, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro insertar:" + ex);
            }
        }
        /// <summary>
        /// Sirve para mostrar una consulta como SELECT entero o individual
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns>Una tabla</returns>
        public DataTable obtenerTabla(string consulta)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand(consulta, cn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se obtener:" + ex);
                return null;
            }
        }
    }
}
