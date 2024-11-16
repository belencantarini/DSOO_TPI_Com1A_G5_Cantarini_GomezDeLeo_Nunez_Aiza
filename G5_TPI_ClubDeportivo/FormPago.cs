using G5_TPI_ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections;
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
    public partial class FormPago : Form
    {
        public FormFactura factura = new FormFactura();
        public FormPago()
        {
            InitializeComponent();
        }

        private void FormPago_Load(object sender, EventArgs e)
        {


        }

        private void listarPlanesActividades(ComboBox comboBox, List<Tuple<string, decimal>> lista)
        {
            comboBox.DataSource = lista;
            comboBox.DisplayMember = "Item1"; // Nombre del plan o actividad
            comboBox.ValueMember = "Item2";  // Precio
            comboBox.SelectedIndex = -1; // Sin selección inicial
            comboBox.Text = "Elija una opción";
            txtPrecio.Text = null;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(cboTipoDocumento.Text) || string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                MessageBox.Show("Complete el tipo y número de documento para efectuar la búsqueda.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Obtengo los datos del formulario
                string tipoDocumento = cboTipoDocumento.Text;
                int numeroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
                // Instanciamos un objeto Cliente para utilizar el metodo de buscarCliente
                Datos.Cliente buscarCliente = new Cliente();
                // Instanciamos un objeto E_Cliente para guardar todos los datos del cliente
                Entidades.E_Cliente cliente = buscarCliente.BuscarCliente(tipoDocumento, numeroDocumento);

                // Si el metodo buscar cliente devuelve los datos de un cliente, los muestro los datos en pantalla
                if (cliente != null)
                {
                    // Mostramos los datos en los controles del formulario
                    txtApellido.Text = cliente.Apellido;
                    txtNombre.Text = cliente.Nombre;
                    txtClienteID.Text = cliente.ClienteID.ToString();
                    txtTipoCliente.Text = cliente.TipoCliente;

                    if (cliente is Entidades.E_Socio socio)
                    {
                        lblCarnetSocio.Visible = true;
                        txtCarnetSocio.Visible = true;
                        lblFechaVencimiento.Visible = true;
                        txtFechaVencimiento.Visible = true;
                        txtCarnetSocio.Text = !string.IsNullOrEmpty(socio.CarnetSocioID) ? socio.CarnetSocioID : "Sin carnet de socio.";
                        txtFechaVencimiento.Text = socio.FechaVencimientoCuota.ToString("dd/MM/yyyy");
                        lblPlanActividad.Text = "Plan";

                        // Instanciamos un objeto PlanMembresia para utilizar el metodo de ObtenerPlanes
                        Datos.PlanMembresia planes = new PlanMembresia();
                        List<Tuple<string, decimal>> lista = planes.ObtenerPlanes();
                        cboListaPlanActividad.Enabled = true;
                        listarPlanesActividades(cboListaPlanActividad, lista);
                        cboCuotas.Enabled = false;
                        cboCuotas.SelectedIndex = 0;
                        cboMetodoPago.Enabled = true;
                        cboMetodoPago.SelectedIndex = 0;
                    }
                    else
                    {
                        lblCarnetSocio.Visible = false;
                        txtCarnetSocio.Visible = false;
                        lblFechaVencimiento.Visible = false;
                        txtFechaVencimiento.Visible = false;
                        lblPlanActividad.Text = "Actividad";
                        cboListaPlanActividad.Enabled = true;


                        // Instanciamos un objeto Actividad para utilizar el metodo de ObtenerActividades
                        Datos.Actividad actividades = new Actividad();
                        List<Tuple<string, decimal>> lista = actividades.ObtenerActividades();
                        cboListaPlanActividad.Enabled = true;
                        listarPlanesActividades(cboListaPlanActividad, lista);
                        cboCuotas.Enabled = false;
                        cboCuotas.SelectedIndex = 0;
                        cboMetodoPago.Enabled = true;
                        cboMetodoPago.SelectedIndex = 0;
                    }
                }
                else
                {
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                    txtClienteID.Text = "";
                    txtTipoCliente.Text = "";
                    txtCarnetSocio.Text = "";
                    txtFechaVencimiento.Text = "";
                    lblCarnetSocio.Visible = false;
                    txtCarnetSocio.Visible = false;
                    lblFechaVencimiento.Visible = false;
                    txtFechaVencimiento.Visible = false;
                    lblPlanActividad.Text = "Plan o Actividad";
                    cboListaPlanActividad.Enabled = false;
                    cboListaPlanActividad.SelectedIndex = -1;
                    txtPrecio.Text = null;
                    cboCuotas.Enabled = false;
                    cboCuotas.SelectedIndex = -1;
                    cboMetodoPago.Enabled = false;
                    cboMetodoPago.SelectedIndex = -1;
                }
            }
        }
        private void calcularValorCuota()
        {
            if (decimal.TryParse(txtPrecio.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out decimal precio) && int.TryParse(cboCuotas.Text, out int cuotas) && cuotas > 0)
            {
                decimal valorCuota = precio / cuotas;
                txtValorCuota.Text = valorCuota.ToString("C2"); // Formato moneda
            }
            else
            {
                txtValorCuota.Text = string.Empty;
            }
        }

        private void cboListaPlanActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListaPlanActividad.SelectedValue is decimal precio)
            {
                txtPrecio.Text = precio.ToString("C2"); // Formato de moneda
                calcularValorCuota();
            }

        }

        private void cboMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMetodoPago.Text == "Tarjeta de Credito" && txtTipoCliente.Text == "Socio")
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
                lblValorCuota.Visible = true;
                txtValorCuota.Visible = true;
                calcularValorCuota();
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = 0;
                lblValorCuota.Visible = false;
                txtValorCuota.Visible = false;
                txtValorCuota.Text = string.Empty;
            }
        }



        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularValorCuota();
        }

        private int identificadorPlanActividad(string nombre)
        {
            int identificador = -1;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query;

                if (txtTipoCliente.Text == "Socio")
                {
                    query = @"SELECT MembresiaID FROM PlanMembresia WHERE Plan = @nombre LIMIT 1";
                }
                else
                {
                    query = @"SELECT ActividadID FROM Actividad WHERE Nombre = @nombre LIMIT 1";
                }


                MySqlCommand comando = new MySqlCommand(query, sqlCon);


                comando.Parameters.AddWithValue("@nombre", nombre);

                sqlCon.Open();

                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    identificador = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el identificador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return identificador;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Validamos que los campos estén completos
            if (string.IsNullOrEmpty(txtClienteID.Text) || cboListaPlanActividad.SelectedIndex == -1 || cboMetodoPago.SelectedIndex == -1 || cboCuotas.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, complete todos los campos para realizar emitir la factura y realizar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Identifico el ID del Plan o la Actividad
            int id;
            id = identificadorPlanActividad(cboListaPlanActividad.Text);


            // Guardo todos los parametros necesarios para la emision de la factura y el pago en un objeto E_Pago
            Entidades.E_Pago pago = new Entidades.E_Pago();
            pago.ClienteID = Convert.ToInt32(txtClienteID.Text);
            pago.EsSocio = txtTipoCliente.Text == "Socio" ? true : false;
            pago.MembresiaID = pago.EsSocio ? id : 0; // Solo para socios
            pago.ActividadID = pago.EsSocio ? 0 : id; // Solo para actividades
            pago.MetodoPago = cboMetodoPago.SelectedItem.ToString();
            pago.Cuotas = Convert.ToInt32(cboCuotas.SelectedItem);

            // Confirmo los datos antes de efectuar el pago
            string mensajeConfirmacion = $"Cliente ID: {pago.ClienteID}\n" +
                                         $"Tipo de Cliente: {(pago.EsSocio ? "Socio" : "No Socio")}\n" +
                                         $"Plan o Actividad: {cboListaPlanActividad.Text}\n" +
                                         $"Método de Pago: {pago.MetodoPago}\n" +
                                         $"Cuotas: {pago.Cuotas}\n" +
                                         $"Monto: {txtPrecio.Text}"; // Asegúrate de agregar el monto correcto si lo tienes

            DialogResult dialogResult = MessageBox.Show(
            $"¿Confirmas que deseas realizar el pago con los siguientes datos?\n\n{mensajeConfirmacion}",
            "Confirmar Pago",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.No)
            {
                return; // Si no se confirma se cancela la operación
            }

            // Ahora creo una instancia de cliente Socio o No Socio para utilizar el metodo Registrar Pago

            int respuesta = 0;

            if (pago.EsSocio)
            {
                Datos.Socio socio = new Datos.Socio();
                respuesta = socio.RegistrarPago(pago);
            }
            else
            {
                Datos.NoSocio noSocio = new Datos.NoSocio();
                respuesta = noSocio.RegistrarPago(pago);
            }

            // Genero mi comprobante de pago todos los parametros necesarios en mi Factura
            Datos.Pago nuevoPago = new Datos.Pago();


            // Vemos la respuesta del sistema al generar el pago
            switch (respuesta)
            {
                case 1:
                    MessageBox.Show("El pago se efectuó correctamente.", "Pago Aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    factura = nuevoPago.cargarComprobante(factura);
                    btnVerComprobante.Enabled = true;
                    btnVolverPago.Enabled = false;
                    break;
                case 2:
                    MessageBox.Show("El pago se efectuó correctamente y se generó un nuevo carnet de Socio. ¡Ahora puedes verlo!", "Pago Aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    factura = nuevoPago.cargarComprobante(factura);
                    btnVerComprobante.Enabled = true;
                    btnVolverPago.Enabled = true;
                    break;
                case -1:
                    MessageBox.Show("El cliente no existe. Por favor, verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnVerComprobante.Enabled = false;
                    btnVolverPago.Enabled = false;
                    break;
                case -2:
                    MessageBox.Show("Hubo un error al procesar el pago. Por favor, intente nuevamente.", "Error en SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnVerComprobante.Enabled = false;
                    btnVolverPago.Enabled = false;
                    break;
                default:
                    MessageBox.Show("Ocurrió un error inesperado. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnVerComprobante.Enabled = false;
                    btnVolverPago.Enabled = false;
                    break;
            }
        }


        private void btnVerComprobante_Click(object sender, EventArgs e)
        {
            factura.Show();
            this.Hide();
        }

        private void btnVolverPago_Click(object sender, EventArgs e)
        {
            FormPrincipal Principal = new FormPrincipal();
            Principal.Show(); // llama al formulario 
            this.Close();
        }
    }

}
