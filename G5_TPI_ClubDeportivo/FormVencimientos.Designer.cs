namespace G5_TPI_ClubDeportivo
{
    partial class FormVencimientos
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
            btnVolverVencimientos = new Button();
            dtgvVencimientos = new DataGridView();
            ClienteID = new DataGridViewTextBoxColumn();
            CarnetSocioID = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaVencimientoCuota = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvVencimientos).BeginInit();
            SuspendLayout();
            // 
            // btnVolverVencimientos
            // 
            btnVolverVencimientos.Location = new Point(405, 334);
            btnVolverVencimientos.Name = "btnVolverVencimientos";
            btnVolverVencimientos.Size = new Size(157, 42);
            btnVolverVencimientos.TabIndex = 0;
            btnVolverVencimientos.Text = "VOLVER";
            btnVolverVencimientos.UseVisualStyleBackColor = true;
            btnVolverVencimientos.Click += btnVolverVencimientos_Click;
            // 
            // dtgvVencimientos
            // 
            dtgvVencimientos.AllowUserToAddRows = false;
            dtgvVencimientos.AllowUserToDeleteRows = false;
            dtgvVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVencimientos.Columns.AddRange(new DataGridViewColumn[] { ClienteID, CarnetSocioID, Apellido, Nombre, FechaVencimientoCuota });
            dtgvVencimientos.Location = new Point(63, 65);
            dtgvVencimientos.Name = "dtgvVencimientos";
            dtgvVencimientos.ReadOnly = true;
            dtgvVencimientos.RowHeadersWidth = 51;
            dtgvVencimientos.RowTemplate.Height = 29;
            dtgvVencimientos.Size = new Size(858, 188);
            dtgvVencimientos.TabIndex = 1;
            dtgvVencimientos.CellContentClick += dtgvVencimientos_CellContentClick;
            // 
            // ClienteID
            // 
            ClienteID.HeaderText = "ID de Cliente";
            ClienteID.MinimumWidth = 6;
            ClienteID.Name = "ClienteID";
            ClienteID.ReadOnly = true;
            ClienteID.Width = 125;
            // 
            // CarnetSocioID
            // 
            CarnetSocioID.HeaderText = "Carnet de Socio";
            CarnetSocioID.MinimumWidth = 6;
            CarnetSocioID.Name = "CarnetSocioID";
            CarnetSocioID.ReadOnly = true;
            CarnetSocioID.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // FechaVencimientoCuota
            // 
            FechaVencimientoCuota.HeaderText = "Fecha de Vencimiento de Cuota";
            FechaVencimientoCuota.MinimumWidth = 6;
            FechaVencimientoCuota.Name = "FechaVencimientoCuota";
            FechaVencimientoCuota.ReadOnly = true;
            FechaVencimientoCuota.Width = 125;
            // 
            // FormVencimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
            Controls.Add(dtgvVencimientos);
            Controls.Add(btnVolverVencimientos);
            Name = "FormVencimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVencimientos";
            Load += FormVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVencimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolverVencimientos;
        private DataGridView dtgvVencimientos;
        private DataGridViewTextBoxColumn ClienteID;
        private DataGridViewTextBoxColumn CarnetSocioID;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaVencimientoCuota;
    }
}