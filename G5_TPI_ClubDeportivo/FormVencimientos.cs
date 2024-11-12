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
    public partial class FormVencimientos : Form
    {
        public FormVencimientos()
        {
            InitializeComponent();
        }

        private void btnVolverVencimientos_Click(object sender, EventArgs e)
        {
            FormPrincipal Principal = new FormPrincipal();
            Principal.Show(); // llama al formulario 
            this.Close();
        }

        private void FormVencimientos_Load(object sender, EventArgs e)
        {
            listarVencimientos();
        }

        private void listarVencimientos()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select * from VistaVencimientosHoy;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvVencimientos.Rows.Add();
                        dtgvVencimientos.Rows[renglon].Cells[0].Value = reader.GetInt32(0).ToString();
                        dtgvVencimientos.Rows[renglon].Cells[1].Value = reader.IsDBNull(3) ? "Sin carnet" : reader.GetString(3);
                        dtgvVencimientos.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvVencimientos.Rows[renglon].Cells[3].Value = reader.GetString(1);
                        dtgvVencimientos.Rows[renglon].Cells[4].Value = reader.GetDateTime(4).ToShortDateString();
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
        private void dtgvVencimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

