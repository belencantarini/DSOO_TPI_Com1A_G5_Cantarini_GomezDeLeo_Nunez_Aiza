namespace G5_TPI_ClubDeportivo
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            picLogin = new PictureBox();
            lblIngresoLogin = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            chkPass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // picLogin
            // 
            picLogin.Image = (Image)resources.GetObject("picLogin.Image");
            picLogin.Location = new Point(39, 40);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(231, 295);
            picLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogin.TabIndex = 0;
            picLogin.TabStop = false;
            // 
            // lblIngresoLogin
            // 
            lblIngresoLogin.AutoSize = true;
            lblIngresoLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngresoLogin.Location = new Point(341, 64);
            lblIngresoLogin.Name = "lblIngresoLogin";
            lblIngresoLogin.Size = new Size(151, 32);
            lblIngresoLogin.TabIndex = 0;
            lblIngresoLogin.Text = "Iniciar sesión";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(341, 263);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(143, 45);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(502, 263);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 45);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(341, 122);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(304, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(341, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(304, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // chkPass
            // 
            chkPass.AutoSize = true;
            chkPass.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            chkPass.Location = new Point(341, 201);
            chkPass.Name = "chkPass";
            chkPass.Size = new Size(151, 23);
            chkPass.TabIndex = 3;
            chkPass.Text = "Mostrar contraseña";
            chkPass.UseVisualStyleBackColor = true;
            chkPass.KeyDown += chkPass_KeyDown;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 385);
            Controls.Add(txtPassword);
            Controls.Add(chkPass);
            Controls.Add(btnSalir);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblIngresoLogin);
            Controls.Add(picLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso Usuario";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox picLogin;
        private Label lblIngresoLogin;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnSalir;
        private CheckBox chkPass;
    }
}
