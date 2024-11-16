using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_TPI_ClubDeportivo.Datos
{
    internal class Socio : Cliente
    {

        public string Nuevo_Socio(Entidades.E_Socio socio)
        {
            string? salidarespuestaCliente;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                //Cargo los parametros de entrada para el procedimiento almacenado para clientes
                MySqlCommand comandoCliente = new MySqlCommand("nuevoSocio", sqlCon);
                comandoCliente.CommandType = CommandType.StoredProcedure;
                comandoCliente.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comandoCliente.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comandoCliente.Parameters.Add("TipoDocumento", MySqlDbType.VarChar).Value = socio.TipoDocumento;
                comandoCliente.Parameters.Add("NumeroDocumento", MySqlDbType.Int32).Value = socio.NumeroDocumento;
                comandoCliente.Parameters.Add("FechaNacimiento", MySqlDbType.Date).Value = socio.FechaNacimiento;
                comandoCliente.Parameters.Add("AptoFisico", MySqlDbType.Bit).Value = socio.AptoFisico;

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
                comandoPago.Parameters.Add("EsSocio", MySqlDbType.Bit).Value = true;
                comandoPago.Parameters.Add("VarMembresiaID", MySqlDbType.Int32).Value = pago.MembresiaID;
                comandoPago.Parameters.Add("VarActividadID", MySqlDbType.Int32).Value = null;
                comandoPago.Parameters.Add("VarMetodoPago", MySqlDbType.VarChar).Value = pago.MetodoPago;
                comandoPago.Parameters.Add("VarCuotas", MySqlDbType.Int32).Value = pago.Cuotas;

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

        public FormCarnetSocio cargarCarnet(int cliente, FormCarnetSocio carnet)
        {
            FormCarnetSocio carnetEmitido = carnet;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select * from VistaSocios where ClienteID = @cliente;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@cliente", cliente);
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        carnetEmitido.CarnetSocioID = reader.IsDBNull(8) ? "No se ha emitido carnet" : reader.GetString(8);
                        carnetEmitido.Apellido = reader.GetString(1);
                        carnetEmitido.Nombre = reader.GetString(2);
                        carnetEmitido.TipoDocumento = reader.GetString(3);
                        carnetEmitido.NumeroDocumento = reader.GetInt32(4);
                        carnetEmitido.FechaNacimiento = reader.GetDateTime(5);
                        carnetEmitido.FechaInscripcion = reader.GetDateTime(7);
                        carnetEmitido.AptoFisico = reader.IsDBNull(9) ? false : reader.GetBoolean(9);
                        carnetEmitido.FechaVencimiento = reader.GetDateTime(10);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para cargar en el carnet.");
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
            return carnetEmitido;
        }



    }
}
