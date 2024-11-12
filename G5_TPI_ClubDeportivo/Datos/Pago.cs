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
        public string Nuevo_Pago(Entidades.E_Pago pago)
        {
            string? salidarespuestaCliente;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                //Cargo los parametros de entrada para el procedimiento almacenado para clientes
                MySqlCommand comandoCliente = new MySqlCommand("nuevoPago", sqlCon);
                comandoCliente.CommandType = CommandType.StoredProcedure;
                comandoCliente.Parameters.Add("ClienteID", MySqlDbType.Int32).Value = pago.ClienteID;
                comandoCliente.Parameters.Add("MembresiaID", MySqlDbType.Int32).Value = pago.MembresiaID;
                comandoCliente.Parameters.Add("ActividadID", MySqlDbType.Int32).Value = pago.ActividadID;
                comandoCliente.Parameters.Add("Monto", MySqlDbType.Double).Value = pago.Monto;
                comandoCliente.Parameters.Add("MetodoPago", MySqlDbType.VarChar).Value = pago.MetodoPago;
                comandoCliente.Parameters.Add("Cuotas", MySqlDbType.Int32).Value = pago.Cuotas;


                MySqlParameter ParRespuestaCliente = new MySqlParameter();
                ParRespuestaCliente.ParameterName = "RespuestaCliente";
                ParRespuestaCliente.MySqlDbType = MySqlDbType.Int32;
                ParRespuestaCliente.Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add(ParRespuestaCliente);


                sqlCon.Open();
                comandoCliente.ExecuteNonQuery();
                salidarespuestaCliente = Convert.ToString(ParRespuestaCliente.Value);

            }
            catch (Exception ex)
            {
                salidarespuestaCliente = ex.Message;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salidarespuestaCliente;

        }
    }
}