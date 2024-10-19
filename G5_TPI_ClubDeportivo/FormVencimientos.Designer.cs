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
            ((System.ComponentModel.ISupportInitialize)dtgvVencimientos).BeginInit();
            SuspendLayout();
            // 
            // btnVolverVencimientos
            // 
            btnVolverVencimientos.Location = new Point(550, 336);
            btnVolverVencimientos.Name = "btnVolverVencimientos";
            btnVolverVencimientos.Size = new Size(157, 42);
            btnVolverVencimientos.TabIndex = 0;
            btnVolverVencimientos.Text = "VOLVER";
            btnVolverVencimientos.UseVisualStyleBackColor = true;
            btnVolverVencimientos.Click += btnVolverVencimientos_Click;
            // 
            // dtgvVencimientos
            // 
            dtgvVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVencimientos.Location = new Point(63, 65);
            dtgvVencimientos.Name = "dtgvVencimientos";
            dtgvVencimientos.RowHeadersWidth = 51;
            dtgvVencimientos.RowTemplate.Height = 29;
            dtgvVencimientos.Size = new Size(1125, 188);
            dtgvVencimientos.TabIndex = 1;
            // 
            // FormVencimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 450);
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
    }
}