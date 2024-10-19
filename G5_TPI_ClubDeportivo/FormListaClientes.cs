using G5_TPI_ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_TPI_ClubDeportivo
{
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal Principal = new FormPrincipal();
            Principal.Show(); // llama al formulario 
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            cargarListaClientes(); // Llamo al procedimiento en cuanto carga la ventana
        }


        private void cargarListaClientes()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select * from VistaClientes;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvClientes.Rows.Add();
                        dtgvClientes.Rows[renglon].Cells[0].Value = reader.GetInt32(0).ToString();
                        dtgvClientes.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvClientes.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvClientes.Rows[renglon].Cells[3].Value = reader.GetString(3);
                        dtgvClientes.Rows[renglon].Cells[4].Value = reader.GetInt32(4).ToString();
                        dtgvClientes.Rows[renglon].Cells[5].Value = reader.GetDateTime(5).ToShortDateString();
                        dtgvClientes.Rows[renglon].Cells[6].Value = reader.GetInt32(6).ToString();
                        dtgvClientes.Rows[renglon].Cells[7].Value = reader.GetDateTime(7).ToShortDateString();
                        dtgvClientes.Rows[renglon].Cells[8].Value = reader.GetBoolean(8) ? "Sí" : "No";
                        dtgvClientes.Rows[renglon].Cells[9].Value = reader.GetString(9);

                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para cargar en la grilla.");
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
        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

