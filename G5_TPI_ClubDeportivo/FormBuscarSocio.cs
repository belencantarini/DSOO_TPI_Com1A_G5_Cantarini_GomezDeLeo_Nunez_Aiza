using G5_TPI_ClubDeportivo.Datos;
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
    public partial class FormBuscarSocio : Form
    {
        public FormCarnetSocio carnet = new FormCarnetSocio();
        public FormBuscarSocio()
        {
            InitializeComponent();
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
                        btnImprimirCarnet.Enabled = true;

                    }
                    else
                    {
                        lblCarnetSocio.Visible = false;
                        txtCarnetSocio.Visible = false;
                        lblFechaVencimiento.Visible = false;
                        txtFechaVencimiento.Visible = false;
                        MessageBox.Show("El cliente no se encuentra registrado como SOCIO.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnImprimirCarnet.Enabled = false;
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
                    btnImprimirCarnet.Enabled = false;
                }
            }
        }

        private void btnVolverBuscarSocio_Click(object sender, EventArgs e)
        {
            FormPrincipal Principal = new FormPrincipal();
            Principal.Show(); // llama al formulario 
            this.Close();
        }

        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            // Validamos que los campos estén completos
            if (string.IsNullOrEmpty(txtClienteID.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para realizar emitir la factura y realizar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validamos que el cliente sea un socio
            if (txtTipoCliente.Text != "Socio")
            {
                MessageBox.Show("El cliente no se encuentra registrado como socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Validamos que el cliente tenga un carnet generado
                if (txtCarnetSocio.Text == "Sin carnet de socio.")
                {
                    MessageBox.Show("El cliente aun no posee carnet de socio, debe primero efectuar un pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Guardo el numero de cliente
                    int cliente = Convert.ToInt32(txtClienteID.Text);

                    // Genero una instancia de socio para utilizar el metodo para cargar los datos del carnet
                    Datos.Socio socio = new Datos.Socio();

                    // Paso los parametros de ClienteID y el FormCarnet que hay que completar segun el cliente ID y lo visualizamos
                    carnet = socio.cargarCarnet(cliente, carnet);
                    carnet.Show();
                    this.Hide();
                }

            }

        }
    }
}
