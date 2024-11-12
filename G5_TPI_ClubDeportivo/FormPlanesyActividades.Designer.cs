namespace G5_TPI_ClubDeportivo
{
    partial class FormPlanesyActividades
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
            lblPlanesSocios = new Label();
            lblActividadesNoSocios = new Label();
            dtgvActividades = new DataGridView();
            TipoActividad = new DataGridViewTextBoxColumn();
            PrecioDiario = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            dtgvPlanes = new DataGridView();
            Plan = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cuotas1 = new DataGridViewTextBoxColumn();
            Cuotas3 = new DataGridViewTextBoxColumn();
            Cuotas6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // lblPlanesSocios
            // 
            lblPlanesSocios.AutoSize = true;
            lblPlanesSocios.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlanesSocios.Location = new Point(51, 58);
            lblPlanesSocios.Name = "lblPlanesSocios";
            lblPlanesSocios.Size = new Size(225, 32);
            lblPlanesSocios.TabIndex = 0;
            lblPlanesSocios.Text = "Planes para SOCIOS";
            // 
            // lblActividadesNoSocios
            // 
            lblActividadesNoSocios.AutoSize = true;
            lblActividadesNoSocios.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblActividadesNoSocios.Location = new Point(51, 337);
            lblActividadesNoSocios.Name = "lblActividadesNoSocios";
            lblActividadesNoSocios.Size = new Size(321, 32);
            lblActividadesNoSocios.TabIndex = 1;
            lblActividadesNoSocios.Text = "Actividades para NO SOCIOS";
            // 
            // dtgvActividades
            // 
            dtgvActividades.AllowUserToAddRows = false;
            dtgvActividades.AllowUserToDeleteRows = false;
            dtgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividades.Columns.AddRange(new DataGridViewColumn[] { TipoActividad, PrecioDiario });
            dtgvActividades.Location = new Point(51, 372);
            dtgvActividades.Name = "dtgvActividades";
            dtgvActividades.ReadOnly = true;
            dtgvActividades.RowHeadersWidth = 51;
            dtgvActividades.RowTemplate.Height = 29;
            dtgvActividades.Size = new Size(513, 211);
            dtgvActividades.TabIndex = 3;
            // 
            // TipoActividad
            // 
            TipoActividad.HeaderText = "Tipo de Actividad";
            TipoActividad.MinimumWidth = 6;
            TipoActividad.Name = "TipoActividad";
            TipoActividad.ReadOnly = true;
            TipoActividad.Width = 200;
            // 
            // PrecioDiario
            // 
            PrecioDiario.HeaderText = "Precio por día";
            PrecioDiario.MinimumWidth = 6;
            PrecioDiario.Name = "PrecioDiario";
            PrecioDiario.ReadOnly = true;
            PrecioDiario.Width = 200;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(562, 617);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(157, 42);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // dtgvPlanes
            // 
            dtgvPlanes.AllowUserToAddRows = false;
            dtgvPlanes.AllowUserToDeleteRows = false;
            dtgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPlanes.Columns.AddRange(new DataGridViewColumn[] { Plan, Precio, Cuotas1, Cuotas3, Cuotas6 });
            dtgvPlanes.Location = new Point(51, 93);
            dtgvPlanes.Name = "dtgvPlanes";
            dtgvPlanes.ReadOnly = true;
            dtgvPlanes.RowHeadersWidth = 51;
            dtgvPlanes.RowTemplate.Height = 29;
            dtgvPlanes.Size = new Size(1150, 188);
            dtgvPlanes.TabIndex = 5;
            // 
            // Plan
            // 
            Plan.HeaderText = "Tipo de Plan";
            Plan.MinimumWidth = 6;
            Plan.Name = "Plan";
            Plan.ReadOnly = true;
            Plan.Width = 200;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 200;
            // 
            // Cuotas1
            // 
            Cuotas1.HeaderText = "Pago en 1 cuota";
            Cuotas1.MinimumWidth = 6;
            Cuotas1.Name = "Cuotas1";
            Cuotas1.ReadOnly = true;
            Cuotas1.Width = 200;
            // 
            // Cuotas3
            // 
            Cuotas3.HeaderText = "Pago en 3 cuotas";
            Cuotas3.MinimumWidth = 6;
            Cuotas3.Name = "Cuotas3";
            Cuotas3.ReadOnly = true;
            Cuotas3.Width = 200;
            // 
            // Cuotas6
            // 
            Cuotas6.HeaderText = "Pago en 6 cuotas";
            Cuotas6.MinimumWidth = 6;
            Cuotas6.Name = "Cuotas6";
            Cuotas6.ReadOnly = true;
            Cuotas6.Width = 200;
            // 
            // FormPlanesyActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 728);
            Controls.Add(dtgvPlanes);
            Controls.Add(btnVolver);
            Controls.Add(dtgvActividades);
            Controls.Add(lblActividadesNoSocios);
            Controls.Add(lblPlanesSocios);
            Name = "FormPlanesyActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPlanesyActividades";
            Load += FormPlanesyActividades_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvPlanes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlanesSocios;
        private Label lblActividadesNoSocios;
        private DataGridView dtgvActividades;
        private Button btnVolver;
        private DataGridView dtgvPlanes;
        private DataGridViewTextBoxColumn Plan;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cuotas1;
        private DataGridViewTextBoxColumn Cuotas3;
        private DataGridViewTextBoxColumn Cuotas6;
        private DataGridViewTextBoxColumn TipoActividad;
        private DataGridViewTextBoxColumn PrecioDiario;
    }
}