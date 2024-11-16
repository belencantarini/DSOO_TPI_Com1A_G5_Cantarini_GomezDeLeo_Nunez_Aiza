using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_TPI_ClubDeportivo.Datos
{
    internal class NoSocio : Cliente
    {
        public string Nuevo_NoSocio(Entidades.E_NoSocio noSocio)
        {
            string? salidarespuestaCliente;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                //Cargo los parametros de entrada para el procedimiento almacenado para clientes
                MySqlCommand comandoCliente = new MySqlCommand("nuevoNoSocio", sqlCon);
                comandoCliente.CommandType = CommandType.StoredProcedure;
                comandoCliente.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = noSocio.Nombre;
                comandoCliente.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = noSocio.Apellido;
                comandoCliente.Parameters.Add("TipoDocumento", MySqlDbType.VarChar).Value = noSocio.TipoDocumento;
                comandoCliente.Parameters.Add("NumeroDocumento", MySqlDbType.Int32).Value = noSocio.NumeroDocumento;
                comandoCliente.Parameters.Add("FechaNacimiento", MySqlDbType.Date).Value = noSocio.FechaNacimiento;
                comandoCliente.Parameters.Add("AptoFisico", MySqlDbType.Bit).Value = noSocio.AptoFisico;

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

        public override int RegistrarPago(Entidades.E_Pago pago)
        {
            int salidarespuestaPago = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Llamamos al procedimiento almacenado
                MySqlCommand comandoPago = new MySqlCommand("registrarPago", sqlCon);
                comandoPago.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                comandoPago.Parameters.Add("VarClienteID", MySqlDbType.Int32).Value = pago.ClienteID;
                comandoPago.Parameters.Add("EsSocio", MySqlDbType.Bit).Value = false;
                comandoPago.Parameters.Add("VarMembresiaID", MySqlDbType.Int32).Value = null;
                comandoPago.Parameters.Add("VarActividadID", MySqlDbType.Int32).Value = pago.ActividadID;
                comandoPago.Parameters.Add("VarMetodoPago", MySqlDbType.VarChar).Value = pago.MetodoPago;
                comandoPago.Parameters.Add("VarCuotas", MySqlDbType.Int32).Value = 1;

                // Parámetros de salida
                MySqlParameter ParRespuestaPago = new MySqlParameter();
                ParRespuestaPago.ParameterName = "@Respuesta";
                ParRespuestaPago.MySqlDbType = MySqlDbType.Int32;
                ParRespuestaPago.Direction = ParameterDirection.Output;
                comandoPago.Parameters.Add(ParRespuestaPago);

                // Ejecutamos el procedimiento
                sqlCon.Open();
                comandoPago.ExecuteNonQuery();

                salidarespuestaPago = Convert.ToInt32(ParRespuestaPago.Value);

                return salidarespuestaPago;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return salidarespuestaPago;
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }



    }
}
