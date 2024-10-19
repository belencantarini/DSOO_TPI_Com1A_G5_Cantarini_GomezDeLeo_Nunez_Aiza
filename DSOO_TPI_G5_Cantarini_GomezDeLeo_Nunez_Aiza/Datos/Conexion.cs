using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza.Datos
{
    internal class Conexion
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion() // asignamos valores a las variables de la conexion
        {
            baseDatos = "DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza";
            servidor = "localhost";
            puerto = "3306";
            usuario = "root";
            clave = "";
        }

        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + servidor +
                ";port=" + puerto +
                ";username=" + usuario +
                ";password=" + clave +
                ";Database=" + baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }

    }
}
