namespace View
{
    partial class AgregarModificar
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
            txtTitulo = new TextBox();
            rTxtDescripcion = new RichTextBox();
            dtpFechaDeEstreno = new DateTimePicker();
            cbGenero = new ComboBox();
            txtEstrellas = new TextBox();
            txtPrecioAlquiler = new TextBox();
            cbATP = new CheckBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            btnAceptarAgregar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(120, 21);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(637, 23);
            txtTitulo.TabIndex = 0;
            // 
            // rTxtDescripcion
            // 
            rTxtDescripcion.Location = new Point(120, 66);
            rTxtDescripcion.Name = "rTxtDescripcion";
            rTxtDescripcion.Size = new Size(637, 120);
            rTxtDescripcion.TabIndex = 1;
            rTxtDescripcion.Text = "";
            // 
            // dtpFechaDeEstreno
            // 
            dtpFechaDeEstreno.Format = DateTimePickerFormat.Short;
            dtpFechaDeEstreno.Location = new Point(120, 207);
            dtpFechaDeEstreno.Name = "dtpFechaDeEstreno";
            dtpFechaDeEstreno.Size = new Size(145, 23);
            dtpFechaDeEstreno.TabIndex = 2;
            // 
            // cbGenero
            // 
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(120, 249);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(145, 23);
            cbGenero.TabIndex = 3;
            // 
            // txtEstrellas
            // 
            txtEstrellas.Location = new Point(371, 207);
            txtEstrellas.Name = "txtEstrellas";
            txtEstrellas.Size = new Size(100, 23);
            txtEstrellas.TabIndex = 4;
            // 
            // txtPrecioAlquiler
            // 
            txtPrecioAlquiler.Location = new Point(386, 246);
            txtPrecioAlquiler.Name = "txtPrecioAlquiler";
            txtPrecioAlquiler.Size = new Size(100, 23);
            txtPrecioAlquiler.TabIndex = 5;
            // 
            // cbATP
            // 
            cbATP.AutoSize = true;
            cbATP.Location = new Point(517, 209);
            cbATP.Name = "cbATP";
            cbATP.Size = new Size(180, 19);
            cbATP.TabIndex = 6;
            cbATP.Text = "Apto para todo público (ATP)";
            cbATP.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(571, 291);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(90, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(667, 291);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "Titulo:";
            // 
            // btnAceptarAgregar
            // 
            btnAceptarAgregar.Location = new Point(571, 291);
            btnAceptarAgregar.Name = "btnAceptarAgregar";
            btnAceptarAgregar.Size = new Size(90, 23);
            btnAceptarAgregar.TabIndex = 10;
            btnAceptarAgregar.Text = "Aceptar";
            btnAceptarAgregar.UseVisualStyleBackColor = true;
            btnAceptarAgregar.Click += btnAceptarAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 69);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 11;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 213);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 12;
            label3.Text = "Fecha de Estreno: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 249);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 13;
            label4.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 213);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 14;
            label5.Text = "Estrellas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 249);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 15;
            label6.Text = "Precio Alquiler:";
            // 
            // AgregarModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 329);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAceptarAgregar);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cbATP);
            Controls.Add(txtPrecioAlquiler);
            Controls.Add(txtEstrellas);
            Controls.Add(cbGenero);
            Controls.Add(dtpFechaDeEstreno);
            Controls.Add(rTxtDescripcion);
            Controls.Add(txtTitulo);
            MinimizeBox = false;
            Name = "AgregarModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private RichTextBox rTxtDescripcion;
        private DateTimePicker dtpFechaDeEstreno;
        private ComboBox cbGenero;
        private TextBox txtEstrellas;
        private TextBox txtPrecioAlquiler;
        private CheckBox cbATP;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Button btnAceptarAgregar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}