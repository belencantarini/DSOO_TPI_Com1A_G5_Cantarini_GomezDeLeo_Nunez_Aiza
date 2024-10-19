using DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza
{
    public partial class FormInscripcion : Form
    {
        public FormInscripcion()
        {
            InitializeComponent();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal Principal = new FormPrincipal();
            Principal.Show(); // llama al formulario 
            this.Close();
        }



        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(cboTipoDocumento.Text) || string.IsNullOrEmpty(txtNumeroDocumento.Text) || string.IsNullOrEmpty(dtpFechaNacimiento.Text) || (!rbnSocio.Checked && !rbnNoSocio.Checked))
            {
                MessageBox.Show("Complete todos los datos antes de enviar.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbnSocio.Checked)
                {
                    E_Socio nuevoESocio = new E_Socio();
                    nuevoESocio.Nombre = txtNombre.Text;
                    nuevoESocio.Apellido = txtApellido.Text;
                    nuevoESocio.TipoDocumento = cboTipoDocumento.Text;
                    if (int.TryParse(txtNumeroDocumento.Text, out int numeroDocumento))
                    {
                        nuevoESocio.NumeroDocumento = numeroDocumento;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número válido en el campo Documento.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                    nuevoESocio.FechaNacimiento = dtpFechaNacimiento.Value;
                    nuevoESocio.AptoFisico = chkAptoFisico.Checked;


                    // instanciamos para usar el metodo dentro de Socio
                    Datos.Socio nuevoSocio = new Datos.Socio();
                    string respuesta = nuevoSocio.Nuevo_Socio(nuevoESocio);
                    bool esnumero = int.TryParse(respuesta, out int codigo);
                    if (esnumero)
                    {
                        if (codigo == 0)
                        {
                            MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("se almaceno el SOCIO con exito con el ID de cliente Nro " + respuesta, "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                            btnLimpiar_Click(sender, e);
                        }
                    }
                }

                else
                {
                    E_NoSocio nuevoENoSocio = new E_NoSocio();
                    nuevoENoSocio.Nombre = txtNombre.Text;
                    nuevoENoSocio.Apellido = txtApellido.Text;
                    nuevoENoSocio.TipoDocumento = cboTipoDocumento.Text;
                    if (int.TryParse(txtNumeroDocumento.Text, out int numeroDocumento2))
                    {
                        nuevoENoSocio.NumeroDocumento = numeroDocumento2;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número válido en el campo Documento.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                    nuevoENoSocio.FechaNacimiento = dtpFechaNacimiento.Value;
                    nuevoENoSocio.AptoFisico = chkAptoFisico.Checked;


                    // instanciamos para usar el metodo dentro de Socio
                    Datos.NoSocio nuevoNoSocio = new Datos.NoSocio();
                    string respuesta2 = nuevoNoSocio.Nuevo_NoSocio(nuevoENoSocio);
                    bool esnumero2 = int.TryParse(respuesta2, out int codigo2);

                    if (esnumero2)
                    {
                        if (codigo2 == 0)
                        {
                            MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("se almaceno el NO SOCIO con exito con el ID de cliente Nro " + respuesta2, "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                            btnLimpiar_Click(sender, e);
                        }
                    }
                }
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboTipoDocumento.Text = "";
            txtNumeroDocumento.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            chkAptoFisico.Checked = false;
            txtApellido.Focus();
        }


        private void chkAptoFisico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                chkAptoFisico.Checked = !chkAptoFisico.Checked;
                e.SuppressKeyPress = true;
            }
        }

        private void FormInscripcion_Load(object sender, EventArgs e)
        {

        }

    }
}
