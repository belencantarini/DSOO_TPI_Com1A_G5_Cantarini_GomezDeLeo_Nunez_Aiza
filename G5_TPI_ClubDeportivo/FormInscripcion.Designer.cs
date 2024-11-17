namespace G5_TPI_ClubDeportivo
{
    partial class FormInscripcion
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
            lblInscripcionCliente = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipoDocumento = new Label();
            lblNumeroDocumento = new Label();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            chkAptoFisico = new CheckBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cboTipoDocumento = new ComboBox();
            txtNumeroDocumento = new TextBox();
            btnIngresarCliente = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            rbnSocio = new RadioButton();
            grbSocioNoSocio = new GroupBox();
            rbnNoSocio = new RadioButton();
            grbSocioNoSocio.SuspendLayout();
            SuspendLayout();
            // 
            // lblInscripcionCliente
            // 
            lblInscripcionCliente.AutoSize = true;
            lblInscripcionCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInscripcionCliente.Location = new Point(228, 59);
            lblInscripcionCliente.Name = "lblInscripcionCliente";
            lblInscripcionCliente.Size = new Size(250, 32);
            lblInscripcionCliente.TabIndex = 0;
            lblInscripcionCliente.Text = "Inscripción del Cliente";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(396, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(65, 130);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(65, 200);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(140, 20);
            lblTipoDocumento.TabIndex = 3;
            lblTipoDocumento.Text = "Tipo de documento";
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(396, 200);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(164, 20);
            lblNumeroDocumento.TabIndex = 4;
            lblNumeroDocumento.Text = "Número de documento";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(65, 274);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(146, 20);
            lblFechaNacimiento.TabIndex = 5;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(65, 297);
            dtpFechaNacimiento.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(140, 27);
            dtpFechaNacimiento.TabIndex = 5;
            dtpFechaNacimiento.Value = new DateTime(2024, 10, 15, 23, 47, 9, 109);
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(65, 355);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(160, 24);
            chkAptoFisico.TabIndex = 7;
            chkAptoFisico.Text = "Entrega Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            chkAptoFisico.KeyDown += chkAptoFisico_KeyDown;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(396, 153);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(270, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(65, 153);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(270, 27);
            txtApellido.TabIndex = 1;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Items.AddRange(new object[] { "DNI", "Pasaporte", "Libreta Cívica", "Libreta de Enrolamiento" });
            cboTipoDocumento.Location = new Point(65, 223);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(270, 28);
            cboTipoDocumento.TabIndex = 3;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(396, 224);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(270, 27);
            txtNumeroDocumento.TabIndex = 4;
            // 
            // btnIngresarCliente
            // 
            btnIngresarCliente.Location = new Point(110, 440);
            btnIngresarCliente.Name = "btnIngresarCliente";
            btnIngresarCliente.Size = new Size(144, 40);
            btnIngresarCliente.TabIndex = 8;
            btnIngresarCliente.Text = "INGRESAR";
            btnIngresarCliente.UseVisualStyleBackColor = true;
            btnIngresarCliente.Click += btnIngresarCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(277, 440);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(144, 40);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(436, 440);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(144, 40);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // rbnSocio
            // 
            rbnSocio.AutoSize = true;
            rbnSocio.Checked = true;
            rbnSocio.Location = new Point(15, 26);
            rbnSocio.Name = "rbnSocio";
            rbnSocio.Size = new Size(67, 24);
            rbnSocio.TabIndex = 0;
            rbnSocio.TabStop = true;
            rbnSocio.Text = "Socio";
            rbnSocio.UseVisualStyleBackColor = true;
            // 
            // grbSocioNoSocio
            // 
            grbSocioNoSocio.Controls.Add(rbnNoSocio);
            grbSocioNoSocio.Controls.Add(rbnSocio);
            grbSocioNoSocio.Location = new Point(396, 288);
            grbSocioNoSocio.Name = "grbSocioNoSocio";
            grbSocioNoSocio.Size = new Size(270, 91);
            grbSocioNoSocio.TabIndex = 6;
            grbSocioNoSocio.TabStop = false;
            grbSocioNoSocio.Text = "Inscribir como";
            // 
            // rbnNoSocio
            // 
            rbnNoSocio.AutoSize = true;
            rbnNoSocio.Location = new Point(15, 56);
            rbnNoSocio.Name = "rbnNoSocio";
            rbnNoSocio.Size = new Size(91, 24);
            rbnNoSocio.TabIndex = 1;
            rbnNoSocio.Text = "No Socio";
            rbnNoSocio.UseVisualStyleBackColor = true;
            // 
            // FormInscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 549);
            Controls.Add(grbSocioNoSocio);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresarCliente);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(cboTipoDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(chkAptoFisico);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblNumeroDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblInscripcionCliente);
            Name = "FormInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripción del cliente";
            Load += FormInscripcion_Load;
            grbSocioNoSocio.ResumeLayout(false);
            grbSocioNoSocio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblInscripcionCliente;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipoDocumento;
        private Label lblNumeroDocumento;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private CheckBox chkAptoFisico;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cboTipoDocumento;
        private TextBox txtNumeroDocumento;
        private Button btnIngresarCliente;
        private Button btnLimpiar;
        private Button btnVolver;
        private RadioButton rbnSocio;
        private GroupBox grbSocioNoSocio;
        private RadioButton rbnNoSocio;
    }
}