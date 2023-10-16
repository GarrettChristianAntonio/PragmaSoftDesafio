namespace View
{
    partial class AdministradorSeries
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
            btnConsultar = new Button();
            btnNuevo = new Button();
            btnModificar = new Button();
            btnAnular = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            lblSinRegistro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(704, 12);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 23);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 316);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(108, 316);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(204, 316);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(90, 23);
            btnAnular.TabIndex = 3;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.Click += btnAnular_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(300, 316);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(704, 316);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(782, 269);
            dataGridView1.TabIndex = 6;
            // 
            // lblSinRegistro
            // 
            lblSinRegistro.AutoSize = true;
            lblSinRegistro.ForeColor = SystemColors.ButtonShadow;
            lblSinRegistro.Location = new Point(367, 167);
            lblSinRegistro.Name = "lblSinRegistro";
            lblSinRegistro.Size = new Size(90, 15);
            lblSinRegistro.TabIndex = 7;
            lblSinRegistro.Text = "<Sin  registros>";
            // 
            // AdministradorSeries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 344);
            Controls.Add(lblSinRegistro);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnAnular);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(btnConsultar);
            MaximizeBox = false;
            Name = "AdministradorSeries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de Series";
            FormClosing += AdministradorSeries_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnAnular;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Label lblSinRegistro;
    }
}