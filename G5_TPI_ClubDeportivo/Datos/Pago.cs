using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_TPI_ClubDeportivo.Datos
{
    internal class Pago
    {
        public FormFactura cargarComprobante(FormFactura factura)
        {
            FormFactura facturaEmitida = factura;
            
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select * from vistaUltimoRecibo;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        facturaEmitida.FacturaID = reader.GetInt32(0);
                        facturaEmitida.ClienteID = reader.GetInt32(1);
                        facturaEmitida.Apellido = reader.GetString(2);
                        facturaEmitida.Nombre = reader.GetString(3);
                        facturaEmitida.TipoDocumento = reader.GetString(4);
                        facturaEmitida.NumeroDocumento = reader.GetInt32(5);
                        facturaEmitida.MembresiaID = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                        facturaEmitida.PlanMembresia = reader.IsDBNull(8) ? "N/A" : reader.GetString(8);
                        facturaEmitida.ActividadID = reader.IsDBNull(9) ? 0 : reader.GetInt32(9);
                        facturaEmitida.Actividad = reader.IsDBNull(10) ? "N/A" : reader.GetString(10);
                        facturaEmitida.Monto = reader.GetDecimal(11);
                        facturaEmitida.MetodoPago = reader.GetString(12);
                        facturaEmitida.Cuotas = reader.GetInt32(13);
                        facturaEmitida.FechaPago = reader.GetDateTime(14);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para cargar en la factura.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return facturaEmitida;
        }
    }
}
