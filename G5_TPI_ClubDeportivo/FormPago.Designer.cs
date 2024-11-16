namespace G5_TPI_ClubDeportivo
{
    partial class FormPago
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
            lblPagarTitulo = new Label();
            txtNumeroDocumento = new TextBox();
            cboTipoDocumento = new ComboBox();
            lblNumeroDocumento = new Label();
            lblTipoDocumento = new Label();
            btnBuscarCliente = new Button();
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
            gpbPagar = new GroupBox();
            btnVolverPago = new Button();
            btnVerComprobante = new Button();
            btnPagar = new Button();
            txtValorCuota = new TextBox();
            lblValorCuota = new Label();
            cboCuotas = new ComboBox();
            lblCuotas = new Label();
            cboMetodoPago = new ComboBox();
            lblMetodoPago = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblPlanActividad = new Label();
            cboListaPlanActividad = new ComboBox();
            lblPago = new Label();
            btnVolver = new Button();
            gpbCliente.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gpbPagar.SuspendLayout();
            SuspendLayout();
            // 
            // lblPagarTitulo
            // 
            lblPagarTitulo.AutoSize = true;
            lblPagarTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagarTitulo.Location = new Point(66, 38);
            lblPagarTitulo.Name = "lblPagarTitulo";
            lblPagarTitulo.Size = new Size(383, 32);
            lblPagarTitulo.TabIndex = 3;
            lblPagarTitulo.Text = "Pago de Membresias y Actividades";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(349, 70);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(270, 27);
            txtNumeroDocumento.TabIndex = 13;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Items.AddRange(new object[] { "DNI", "Pasaporte", "Libreta Cívica", "Libreta de Enrolamiento" });
            cboTipoDocumento.Location = new Point(18, 69);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(270, 28);
            cboTipoDocumento.TabIndex = 12;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(349, 46);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(164, 20);
            lblNumeroDocumento.TabIndex = 14;
            lblNumeroDocumento.Text = "Número de documento";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(18, 46);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(140, 20);
            lblTipoDocumento.TabIndex = 15;
            lblTipoDocumento.Text = "Tipo de documento";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarCliente.Location = new Point(661, 64);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(149, 35);
            btnBuscarCliente.TabIndex = 16;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // gpbCliente
            // 
            gpbCliente.Controls.Add(tableLayoutPanel1);
            gpbCliente.Controls.Add(lblNumeroDocumento);
            gpbCliente.Controls.Add(btnBuscarCliente);
            gpbCliente.Controls.Add(lblTipoDocumento);
            gpbCliente.Controls.Add(txtNumeroDocumento);
            gpbCliente.Controls.Add(cboTipoDocumento);
            gpbCliente.Location = new Point(66, 87);
            gpbCliente.Name = "gpbCliente";
            gpbCliente.Size = new Size(847, 281);
            gpbCliente.TabIndex = 17;
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
            tableLayoutPanel1.TabIndex = 17;
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Location = new Point(540, 93);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.ReadOnly = true;
            txtFechaVencimiento.Size = new Size(219, 27);
            txtFechaVencimiento.TabIndex = 29;
            txtFechaVencimiento.Visible = false;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(406, 90);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(91, 40);
            lblFechaVencimiento.TabIndex = 28;
            lblFechaVencimiento.Text = "Fecha de Vencimiento";
            lblFechaVencimiento.Visible = false;
            // 
            // txtCarnetSocio
            // 
            txtCarnetSocio.Location = new Point(137, 93);
            txtCarnetSocio.Name = "txtCarnetSocio";
            txtCarnetSocio.ReadOnly = true;
            txtCarnetSocio.Size = new Size(215, 27);
            txtCarnetSocio.TabIndex = 27;
            txtCarnetSocio.Visible = false;
            // 
            // lblCarnetSocio
            // 
            lblCarnetSocio.AutoSize = true;
            lblCarnetSocio.Location = new Point(3, 90);
            lblCarnetSocio.Name = "lblCarnetSocio";
            lblCarnetSocio.Size = new Size(114, 20);
            lblCarnetSocio.TabIndex = 26;
            lblCarnetSocio.Text = "Carnet de Socio";
            lblCarnetSocio.Visible = false;
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(540, 48);
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.ReadOnly = true;
            txtTipoCliente.Size = new Size(219, 27);
            txtTipoCliente.TabIndex = 25;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(406, 45);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(110, 20);
            lblTipoCliente.TabIndex = 24;
            lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(137, 48);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.ReadOnly = true;
            txtClienteID.Size = new Size(215, 27);
            txtClienteID.TabIndex = 23;
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Location = new Point(3, 45);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(74, 20);
            lblClienteID.TabIndex = 22;
            lblClienteID.Text = "Cliente ID";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(540, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(219, 27);
            txtNombre.TabIndex = 21;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(215, 27);
            txtApellido.TabIndex = 19;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(3, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 18;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(406, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // gpbPagar
            // 
            gpbPagar.Controls.Add(btnVolverPago);
            gpbPagar.Controls.Add(btnVerComprobante);
            gpbPagar.Controls.Add(btnPagar);
            gpbPagar.Controls.Add(txtValorCuota);
            gpbPagar.Controls.Add(lblValorCuota);
            gpbPagar.Controls.Add(cboCuotas);
            gpbPagar.Controls.Add(lblCuotas);
            gpbPagar.Controls.Add(cboMetodoPago);
            gpbPagar.Controls.Add(lblMetodoPago);
            gpbPagar.Controls.Add(txtPrecio);
            gpbPagar.Controls.Add(lblPrecio);
            gpbPagar.Controls.Add(lblPlanActividad);
            gpbPagar.Controls.Add(cboListaPlanActividad);
            gpbPagar.Controls.Add(lblPago);
            gpbPagar.Location = new Point(66, 386);
            gpbPagar.Name = "gpbPagar";
            gpbPagar.Size = new Size(847, 301);
            gpbPagar.TabIndex = 18;
            gpbPagar.TabStop = false;
            gpbPagar.Text = "Pago";
            // 
            // btnVolverPago
            // 
            btnVolverPago.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverPago.Location = new Point(599, 210);
            btnVolverPago.Name = "btnVolverPago";
            btnVolverPago.Size = new Size(211, 72);
            btnVolverPago.TabIndex = 20;
            btnVolverPago.Text = "Volver";
            btnVolverPago.UseVisualStyleBackColor = true;
            btnVolverPago.Click += btnVolverPago_Click;
            // 
            // btnVerComprobante
            // 
            btnVerComprobante.Enabled = false;
            btnVerComprobante.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerComprobante.Location = new Point(323, 210);
            btnVerComprobante.Name = "btnVerComprobante";
            btnVerComprobante.Size = new Size(211, 72);
            btnVerComprobante.TabIndex = 19;
            btnVerComprobante.Text = "Ver Ultima Factura";
            btnVerComprobante.UseVisualStyleBackColor = true;
            btnVerComprobante.Click += btnVerComprobante_Click;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.Location = new Point(21, 210);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(211, 72);
            btnPagar.TabIndex = 18;
            btnPagar.Text = "Efectuar Pago";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtValorCuota
            // 
            txtValorCuota.Location = new Point(635, 139);
            txtValorCuota.Name = "txtValorCuota";
            txtValorCuota.ReadOnly = true;
            txtValorCuota.Size = new Size(123, 27);
            txtValorCuota.TabIndex = 10;
            txtValorCuota.Visible = false;
            // 
            // lblValorCuota
            // 
            lblValorCuota.AutoSize = true;
            lblValorCuota.Location = new Point(545, 142);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(84, 20);
            lblValorCuota.TabIndex = 9;
            lblValorCuota.Text = "Valor cuota";
            lblValorCuota.Visible = false;
            // 
            // cboCuotas
            // 
            cboCuotas.Enabled = false;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6", "12" });
            cboCuotas.Location = new Point(411, 138);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(77, 28);
            cboCuotas.TabIndex = 8;
            cboCuotas.SelectedIndexChanged += cboCuotas_SelectedIndexChanged;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(351, 142);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(54, 20);
            lblCuotas.TabIndex = 7;
            lblCuotas.Text = "Cuotas";
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.Enabled = false;
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Tarjeta de Debito", "Tarjeta de Credito" });
            cboMetodoPago.Location = new Point(155, 138);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(164, 28);
            cboMetodoPago.TabIndex = 6;
            cboMetodoPago.SelectedIndexChanged += cboMetodoPago_SelectedIndexChanged;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(21, 142);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(120, 20);
            lblMetodoPago.TabIndex = 5;
            lblMetodoPago.Text = "Metodo de Pago";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(411, 86);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(153, 27);
            txtPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(349, 89);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblPlanActividad
            // 
            lblPlanActividad.AutoSize = true;
            lblPlanActividad.Location = new Point(21, 89);
            lblPlanActividad.Name = "lblPlanActividad";
            lblPlanActividad.Size = new Size(117, 20);
            lblPlanActividad.TabIndex = 2;
            lblPlanActividad.Text = "Plan o Actividad";
            // 
            // cboListaPlanActividad
            // 
            cboListaPlanActividad.Enabled = false;
            cboListaPlanActividad.FormattingEnabled = true;
            cboListaPlanActividad.Location = new Point(155, 86);
            cboListaPlanActividad.Name = "cboListaPlanActividad";
            cboListaPlanActividad.Size = new Size(164, 28);
            cboListaPlanActividad.TabIndex = 1;
            cboListaPlanActividad.SelectedIndexChanged += cboListaPlanActividad_SelectedIndexChanged;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(18, 42);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(490, 20);
            lblPago.TabIndex = 0;
            lblPago.Text = "Por favor, indique que plan de membresia o actividad que desea abonar.";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 0;
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 722);
            Controls.Add(btnVolver);
            Controls.Add(gpbPagar);
            Controls.Add(gpbCliente);
            Controls.Add(lblPagarTitulo);
            Name = "FormPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago de Membresias y Actividades";
            Load += FormPago_Load;
            gpbCliente.ResumeLayout(false);
            gpbCliente.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            gpbPagar.ResumeLayout(false);
            gpbPagar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagarTitulo;
        private TextBox txtNumeroDocumento;
        private ComboBox cboTipoDocumento;
        private Label lblNumeroDocumento;
        private Label lblTipoDocumento;
        private Button btnBuscarCliente;
        private GroupBox gpbCliente;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtFechaVencimiento;
        private Label lblFechaVencimiento;
        private TextBox txtCarnetSocio;
        private Label lblCarnetSocio;
        private TextBox txtTipoCliente;
        private Label lblTipoCliente;
        private TextBox txtClienteID;
        private Label lblClienteID;
        private GroupBox gpbPagar;
        private Label lblPago;
        private Label lblPlanActividad;
        private ComboBox cboListaPlanActividad;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private ComboBox cboMetodoPago;
        private Label lblMetodoPago;
        private ComboBox cboCuotas;
        private Label lblCuotas;
        private TextBox txtValorCuota;
        private Label lblValorCuota;
        private Button btnPagar;
        private Button btnVerComprobante;
        private Button btnVolverPago;
        private Button btnVolver;
    }
}