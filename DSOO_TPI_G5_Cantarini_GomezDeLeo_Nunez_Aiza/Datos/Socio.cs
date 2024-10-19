using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza.Datos
{
    internal class Socio
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











        




    }
}
