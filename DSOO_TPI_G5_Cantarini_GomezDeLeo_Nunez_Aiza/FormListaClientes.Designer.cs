namespace DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza
{
    partial class FormListaClientes
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
            btnVolver = new Button();
            dtgvClientes = new DataGridView();
            ClienteID = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            FechaInscripcion = new DataGridViewTextBoxColumn();
            AptoFisico = new DataGridViewTextBoxColumn();
            TipoCliente = new DataGridViewTextBoxColumn();
            lblListadoClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(524, 396);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(157, 42);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dtgvClientes
            // 
            dtgvClientes.AllowUserToOrderColumns = true;
            dtgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClientes.Columns.AddRange(new DataGridViewColumn[] { ClienteID, Apellido, Nombre, TipoDocumento, NumeroDocumento, FechaNacimiento, Edad, FechaInscripcion, AptoFisico, TipoCliente });
            dtgvClientes.Location = new Point(59, 112);
            dtgvClientes.Name = "dtgvClientes";
            dtgvClientes.RowHeadersWidth = 51;
            dtgvClientes.RowTemplate.Height = 29;
            dtgvClientes.Size = new Size(1087, 260);
            dtgvClientes.TabIndex = 1;
            dtgvClientes.CellContentClick += dtgvClientes_CellContentClick;
            // 
            // ClienteID
            // 
            ClienteID.HeaderText = "ID de cliente";
            ClienteID.MinimumWidth = 6;
            ClienteID.Name = "ClienteID";
            ClienteID.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo documento";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.Width = 125;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero de documento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Width = 125;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha de nacimiento";
            FechaNacimiento.MinimumWidth = 6;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Visible = false;
            FechaNacimiento.Width = 125;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.Width = 125;
            // 
            // FechaInscripcion
            // 
            FechaInscripcion.HeaderText = "Fecha de inscripcion";
            FechaInscripcion.MinimumWidth = 6;
            FechaInscripcion.Name = "FechaInscripcion";
            FechaInscripcion.Visible = false;
            FechaInscripcion.Width = 125;
            // 
            // AptoFisico
            // 
            AptoFisico.HeaderText = "Apto físico";
            AptoFisico.MinimumWidth = 6;
            AptoFisico.Name = "AptoFisico";
            AptoFisico.Width = 125;
            // 
            // TipoCliente
            // 
            TipoCliente.HeaderText = "Tipo de cliente";
            TipoCliente.MinimumWidth = 6;
            TipoCliente.Name = "TipoCliente";
            TipoCliente.Width = 125;
            // 
            // lblListadoClientes
            // 
            lblListadoClientes.AutoSize = true;
            lblListadoClientes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblListadoClientes.Location = new Point(74, 54);
            lblListadoClientes.Name = "lblListadoClientes";
            lblListadoClientes.Size = new Size(211, 32);
            lblListadoClientes.TabIndex = 2;
            lblListadoClientes.Text = "Listado de clientes";
            // 
            // FormListaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 472);
            Controls.Add(lblListadoClientes);
            Controls.Add(dtgvClientes);
            Controls.Add(btnVolver);
            Name = "FormListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Clientes";
            Load += FormListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dtgvClientes;
        private Label lblListadoClientes;
        private DataGridViewTextBoxColumn ClienteID;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn FechaInscripcion;
        private DataGridViewTextBoxColumn AptoFisico;
        private DataGridViewTextBoxColumn TipoCliente;
    }
}