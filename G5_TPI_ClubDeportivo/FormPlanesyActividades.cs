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
    public partial class FormPlanesyActividades : Form
    {
        public FormPlanesyActividades()
        {
            InitializeComponent();

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FormPrincipal Principal = new FormPrincipal();
            Principal.Show(); // llama al formulario 
            this.Close();
        }


        private void cargarListaPrecios()
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                string queryPlanes = "SELECT Plan, Precio FROM PlanMembresia;";
                string queryActividades = "SELECT Nombre, Precio FROM Actividad;";

                sqlCon.Open();

                // Grilla de Planes de Membresía
                using (MySqlCommand comandoPlanes = new MySqlCommand(queryPlanes, sqlCon))
                {
                    using (MySqlDataReader readerPlanes = comandoPlanes.ExecuteReader())
                    {
                        if (readerPlanes.HasRows)
                        {
                            while (readerPlanes.Read())
                            {
                                int renglon = dtgvPlanes.Rows.Add();
                                string nombrePlan = readerPlanes.GetString("Plan");
                                double precioPlan = readerPlanes.GetDouble("Precio");

                                dtgvPlanes.Rows[renglon].Cells[0].Value = nombrePlan;
                                dtgvPlanes.Rows[renglon].Cells[1].Value = precioPlan.ToString("0.00");
                                dtgvPlanes.Rows[renglon].Cells[2].Value = precioPlan.ToString("0.00");
                                dtgvPlanes.Rows[renglon].Cells[3].Value = (precioPlan / 3).ToString("0.00");
                                dtgvPlanes.Rows[renglon].Cells[4].Value = (precioPlan / 6).ToString("0.00");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para cargar en la grilla de planes de membresía.");
                        }
                    }
                }

                // Grilla de Actividades
                using (MySqlCommand comandoActividades = new MySqlCommand(queryActividades, sqlCon))
                {
                    using (MySqlDataReader readerActividades = comandoActividades.ExecuteReader())
                    {
                        if (readerActividades.HasRows)
                        {
                            while (readerActividades.Read())
                            {
                                int renglon = dtgvActividades.Rows.Add();
                                string nombreActividad = readerActividades.GetString("Nombre");
                                double precioActividad = readerActividades.GetDouble("Precio");

                                dtgvActividades.Rows[renglon].Cells[0].Value = nombreActividad;
                                dtgvActividades.Rows[renglon].Cells[1].Value = precioActividad.ToString("0.00");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para cargar en la grilla de actividades.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void FormPlanesyActividades_Load_1(object sender, EventArgs e)
        {
            cargarListaPrecios(); // Llamo al procedimiento en cuanto carga la ventana
        }


    }
}
