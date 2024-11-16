namespace G5_TPI_ClubDeportivo
{
    partial class FormFactura
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
            lblFactura = new Label();
            btnImprimirFactura = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtVarNroDoc = new TextBox();
            txtVarTipoDoc = new TextBox();
            txtVarNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblTipoDocumento = new Label();
            lblNroDocumento = new Label();
            txtVarApellido = new TextBox();
            lblVarNroFactura = new Label();
            lblDatosCliente = new Label();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtVarCuotas = new TextBox();
            lblCuotas = new Label();
            txtVarMetodoPago = new TextBox();
            lblMetodoPago = new Label();
            txtVarPrecioPlan = new TextBox();
            txtVarPlan = new TextBox();
            txtVarPrecioAct = new TextBox();
            lblActividad = new Label();
            lblPrecioAct = new Label();
            lblPlan = new Label();
            lblPrecioPlan = new Label();
            txtVarActividad = new TextBox();
            lblFecha = new Label();
            lblVarFecha = new Label();
            lblTotal = new Label();
            lblVarTotal = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFactura.Location = new Point(52, 33);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(137, 32);
            lblFactura.TabIndex = 4;
            lblFactura.Text = "Factura Nro";
            // 
            // btnImprimirFactura
            // 
            btnImprimirFactura.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirFactura.Location = new Point(284, 551);
            btnImprimirFactura.Name = "btnImprimirFactura";
            btnImprimirFactura.Size = new Size(211, 72);
            btnImprimirFactura.TabIndex = 20;
            btnImprimirFactura.Text = "Imprimir Factura";
            btnImprimirFactura.UseVisualStyleBackColor = true;
            btnImprimirFactura.Click += btnImprimirFactura_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(txtVarNroDoc, 3, 1);
            tableLayoutPanel1.Controls.Add(txtVarTipoDoc, 1, 1);
            tableLayoutPanel1.Controls.Add(txtVarNombre, 3, 0);
            tableLayoutPanel1.Controls.Add(lblApellido, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNombre, 2, 0);
            tableLayoutPanel1.Controls.Add(lblTipoDocumento, 0, 1);
            tableLayoutPanel1.Controls.Add(lblNroDocumento, 2, 1);
            tableLayoutPanel1.Controls.Add(txtVarApellido, 1, 0);
            tableLayoutPanel1.Location = new Point(52, 166);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(706, 89);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // txtVarNroDoc
            // 
            txtVarNroDoc.Location = new Point(472, 47);
            txtVarNroDoc.Name = "txtVarNroDoc";
            txtVarNroDoc.ReadOnly = true;
            txtVarNroDoc.Size = new Size(184, 27);
            txtVarNroDoc.TabIndex = 31;
            // 
            // txtVarTipoDoc
            // 
            txtVarTipoDoc.Location = new Point(120, 47);
            txtVarTipoDoc.Name = "txtVarTipoDoc";
            txtVarTipoDoc.ReadOnly = true;
            txtVarTipoDoc.Size = new Size(184, 27);
            txtVarTipoDoc.TabIndex = 30;
            // 
            // txtVarNombre
            // 
            txtVarNombre.Location = new Point(472, 3);
            txtVarNombre.Name = "txtVarNombre";
            txtVarNombre.ReadOnly = true;
            txtVarNombre.Size = new Size(184, 27);
            txtVarNombre.TabIndex = 29;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(3, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 24;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(355, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(3, 44);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(87, 40);
            lblTipoDocumento.TabIndex = 26;
            lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblNroDocumento
            // 
            lblNroDocumento.AutoSize = true;
            lblNroDocumento.Location = new Point(355, 44);
            lblNroDocumento.Name = "lblNroDocumento";
            lblNroDocumento.Size = new Size(88, 40);
            lblNroDocumento.TabIndex = 27;
            lblNroDocumento.Text = "Numero de documento";
            // 
            // txtVarApellido
            // 
            txtVarApellido.Location = new Point(120, 3);
            txtVarApellido.Name = "txtVarApellido";
            txtVarApellido.ReadOnly = true;
            txtVarApellido.Size = new Size(184, 27);
            txtVarApellido.TabIndex = 28;
            // 
            // lblVarNroFactura
            // 
            lblVarNroFactura.AutoSize = true;
            lblVarNroFactura.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblVarNroFactura.Location = new Point(195, 33);
            lblVarNroFactura.Name = "lblVarNroFactura";
            lblVarNroFactura.Size = new Size(28, 32);
            lblVarNroFactura.TabIndex = 23;
            lblVarNroFactura.Text = "0";
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosCliente.Location = new Point(52, 130);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(125, 20);
            lblDatosCliente.TabIndex = 25;
            lblDatosCliente.Text = "Datos del cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(52, 298);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 27;
            label6.Text = "Datos de facturación";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(txtVarCuotas, 3, 2);
            tableLayoutPanel2.Controls.Add(lblCuotas, 2, 2);
            tableLayoutPanel2.Controls.Add(txtVarMetodoPago, 1, 2);
            tableLayoutPanel2.Controls.Add(lblMetodoPago, 0, 2);
            tableLayoutPanel2.Controls.Add(txtVarPrecioPlan, 3, 1);
            tableLayoutPanel2.Controls.Add(txtVarPlan, 1, 1);
            tableLayoutPanel2.Controls.Add(txtVarPrecioAct, 3, 0);
            tableLayoutPanel2.Controls.Add(lblActividad, 0, 0);
            tableLayoutPanel2.Controls.Add(lblPrecioAct, 2, 0);
            tableLayoutPanel2.Controls.Add(lblPlan, 0, 1);
            tableLayoutPanel2.Controls.Add(lblPrecioPlan, 2, 1);
            tableLayoutPanel2.Controls.Add(txtVarActividad, 1, 0);
            tableLayoutPanel2.Location = new Point(52, 334);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(706, 138);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // txtVarCuotas
            // 
            txtVarCuotas.Location = new Point(472, 95);
            txtVarCuotas.Name = "txtVarCuotas";
            txtVarCuotas.ReadOnly = true;
            txtVarCuotas.Size = new Size(184, 27);
            txtVarCuotas.TabIndex = 35;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(355, 92);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(54, 20);
            lblCuotas.TabIndex = 34;
            lblCuotas.Text = "Cuotas";
            // 
            // txtVarMetodoPago
            // 
            txtVarMetodoPago.Location = new Point(120, 95);
            txtVarMetodoPago.Name = "txtVarMetodoPago";
            txtVarMetodoPago.ReadOnly = true;
            txtVarMetodoPago.Size = new Size(184, 27);
            txtVarMetodoPago.TabIndex = 33;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(3, 92);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(87, 40);
            lblMetodoPago.TabIndex = 32;
            lblMetodoPago.Text = "Método de Pago";
            // 
            // txtVarPrecioPlan
            // 
            txtVarPrecioPlan.Location = new Point(472, 49);
            txtVarPrecioPlan.Name = "txtVarPrecioPlan";
            txtVarPrecioPlan.ReadOnly = true;
            txtVarPrecioPlan.Size = new Size(184, 27);
            txtVarPrecioPlan.TabIndex = 31;
            // 
            // txtVarPlan
            // 
            txtVarPlan.Location = new Point(120, 49);
            txtVarPlan.Name = "txtVarPlan";
            txtVarPlan.ReadOnly = true;
            txtVarPlan.Size = new Size(184, 27);
            txtVarPlan.TabIndex = 30;
            // 
            // txtVarPrecioAct
            // 
            txtVarPrecioAct.Location = new Point(472, 3);
            txtVarPrecioAct.Name = "txtVarPrecioAct";
            txtVarPrecioAct.ReadOnly = true;
            txtVarPrecioAct.Size = new Size(184, 27);
            txtVarPrecioAct.TabIndex = 29;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(3, 0);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(72, 20);
            lblActividad.TabIndex = 24;
            lblActividad.Text = "Actividad";
            // 
            // lblPrecioAct
            // 
            lblPrecioAct.AutoSize = true;
            lblPrecioAct.Location = new Point(355, 0);
            lblPrecioAct.Name = "lblPrecioAct";
            lblPrecioAct.Size = new Size(50, 20);
            lblPrecioAct.TabIndex = 25;
            lblPrecioAct.Text = "Precio";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(3, 46);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(83, 40);
            lblPlan.TabIndex = 26;
            lblPlan.Text = "Plan de Membresia";
            // 
            // lblPrecioPlan
            // 
            lblPrecioPlan.AutoSize = true;
            lblPrecioPlan.Location = new Point(355, 46);
            lblPrecioPlan.Name = "lblPrecioPlan";
            lblPrecioPlan.Size = new Size(50, 20);
            lblPrecioPlan.TabIndex = 27;
            lblPrecioPlan.Text = "Precio";
            // 
            // txtVarActividad
            // 
            txtVarActividad.Location = new Point(120, 3);
            txtVarActividad.Name = "txtVarActividad";
            txtVarActividad.ReadOnly = true;
            txtVarActividad.Size = new Size(184, 27);
            txtVarActividad.TabIndex = 28;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(52, 82);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 28;
            lblFecha.Text = "Fecha";
            // 
            // lblVarFecha
            // 
            lblVarFecha.AutoSize = true;
            lblVarFecha.Location = new Point(105, 82);
            lblVarFecha.Name = "lblVarFecha";
            lblVarFecha.Size = new Size(15, 20);
            lblVarFecha.TabIndex = 29;
            lblVarFecha.Text = "-";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(471, 491);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 20);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "Total:";
            // 
            // lblVarTotal
            // 
            lblVarTotal.AutoSize = true;
            lblVarTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVarTotal.Location = new Point(524, 491);
            lblVarTotal.Name = "lblVarTotal";
            lblVarTotal.Size = new Size(18, 20);
            lblVarTotal.TabIndex = 31;
            lblVarTotal.Text = "0";
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(lblVarTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblVarFecha);
            Controls.Add(lblFecha);
            Controls.Add(label6);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lblDatosCliente);
            Controls.Add(lblVarNroFactura);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnImprimirFactura);
            Controls.Add(lblFactura);
            Name = "FormFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            Load += FormFactura_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFactura;
        private Button btnImprimirFactura;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblApellido;
        private Label lblVarNroFactura;
        private Label lblNombre;
        private TextBox txtVarNroDoc;
        private TextBox txtVarTipoDoc;
        private TextBox txtVarNombre;
        private Label lblTipoDocumento;
        private Label lblNroDocumento;
        private TextBox txtVarApellido;
        private Label lblDatosCliente;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtVarPrecioPlan;
        private TextBox txtVarPlan;
        private TextBox txtVarPrecioAct;
        private Label lblActividad;
        private Label lblPrecioAct;
        private Label lblPlan;
        private Label lblPrecioPlan;
        private TextBox txtVarActividad;
        private TextBox txtVarCuotas;
        private Label lblCuotas;
        private TextBox txtVarMetodoPago;
        private Label lblMetodoPago;
        private Label lblFecha;
        private Label lblVarFecha;
        private Label lblTotal;
        private Label lblVarTotal;
    }
}