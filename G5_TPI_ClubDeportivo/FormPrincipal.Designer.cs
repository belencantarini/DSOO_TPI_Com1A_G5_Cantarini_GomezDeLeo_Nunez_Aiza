namespace G5_TPI_ClubDeportivo
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIngreso = new Label();
            btnInscribirCliente = new Button();
            btnSocios = new Button();
            btnPagos = new Button();
            btnVencimientos = new Button();
            btnSalirSesion = new Button();
            btnListaSociosNoSocios = new Button();
            btnCarnet = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngreso.Location = new Point(25, 48);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(179, 32);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Inicio de sesión";
            // 
            // btnInscribirCliente
            // 
            btnInscribirCliente.Location = new Point(25, 117);
            btnInscribirCliente.Name = "btnInscribirCliente";
            btnInscribirCliente.Size = new Size(214, 89);
            btnInscribirCliente.TabIndex = 1;
            btnInscribirCliente.Text = "Nuevos Clientes";
            btnInscribirCliente.UseVisualStyleBackColor = true;
            btnInscribirCliente.Click += btnInscribirCliente_Click;
            // 
            // btnSocios
            // 
            btnSocios.Location = new Point(276, 223);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(214, 89);
            btnSocios.TabIndex = 4;
            btnSocios.Text = "Planes para Socios y Actividades para No Socios";
            btnSocios.UseVisualStyleBackColor = true;
            btnSocios.Click += btnSocios_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(25, 333);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(465, 62);
            btnPagos.TabIndex = 5;
            btnPagos.Text = "Pagar Membresias y Actividades";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnVencimientos
            // 
            btnVencimientos.Location = new Point(25, 411);
            btnVencimientos.Name = "btnVencimientos";
            btnVencimientos.Size = new Size(465, 62);
            btnVencimientos.TabIndex = 6;
            btnVencimientos.Text = "Ver vencimientos del día";
            btnVencimientos.UseVisualStyleBackColor = true;
            btnVencimientos.Click += btnVencimientos_Click;
            // 
            // btnSalirSesion
            // 
            btnSalirSesion.Location = new Point(170, 524);
            btnSalirSesion.Name = "btnSalirSesion";
            btnSalirSesion.Size = new Size(179, 48);
            btnSalirSesion.TabIndex = 7;
            btnSalirSesion.Text = "Salir de la sesión";
            btnSalirSesion.UseVisualStyleBackColor = true;
            btnSalirSesion.Click += btnSalirSesion_Click;
            // 
            // btnListaSociosNoSocios
            // 
            btnListaSociosNoSocios.Location = new Point(276, 117);
            btnListaSociosNoSocios.Name = "btnListaSociosNoSocios";
            btnListaSociosNoSocios.Size = new Size(214, 89);
            btnListaSociosNoSocios.TabIndex = 2;
            btnListaSociosNoSocios.Text = "Listado de Clientes";
            btnListaSociosNoSocios.UseVisualStyleBackColor = true;
            btnListaSociosNoSocios.Click += btnListaSociosNoSocios_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.Location = new Point(25, 223);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(214, 89);
            btnCarnet.TabIndex = 3;
            btnCarnet.Text = "Ver Carnet Socio";
            btnCarnet.UseVisualStyleBackColor = true;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 600);
            Controls.Add(btnCarnet);
            Controls.Add(btnListaSociosNoSocios);
            Controls.Add(btnSalirSesion);
            Controls.Add(btnVencimientos);
            Controls.Add(btnPagos);
            Controls.Add(btnSocios);
            Controls.Add(btnInscribirCliente);
            Controls.Add(lblIngreso);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sesión";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnInscribirCliente;
        private Button btnSocios;
        private Button btnPagos;
        private Button btnVencimientos;
        private Button btnSalirSesion;
        private Button btnListaSociosNoSocios;
        private Button btnCarnet;
    }
}