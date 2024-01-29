namespace AdoNet
{
    partial class Form10MensajesServidor
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
            label1 = new Label();
            txtNumero = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            btnInsertarDepartamento = new Button();
            lblMensajesServidor = new Label();
            label4 = new Label();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(31, 58);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 39);
            txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 114);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(31, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 39);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 207);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(31, 246);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(208, 39);
            txtLocalidad.TabIndex = 5;
            // 
            // btnInsertarDepartamento
            // 
            btnInsertarDepartamento.Location = new Point(35, 310);
            btnInsertarDepartamento.Name = "btnInsertarDepartamento";
            btnInsertarDepartamento.Size = new Size(208, 50);
            btnInsertarDepartamento.TabIndex = 6;
            btnInsertarDepartamento.Text = "Insertar";
            btnInsertarDepartamento.UseVisualStyleBackColor = true;
            btnInsertarDepartamento.Click += btnInsertarDepartamento_Click;
            // 
            // lblMensajesServidor
            // 
            lblMensajesServidor.AutoSize = true;
            lblMensajesServidor.ForeColor = Color.Blue;
            lblMensajesServidor.Location = new Point(35, 384);
            lblMensajesServidor.Name = "lblMensajesServidor";
            lblMensajesServidor.Size = new Size(228, 32);
            lblMensajesServidor.TabIndex = 7;
            lblMensajesServidor.Text = "lblMensajesServidor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 19);
            label4.Name = "label4";
            label4.Size = new Size(178, 32);
            label4.TabIndex = 8;
            label4.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 32;
            lstDepartamentos.Location = new Point(307, 57);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(420, 292);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form10MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 432);
            Controls.Add(lstDepartamentos);
            Controls.Add(label4);
            Controls.Add(lblMensajesServidor);
            Controls.Add(btnInsertarDepartamento);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form10MensajesServidor";
            Text = "Form10MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Button btnInsertarDepartamento;
        private Label lblMensajesServidor;
        private Label label4;
        private ListBox lstDepartamentos;
    }
}