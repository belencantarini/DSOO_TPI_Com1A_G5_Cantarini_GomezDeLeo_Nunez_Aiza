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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            /*
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol +
            ")";
            */
        }

        private void btnInscribirCliente_Click(object sender, EventArgs e)
        {
            FormInscripcion Inscripcion = new FormInscripcion();
            Inscripcion.Show(); // llama al formulario 
            this.Hide();
        }

        private void btnSalirSesion_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.Show(); // llama al formulario 
            this.Close();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {

        }

        private void btnListaSociosNoSocios_Click(object sender, EventArgs e)
        {
            FormListaClientes ListaClientes = new FormListaClientes();
            ListaClientes.Show(); // llama al formulario 
            this.Hide();
        }

        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            FormVencimientos ListaVencimientos = new FormVencimientos();
            ListaVencimientos.Show(); // llama al formulario 
            this.Hide();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            FormPlanesyActividades ListaPrecios = new FormPlanesyActividades();
            ListaPrecios.Show(); // llama al formulario 
            this.Hide();
        }
    }
}

