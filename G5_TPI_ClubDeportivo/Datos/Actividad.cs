using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_TPI_ClubDeportivo.Datos
{
    internal class Actividad
    {
        public List<Tuple<string, decimal>> ObtenerActividades()
        {
            List<Tuple<string, decimal>> actividades = new List<Tuple<string, decimal>>();
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand("select Nombre, Precio from Actividad", sqlCon);
                using (MySqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        actividades.Add(new Tuple<string, decimal>(lector.GetString("Nombre"), lector.GetDecimal("Precio")));
                    }
                }
            }
            return actividades;
        }
    }
}
