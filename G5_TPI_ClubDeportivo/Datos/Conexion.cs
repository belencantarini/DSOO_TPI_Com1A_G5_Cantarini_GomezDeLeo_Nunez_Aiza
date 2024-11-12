using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace G5_TPI_ClubDeportivo.Datos
{
    internal class Conexion
    {
        // declaramos las variables
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private string baseDatos;
        private static Conexion? con = null;
        private Conexion() // asignamos valores a las variables de la conexion
        {
            bool correcto = false;
            int mensaje;

            string T_servidor = "localhost";
            string T_puerto = "3306";
            string T_usuario = "root";
            string T_clave = "";

            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("Por favor, ingrese su servidor. \nPor ejemplo, localhost.", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("Por favor, ingrese su puerto de conexión. \nPor ejemplo, 3306", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("Por favor, ingrese su usuario. \nPor ejemplo, root", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("Por favor, ingrese su clave.", "DATOS DE INSTALACIÓN MySQL");

                mensaje = (int)MessageBox.Show("Verifique los datos ingresados: " + "\n" +
                    "- SERVIDOR: " + T_servidor + "\n" +
                    "- PUERTO: " + T_puerto + "\n" +
                    "- USUARIO: " + T_usuario + "\n" +
                    "- CLAVE: " + T_clave, 
                    "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("Por favor, INGRESE NUEVAMENTE LOS DATOS.");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }


            this.baseDatos = "DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza";
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.usuario = T_usuario;
            this.clave = T_clave;

        }

        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
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