using G5_TPI_ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_TPI_ClubDeportivo
{
    public partial class FormCarnetSocio : Form
    {
        public FormCarnetSocio()
        {
            InitializeComponent();
        }

        // Datos de mi carnet
        public string? CarnetSocioID;
        public string Apellido;
        public string Nombre;
        public string TipoDocumento;
        public int NumeroDocumento;
        public int? MembresiaID;
        public bool AptoFisico;
        public DateTime FechaNacimiento;
        public DateTime FechaInscripcion;
        public DateTime FechaVencimiento;

        // Cargo todos los datos del carnet al formulario
        private void FormCarnetSocio_Load(object sender, EventArgs e)
        {
            try
            {
                lblVarCarnet.Text = CarnetSocioID ?? "Sin carnet generado"; ;
                txtVarApellido.Text = Apellido ?? "Sin Apellido";
                txtVarNombre.Text = Nombre ?? "Sin Nombre";
                txtVarTipoDoc.Text = TipoDocumento ?? "N/A";
                txtVarNroDoc.Text = NumeroDocumento.ToString();
                txtVarNacimiento.Text = FechaNacimiento.ToString("dd/MM/yyyy");
                txtVarInscripcion.Text = FechaInscripcion.ToString("dd/MM/yyyy");
                txtVarApto.Text = AptoFisico ? "Entregado":"Pendiente";
                txtVarVencimiento.Text = FechaVencimiento.ToString("dd/MM/yyyy");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Sentencias necesarias para imprimir documento
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        // Boton para imprimir el carnet
        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            // Ocultamos el boton para imprimir y para volver
            btnImprimirCarnet.Visible = false;
            btnVolver.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimirCarnet.Visible = true; // visualizamos nuevamente el boton
            btnVolver.Visible = true;

            // Volvemos al form de inicio
            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormBuscarSocio buscarSocio = new FormBuscarSocio();
            buscarSocio.Show(); // llama al formulario 
            this.Close();
        }
    }
}
