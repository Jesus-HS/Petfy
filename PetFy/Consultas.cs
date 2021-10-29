using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetFy
{
    public class Consultas
    {

        public MySqlConnection cn = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();
        private DataTable dt;
        private MySqlDataAdapter da;

        /// <summary> 
        /// Realiza una conexion a la tabla
        /// </summary>
        public Consultas()
        {
            try
            {
                cn = new MySqlConnection("server=127.0.0.1;" +
                                         "database=petfy;" +
                                         "userid=root;" +
                                         "password=;" +
                                         "SSL Mode=None");
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
                cmd = new MySqlCommand(consulta, cn);
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
                cmd = new MySqlCommand(consulta, cn);
                da = new MySqlDataAdapter(cmd);
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
