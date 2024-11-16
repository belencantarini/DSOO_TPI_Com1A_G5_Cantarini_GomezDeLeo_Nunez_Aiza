using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_TPI_ClubDeportivo.Datos
{
    internal class PlanMembresia
    {
        public List<Tuple<string, decimal>> ObtenerPlanes()
        {
            List<Tuple<string, decimal>> planes = new List<Tuple<string, decimal>>();
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand("SELECT Plan, Precio FROM PlanMembresia", sqlCon);
                using (MySqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        planes.Add(new Tuple<string, decimal>(lector.GetString("Plan"), lector.GetDecimal("Precio")));
                    }
                }
            }
            return planes;
        }
    }
}
