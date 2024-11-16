using G5_TPI_ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_TPI_ClubDeportivo.Datos
{
    internal class Cliente
    {
        public Entidades.E_Cliente BuscarCliente(string TipoDocumento, int NumeroDocumento)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Llamamos al procedimiento almacenado
                MySqlCommand comandoCliente = new MySqlCommand("obtenerDatosCliente", sqlCon);
                comandoCliente.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                comandoCliente.Parameters.Add("TipoDocumento", MySqlDbType.VarChar).Value = TipoDocumento;
                comandoCliente.Parameters.Add("NumeroDocumento", MySqlDbType.Int32).Value = NumeroDocumento;

                // Parámetros de salida
                comandoCliente.Parameters.Add("@ExisteCliente", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarClienteID", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarTipoCliente", MySqlDbType.VarChar).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarApellido", MySqlDbType.VarChar).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarNombre", MySqlDbType.VarChar).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarFechaNacimiento", MySqlDbType.Date).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarEdad", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@FechaInscripcion", MySqlDbType.Date).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarAptoFisico", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarCarnetSocioID", MySqlDbType.VarChar).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarFechaVencimientoCuota", MySqlDbType.Date).Direction = ParameterDirection.Output;
                comandoCliente.Parameters.Add("@VarActivo", MySqlDbType.Bit).Direction = ParameterDirection.Output;

                // Ejecutamos el procedimiento
                sqlCon.Open();
                comandoCliente.ExecuteNonQuery();

                // Evauamos si existe o no el cliente
                int existeCliente = Convert.ToInt32(comandoCliente.Parameters["@ExisteCliente"].Value);

                if (existeCliente == 0)
                {
                    MessageBox.Show("No se encuentra al cliente en el sistema.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }

                // Si el cliente existe, verificamos el tipo de cliente como Socio o No Socio
                string tipoCliente = comandoCliente.Parameters["@VarTipoCliente"].Value.ToString();
                Entidades.E_Cliente cliente;

                if (tipoCliente == "Socio")
                {
                    cliente = new Entidades.E_Socio
                    {
                        CarnetSocioID = comandoCliente.Parameters["@VarCarnetSocioID"].Value.ToString(),
                        Activo = Convert.ToBoolean(comandoCliente.Parameters["@VarActivo"].Value),
                        FechaVencimientoCuota = Convert.ToDateTime(comandoCliente.Parameters["@VarFechaVencimientoCuota"].Value),
                    };
                }
                else
                {
                    cliente = new Entidades.E_NoSocio();
                }

                // Pasamos toda la informacion obtenida de la base de datos al objeto cliente
                cliente.ClienteID = Convert.ToInt32(comandoCliente.Parameters["@VarClienteID"].Value);
                cliente.Apellido = comandoCliente.Parameters["@VarApellido"].Value.ToString();
                cliente.Nombre = comandoCliente.Parameters["@VarNombre"].Value.ToString();
                cliente.TipoDocumento = TipoDocumento;
                cliente.NumeroDocumento = NumeroDocumento;
                cliente.FechaNacimiento = Convert.ToDateTime(comandoCliente.Parameters["@VarFechaNacimiento"].Value);
                cliente.FechaInscripcion = Convert.ToDateTime(comandoCliente.Parameters["@FechaInscripcion"].Value);
                cliente.AptoFisico = Convert.ToBoolean(comandoCliente.Parameters["@VarAptoFisico"].Value);
                cliente.Edad = Convert.ToInt32(comandoCliente.Parameters["@VarEdad"].Value);
                cliente.TipoCliente = comandoCliente.Parameters["@VarTipoCliente"].Value.ToString();

                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public virtual int RegistrarPago(Entidades.E_Pago pago)
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
                comandoPago.Parameters.Add("EsSocio", MySqlDbType.Bit).Value = pago.EsSocio;
                comandoPago.Parameters.Add("VarMembresiaID", MySqlDbType.Int32).Value = pago.MembresiaID;
                comandoPago.Parameters.Add("VarActividadID", MySqlDbType.Int32).Value = pago.ActividadID;
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
    }
}