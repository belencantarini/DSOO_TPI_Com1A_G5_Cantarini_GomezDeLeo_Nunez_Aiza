namespace G5_TPI_ClubDeportivo
{
    partial class FormBuscarSocio
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
            lblBuscarSocio = new Label();
            gpbCliente = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtFechaVencimiento = new TextBox();
            lblFechaVencimiento = new Label();
            txtCarnetSocio = new TextBox();
            lblCarnetSocio = new Label();
            txtTipoCliente = new TextBox();
            lblTipoCliente = new Label();
            txtClienteID = new TextBox();
            lblClienteID = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblNumeroDocumento = new Label();
            btnBuscarCliente = new Button();
            lblTipoDocumento = new Label();
            txtNumeroDocumento = new TextBox();
            cboTipoDocumento = new ComboBox();
            btnVolverBuscarSocio = new Button();
            btnImprimirCarnet = new Button();
            gpbCliente.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBuscarSocio
            // 
            lblBuscarSocio.AutoSize = true;
            lblBuscarSocio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarSocio.Location = new Point(38, 43);
            lblBuscarSocio.Name = "lblBuscarSocio";
            lblBuscarSocio.Size = new Size(280, 32);
            lblBuscarSocio.TabIndex = 0;
            lblBuscarSocio.Text = "Imprimir Carnet de Socio";
            // 
            // gpbCliente
            // 
            gpbCliente.Controls.Add(tableLayoutPanel1);
            gpbCliente.Controls.Add(lblNumeroDocumento);
            gpbCliente.Controls.Add(btnBuscarCliente);
            gpbCliente.Controls.Add(lblTipoDocumento);
            gpbCliente.Controls.Add(txtNumeroDocumento);
            gpbCliente.Controls.Add(cboTipoDocumento);
            gpbCliente.Location = new Point(38, 110);
            gpbCliente.Name = "gpbCliente";
            gpbCliente.Size = new Size(847, 281);
            gpbCliente.TabIndex = 0;
            gpbCliente.TabStop = false;
            gpbCliente.Text = "Cliente";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(txtFechaVencimiento, 3, 2);
            tableLayoutPanel1.Controls.Add(lblFechaVencimiento, 2, 2);
            tableLayoutPanel1.Controls.Add(txtCarnetSocio, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCarnetSocio, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTipoCliente, 3, 1);
            tableLayoutPanel1.Controls.Add(lblTipoCliente, 2, 1);
            tableLayoutPanel1.Controls.Add(txtClienteID, 1, 1);
            tableLayoutPanel1.Controls.Add(lblClienteID, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNombre, 3, 0);
            tableLayoutPanel1.Controls.Add(txtApellido, 1, 0);
            tableLayoutPanel1.Controls.Add(lblApellido, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNombre, 2, 0);
            tableLayoutPanel1.Location = new Point(18, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(810, 137);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Location = new Point(540, 93);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.ReadOnly = true;
            txtFechaVencimiento.Size = new Size(219, 27);
            txtFechaVencimiento.TabIndex = 11;
            txtFechaVencimiento.TabStop = false;
            txtFechaVencimiento.Visible = false;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(406, 90);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(91, 40);
            lblFechaVencimiento.TabIndex = 10;
            lblFechaVencimiento.Text = "Fecha de Vencimiento";
            lblFechaVencimiento.Visible = false;
            // 
            // txtCarnetSocio
            // 
            txtCarnetSocio.Location = new Point(137, 93);
            txtCarnetSocio.Name = "txtCarnetSocio";
            txtCarnetSocio.ReadOnly = true;
            txtCarnetSocio.Size = new Size(215, 27);
            txtCarnetSocio.TabIndex = 9;
            txtCarnetSocio.TabStop = false;
            txtCarnetSocio.Visible = false;
            // 
            // lblCarnetSocio
            // 
            lblCarnetSocio.AutoSize = true;
            lblCarnetSocio.Location = new Point(3, 90);
            lblCarnetSocio.Name = "lblCarnetSocio";
            lblCarnetSocio.Size = new Size(114, 20);
            lblCarnetSocio.TabIndex = 5;
            lblCarnetSocio.Text = "Carnet de Socio";
            lblCarnetSocio.Visible = false;
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(540, 48);
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.ReadOnly = true;
            txtTipoCliente.Size = new Size(219, 27);
            txtTipoCliente.TabIndex = 7;
            txtTipoCliente.TabStop = false;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(406, 45);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(110, 20);
            lblTipoCliente.TabIndex = 6;
            lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(137, 48);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.ReadOnly = true;
            txtClienteID.Size = new Size(215, 27);
            txtClienteID.TabIndex = 5;
            txtClienteID.TabStop = false;
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Location = new Point(3, 45);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(74, 20);
            lblClienteID.TabIndex = 4;
            lblClienteID.Text = "Cliente ID";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(540, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(219, 27);
            txtNombre.TabIndex = 3;
            txtNombre.TabStop = false;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(215, 27);
            txtApellido.TabIndex = 1;
            txtApellido.TabStop = false;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(3, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(406, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(349, 46);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(164, 20);
            lblNumeroDocumento.TabIndex = 2;
            lblNumeroDocumento.Text = "Número de documento";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarCliente.Location = new Point(661, 64);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(149, 35);
            btnBuscarCliente.TabIndex = 3;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(18, 46);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(140, 20);
            lblTipoDocumento.TabIndex = 1;
            lblTipoDocumento.Text = "Tipo de documento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(349, 70);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(270, 27);
            txtNumeroDocumento.TabIndex = 2;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Items.AddRange(new object[] { "DNI", "Pasaporte", "Libreta Cívica", "Libreta de Enrolamiento" });
            cboTipoDocumento.Location = new Point(18, 69);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(270, 28);
            cboTipoDocumento.TabIndex = 1;
            // 
            // btnVolverBuscarSocio
            // 
            btnVolverBuscarSocio.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverBuscarSocio.Location = new Point(557, 407);
            btnVolverBuscarSocio.Name = "btnVolverBuscarSocio";
            btnVolverBuscarSocio.Size = new Size(211, 72);
            btnVolverBuscarSocio.TabIndex = 2;
            btnVolverBuscarSocio.Text = "Volver";
            btnVolverBuscarSocio.UseVisualStyleBackColor = true;
            btnVolverBuscarSocio.Click += btnVolverBuscarSocio_Click;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.Enabled = false;
            btnImprimirCarnet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirCarnet.Location = new Point(170, 407);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(293, 72);
            btnImprimirCarnet.TabIndex = 1;
            btnImprimirCarnet.Text = "Ver Carnet de Socio";
            btnImprimirCarnet.UseVisualStyleBackColor = true;
            btnImprimirCarnet.Click += btnImprimirCarnet_Click;
            // 
            // FormBuscarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 503);
            Controls.Add(btnImprimirCarnet);
            Controls.Add(btnVolverBuscarSocio);
            Controls.Add(gpbCliente);
            Controls.Add(lblBuscarSocio);
            Name = "FormBuscarSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarSocio";
            gpbCliente.ResumeLayout(false);
            gpbCliente.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscarSocio;
        private GroupBox gpbCliente;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtFechaVencimiento;
        private Label lblFechaVencimiento;
        private TextBox txtCarnetSocio;
        private Label lblCarnetSocio;
        private TextBox txtTipoCliente;
        private Label lblTipoCliente;
        private TextBox txtClienteID;
        private Label lblClienteID;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblNumeroDocumento;
        private Button btnBuscarCliente;
        private Label lblTipoDocumento;
        private TextBox txtNumeroDocumento;
        private ComboBox cboTipoDocumento;
        private Button btnVolverBuscarSocio;
        private Button btnImprimirCarnet;
    }
}