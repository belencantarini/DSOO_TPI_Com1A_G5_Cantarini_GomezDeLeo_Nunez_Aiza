using G5_TPI_ClubDeportivo.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;

namespace G5_TPI_ClubDeportivo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
                txtUsuario.SelectionStart = 0;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.ForeColor = Color.Gray;
                txtUsuario.Text = "Usuario";
            }
        }

        private void VisibilidadPassword()
        {
            if (chkPass.Checked || txtPassword.Text == "Contraseña")
            {
                txtPassword.UseSystemPasswordChar = false; // Mostrar texto
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Ocultar texto
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.SelectionStart = 0;
            }
            VisibilidadPassword();
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                VisibilidadPassword();
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void chkPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                chkPass.Checked = !chkPass.Checked;
                VisibilidadPassword();
                e.SuppressKeyPress = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuario dato = new Datos.Usuario(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Login_Usuario(txtUsuario.Text, txtPassword.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el  usuario EXISTE
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipal Principal = new FormPrincipal();
                /*
                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);
                */
                Principal.Show(); // llama al formulario 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrectos.");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
