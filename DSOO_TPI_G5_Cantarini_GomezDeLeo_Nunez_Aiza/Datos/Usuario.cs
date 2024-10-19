using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza.Datos
{
    internal class Usuario
    {
        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Login_Usuario(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("ingresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("UsuarioNombre", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("UsuarioPass", MySqlDbType.VarChar).Value = P_Usu;
                // abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // almacenamos el resultado en la variable
                tabla.Load(resultado); // cargamos la tabla con el    resultado
                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta   almacenado en MySQL
            }
            catch (MySqlException ex)
            {
                // Mostrar mensaje detallado del error MySQL
                MessageBox.Show($"Error en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                // Mostrar cualquier otro tipo de error
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { 
                    sqlCon.Close(); 
                };
            }
        }

    }
}
