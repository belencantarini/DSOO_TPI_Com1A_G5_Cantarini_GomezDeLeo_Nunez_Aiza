using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_TPI_ClubDeportivo
{
    public partial class FormFactura : Form
    {

        public FormFactura()
        {
            InitializeComponent();
        }

        // Datos de mi factura


        public int FacturaID;
        public int ClienteID;
        public string Apellido;
        public string Nombre;
        public string TipoDocumento;
        public int NumeroDocumento;
        public int? MembresiaID;
        public string? PlanMembresia;
        public int? ActividadID;
        public string? Actividad;
        public decimal Monto;
        public string MetodoPago;
        public int Cuotas;
        public DateTime FechaPago;


        private void FormFactura_Load(object sender, EventArgs e)
        {
            try
            {
                lblVarNroFactura.Text = FacturaID.ToString();
                lblVarFecha.Text = FechaPago.ToString("dd/MM/yyyy");
                txtVarApellido.Text = Apellido ?? "Sin Apellido";
                txtVarNombre.Text = Nombre ?? "Sin Nombre";
                txtVarTipoDoc.Text = TipoDocumento ?? "N/A";
                txtVarNroDoc.Text = NumeroDocumento.ToString();
                txtVarActividad.Text = Actividad ?? "N/A";
                txtVarPrecioAct.Text = Actividad != "N/A" ? Monto.ToString("C2") : string.Empty;
                txtVarPlan.Text = PlanMembresia ?? "N/A";
                txtVarPrecioPlan.Text = PlanMembresia != "N/A" ? Monto.ToString("C2") : string.Empty;
                txtVarMetodoPago.Text = MetodoPago ?? "N/A";
                txtVarCuotas.Text = Cuotas.ToString();
                lblVarTotal.Text = Monto.ToString("C2");
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


        // Boton Imprimir
            private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            // Ocultamos el boton para imprimir
            btnImprimirFactura.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimirFactura.Visible = true; // visualizamos nuevamente el boton

            // Volvemos al form de inicio
            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Close();

        }


    }
}
