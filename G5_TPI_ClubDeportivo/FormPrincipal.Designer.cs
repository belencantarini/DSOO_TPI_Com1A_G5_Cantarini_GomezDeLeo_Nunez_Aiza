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
            btnNoSocios = new Button();
            btnPagos = new Button();
            btnVencimientos = new Button();
            btnSalirSesion = new Button();
            btnListaSociosNoSocios = new Button();
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
            btnInscribirCliente.Location = new Point(25, 109);
            btnInscribirCliente.Name = "btnInscribirCliente";
            btnInscribirCliente.Size = new Size(214, 89);
            btnInscribirCliente.TabIndex = 0;
            btnInscribirCliente.Text = "Nuevos Clientes";
            btnInscribirCliente.UseVisualStyleBackColor = true;
            btnInscribirCliente.Click += btnInscribirCliente_Click;
            // 
            // btnSocios
            // 
            btnSocios.Location = new Point(25, 218);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(214, 89);
            btnSocios.TabIndex = 2;
            btnSocios.Text = "Planes para Socios";
            btnSocios.UseVisualStyleBackColor = true;
            // 
            // btnNoSocios
            // 
            btnNoSocios.Location = new Point(25, 331);
            btnNoSocios.Name = "btnNoSocios";
            btnNoSocios.Size = new Size(214, 89);
            btnNoSocios.TabIndex = 4;
            btnNoSocios.Text = "Actividades para No Socios";
            btnNoSocios.UseVisualStyleBackColor = true;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(276, 218);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(214, 89);
            btnPagos.TabIndex = 3;
            btnPagos.Text = "Pagar Membresia y Actividades";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnVencimientos
            // 
            btnVencimientos.Location = new Point(276, 331);
            btnVencimientos.Name = "btnVencimientos";
            btnVencimientos.Size = new Size(214, 89);
            btnVencimientos.TabIndex = 5;
            btnVencimientos.Text = "Ver vencimientos del día";
            btnVencimientos.UseVisualStyleBackColor = true;
            btnVencimientos.Click += btnVencimientos_Click;
            // 
            // btnSalirSesion
            // 
            btnSalirSesion.Location = new Point(182, 450);
            btnSalirSesion.Name = "btnSalirSesion";
            btnSalirSesion.Size = new Size(179, 48);
            btnSalirSesion.TabIndex = 6;
            btnSalirSesion.Text = "Salir de la sesión";
            btnSalirSesion.UseVisualStyleBackColor = true;
            btnSalirSesion.Click += btnSalirSesion_Click;
            // 
            // btnListaSociosNoSocios
            // 
            btnListaSociosNoSocios.Location = new Point(276, 109);
            btnListaSociosNoSocios.Name = "btnListaSociosNoSocios";
            btnListaSociosNoSocios.Size = new Size(214, 89);
            btnListaSociosNoSocios.TabIndex = 1;
            btnListaSociosNoSocios.Text = "Listado de Clientes";
            btnListaSociosNoSocios.UseVisualStyleBackColor = true;
            btnListaSociosNoSocios.Click += btnListaSociosNoSocios_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 600);
            Controls.Add(btnListaSociosNoSocios);
            Controls.Add(btnSalirSesion);
            Controls.Add(btnVencimientos);
            Controls.Add(btnPagos);
            Controls.Add(btnNoSocios);
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
        private Button btnNoSocios;
        private Button btnPagos;
        private Button btnVencimientos;
        private Button btnSalirSesion;
        private Button btnListaSociosNoSocios;
    }
}