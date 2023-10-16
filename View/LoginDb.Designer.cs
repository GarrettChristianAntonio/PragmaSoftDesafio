namespace View
{
    partial class LoginDb
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
            txtHost = new TextBox();
            btnConectar = new Button();
            txtPuerto = new TextBox();
            txtNameBd = new TextBox();
            txtuser = new TextBox();
            txtPass = new TextBox();
            btnSalir = new Button();
            lblTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtHost
            // 
            txtHost.Location = new Point(101, 16);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(120, 23);
            txtHost.TabIndex = 0;
            txtHost.Text = "localhost";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(25, 211);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(90, 23);
            btnConectar.TabIndex = 1;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += button1_Click;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(101, 55);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(120, 23);
            txtPuerto.TabIndex = 2;
            txtPuerto.Text = "5432";
            // 
            // txtNameBd
            // 
            txtNameBd.Location = new Point(101, 93);
            txtNameBd.Name = "txtNameBd";
            txtNameBd.Size = new Size(120, 23);
            txtNameBd.TabIndex = 3;
            txtNameBd.Text = "postgres";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(101, 133);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(120, 23);
            txtuser.TabIndex = 4;
            txtuser.Text = "postgres";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(101, 170);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(120, 23);
            txtPass.TabIndex = 5;
            txtPass.Text = "1234";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(130, 211);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(83, 15);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Servidor/Host:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 58);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Puerto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 96);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 9;
            label3.Text = "Base de datos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 136);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 10;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 173);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 11;
            label5.Text = "Contraseña:";
            // 
            // LoginDb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 238);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(txtPass);
            Controls.Add(txtuser);
            Controls.Add(txtNameBd);
            Controls.Add(txtPuerto);
            Controls.Add(btnConectar);
            Controls.Add(txtHost);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginDb";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexión a Base de Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHost;
        private Button btnConectar;
        private TextBox txtPuerto;
        private TextBox txtNameBd;
        private TextBox txtuser;
        private TextBox txtPass;
        private Button btnSalir;
        private Label lblTitulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}