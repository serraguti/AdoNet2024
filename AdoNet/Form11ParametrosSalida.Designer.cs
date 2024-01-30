namespace AdoNet
{
    partial class Form11ParametrosSalida
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
            cmbDepartamentos = new ComboBox();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            label3 = new Label();
            txtMedia = new TextBox();
            label4 = new Label();
            txtPersonas = new TextBox();
            label5 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(36, 75);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(236, 40);
            cmbDepartamentos.TabIndex = 1;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(36, 136);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(236, 52);
            btnMostrarDatos.TabIndex = 2;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 215);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 3;
            label2.Text = "Suma:";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(43, 248);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(229, 39);
            txtSuma.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 299);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 5;
            label3.Text = "Media";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(39, 336);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(233, 39);
            txtMedia.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 389);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 7;
            label4.Text = "Personas";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(41, 432);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(231, 39);
            txtPersonas.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 19);
            label5.Name = "label5";
            label5.Size = new Size(130, 32);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 32;
            lstEmpleados.Location = new Point(361, 59);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(368, 420);
            lstEmpleados.TabIndex = 10;
            // 
            // Form11ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 490);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtMedia);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form11ParametrosSalida";
            Text = "Form11ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtSuma;
        private Label label3;
        private TextBox txtMedia;
        private Label label4;
        private TextBox txtPersonas;
        private Label label5;
        private ListBox lstEmpleados;
    }
}