﻿namespace G5_TPI_ClubDeportivo
{
    partial class FormCarnetSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarnetSocio));
            lblTitulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtVarVencimiento = new TextBox();
            lblVencimiento = new Label();
            txtVarApto = new TextBox();
            lblAptoFisico = new Label();
            txtVarInscripcion = new TextBox();
            lblFechaInscripcion = new Label();
            txtVarNacimiento = new TextBox();
            lblFechaNacimiento = new Label();
            txtVarNroDoc = new TextBox();
            txtVarTipoDoc = new TextBox();
            txtVarNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblTipoDocumento = new Label();
            lblNroDocumento = new Label();
            txtVarApellido = new TextBox();
            lblVarCarnet = new Label();
            btnImprimirCarnet = new Button();
            btnVolver = new Button();
            picLogo = new PictureBox();
            grpCarnet = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpCarnet.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(174, 358);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(236, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CARNET de SOCIO: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(txtVarVencimiento, 3, 3);
            tableLayoutPanel1.Controls.Add(lblVencimiento, 2, 3);
            tableLayoutPanel1.Controls.Add(txtVarApto, 1, 3);
            tableLayoutPanel1.Controls.Add(lblAptoFisico, 0, 3);
            tableLayoutPanel1.Controls.Add(txtVarInscripcion, 3, 2);
            tableLayoutPanel1.Controls.Add(lblFechaInscripcion, 2, 2);
            tableLayoutPanel1.Controls.Add(txtVarNacimiento, 1, 2);
            tableLayoutPanel1.Controls.Add(lblFechaNacimiento, 0, 2);
            tableLayoutPanel1.Controls.Add(txtVarNroDoc, 3, 1);
            tableLayoutPanel1.Controls.Add(txtVarTipoDoc, 1, 1);
            tableLayoutPanel1.Controls.Add(txtVarNombre, 3, 0);
            tableLayoutPanel1.Controls.Add(lblApellido, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNombre, 2, 0);
            tableLayoutPanel1.Controls.Add(lblTipoDocumento, 0, 1);
            tableLayoutPanel1.Controls.Add(lblNroDocumento, 2, 1);
            tableLayoutPanel1.Controls.Add(txtVarApellido, 1, 0);
            tableLayoutPanel1.Location = new Point(19, 162);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(740, 193);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtVarVencimiento
            // 
            txtVarVencimiento.Location = new Point(495, 147);
            txtVarVencimiento.Name = "txtVarVencimiento";
            txtVarVencimiento.ReadOnly = true;
            txtVarVencimiento.Size = new Size(184, 27);
            txtVarVencimiento.TabIndex = 15;
            txtVarVencimiento.TabStop = false;
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Location = new Point(372, 144);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(91, 20);
            lblVencimiento.TabIndex = 14;
            lblVencimiento.Text = "Vencimiento";
            // 
            // txtVarApto
            // 
            txtVarApto.Location = new Point(126, 147);
            txtVarApto.Name = "txtVarApto";
            txtVarApto.ReadOnly = true;
            txtVarApto.Size = new Size(184, 27);
            txtVarApto.TabIndex = 13;
            txtVarApto.TabStop = false;
            // 
            // lblAptoFisico
            // 
            lblAptoFisico.AutoSize = true;
            lblAptoFisico.Location = new Point(3, 144);
            lblAptoFisico.Name = "lblAptoFisico";
            lblAptoFisico.Size = new Size(87, 40);
            lblAptoFisico.TabIndex = 12;
            lblAptoFisico.Text = "Apto Físico entregado";
            // 
            // txtVarInscripcion
            // 
            txtVarInscripcion.Location = new Point(495, 99);
            txtVarInscripcion.Name = "txtVarInscripcion";
            txtVarInscripcion.ReadOnly = true;
            txtVarInscripcion.Size = new Size(184, 27);
            txtVarInscripcion.TabIndex = 11;
            txtVarInscripcion.TabStop = false;
            // 
            // lblFechaInscripcion
            // 
            lblFechaInscripcion.AutoSize = true;
            lblFechaInscripcion.Location = new Point(372, 96);
            lblFechaInscripcion.Name = "lblFechaInscripcion";
            lblFechaInscripcion.Size = new Size(80, 40);
            lblFechaInscripcion.TabIndex = 10;
            lblFechaInscripcion.Text = "Fecha de Inscripción";
            // 
            // txtVarNacimiento
            // 
            txtVarNacimiento.Location = new Point(126, 99);
            txtVarNacimiento.Name = "txtVarNacimiento";
            txtVarNacimiento.ReadOnly = true;
            txtVarNacimiento.Size = new Size(184, 27);
            txtVarNacimiento.TabIndex = 9;
            txtVarNacimiento.TabStop = false;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(3, 96);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(86, 40);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtVarNroDoc
            // 
            txtVarNroDoc.Location = new Point(495, 51);
            txtVarNroDoc.Name = "txtVarNroDoc";
            txtVarNroDoc.ReadOnly = true;
            txtVarNroDoc.Size = new Size(184, 27);
            txtVarNroDoc.TabIndex = 7;
            txtVarNroDoc.TabStop = false;
            // 
            // txtVarTipoDoc
            // 
            txtVarTipoDoc.Location = new Point(126, 51);
            txtVarTipoDoc.Name = "txtVarTipoDoc";
            txtVarTipoDoc.ReadOnly = true;
            txtVarTipoDoc.Size = new Size(184, 27);
            txtVarTipoDoc.TabIndex = 5;
            txtVarTipoDoc.TabStop = false;
            // 
            // txtVarNombre
            // 
            txtVarNombre.Location = new Point(495, 3);
            txtVarNombre.Name = "txtVarNombre";
            txtVarNombre.ReadOnly = true;
            txtVarNombre.Size = new Size(184, 27);
            txtVarNombre.TabIndex = 3;
            txtVarNombre.TabStop = false;
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
            lblNombre.Location = new Point(372, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(3, 48);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(87, 40);
            lblTipoDocumento.TabIndex = 4;
            lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblNroDocumento
            // 
            lblNroDocumento.AutoSize = true;
            lblNroDocumento.Location = new Point(372, 48);
            lblNroDocumento.Name = "lblNroDocumento";
            lblNroDocumento.Size = new Size(88, 40);
            lblNroDocumento.TabIndex = 6;
            lblNroDocumento.Text = "Numero de documento";
            // 
            // txtVarApellido
            // 
            txtVarApellido.Location = new Point(126, 3);
            txtVarApellido.Name = "txtVarApellido";
            txtVarApellido.ReadOnly = true;
            txtVarApellido.Size = new Size(184, 27);
            txtVarApellido.TabIndex = 1;
            txtVarApellido.TabStop = false;
            // 
            // lblVarCarnet
            // 
            lblVarCarnet.AutoSize = true;
            lblVarCarnet.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblVarCarnet.Location = new Point(417, 358);
            lblVarCarnet.Name = "lblVarCarnet";
            lblVarCarnet.Size = new Size(54, 32);
            lblVarCarnet.TabIndex = 2;
            lblVarCarnet.Text = "nro";
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirCarnet.Location = new Point(155, 450);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(211, 43);
            btnImprimirCarnet.TabIndex = 0;
            btnImprimirCarnet.Text = "Imprimir Carnet";
            btnImprimirCarnet.UseVisualStyleBackColor = true;
            btnImprimirCarnet.Click += btnImprimirCarnet_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(432, 450);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(211, 43);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(275, 26);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(244, 116);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 26;
            picLogo.TabStop = false;
            // 
            // grpCarnet
            // 
            grpCarnet.Controls.Add(tableLayoutPanel1);
            grpCarnet.Controls.Add(picLogo);
            grpCarnet.Controls.Add(lblTitulo);
            grpCarnet.Controls.Add(lblVarCarnet);
            grpCarnet.Location = new Point(32, 30);
            grpCarnet.Name = "grpCarnet";
            grpCarnet.Size = new Size(780, 397);
            grpCarnet.TabIndex = 2;
            grpCarnet.TabStop = false;
            grpCarnet.Text = "Carnet de Socio";
            // 
            // FormCarnetSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 525);
            Controls.Add(grpCarnet);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimirCarnet);
            Name = "FormCarnetSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarnetSocio";
            Load += FormCarnetSocio_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpCarnet.ResumeLayout(false);
            grpCarnet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtVarNacimiento;
        private Label lblFechaNacimiento;
        private TextBox txtVarNroDoc;
        private TextBox txtVarTipoDoc;
        private TextBox txtVarNombre;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblTipoDocumento;
        private Label lblNroDocumento;
        private TextBox txtVarApellido;
        private Label lblVarCarnet;
        private TextBox txtVarVencimiento;
        private Label lblVencimiento;
        private TextBox txtVarApto;
        private Label lblAptoFisico;
        private TextBox txtVarInscripcion;
        private Label lblFechaInscripcion;
        private Button btnImprimirCarnet;
        private Button btnVolver;
        private PictureBox picLogo;
        private GroupBox grpCarnet;
    }
}