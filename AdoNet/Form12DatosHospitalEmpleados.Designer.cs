namespace AdoNet
{
    partial class Form12DatosHospitalEmpleados
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
            lstEmpleados = new ListBox();
            label5 = new Label();
            txtPersonas = new TextBox();
            label4 = new Label();
            txtMedia = new TextBox();
            label3 = new Label();
            txtSuma = new TextBox();
            label2 = new Label();
            cmbHospitales = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            txtSalario = new TextBox();
            label7 = new Label();
            txtOficio = new TextBox();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 32;
            lstEmpleados.Location = new Point(374, 51);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(368, 420);
            lstEmpleados.TabIndex = 21;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 11);
            label5.Name = "label5";
            label5.Size = new Size(130, 32);
            label5.TabIndex = 20;
            label5.Text = "Empleados";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(49, 372);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(231, 39);
            txtPersonas.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 329);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 18;
            label4.Text = "Personas";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(47, 276);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(233, 39);
            txtMedia.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 239);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 16;
            label3.Text = "Media";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(51, 188);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(229, 39);
            txtSuma.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 155);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 14;
            label2.Text = "Suma:";
            // 
            // cmbHospitales
            // 
            cmbHospitales.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(49, 67);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(236, 40);
            cmbHospitales.TabIndex = 12;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(762, 50);
            label6.Name = "label6";
            label6.Size = new Size(90, 32);
            label6.TabIndex = 22;
            label6.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(770, 84);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(185, 39);
            txtSalario.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(771, 142);
            label7.Name = "label7";
            label7.Size = new Size(77, 32);
            label7.TabIndex = 24;
            label7.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(771, 177);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(184, 39);
            txtOficio.TabIndex = 25;
            // 
            // Form12DatosHospitalEmpleados
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 477);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtMedia);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form12DatosHospitalEmpleados";
            Text = "Form12DatosHospitalEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private Label label5;
        private TextBox txtPersonas;
        private Label label4;
        private TextBox txtMedia;
        private Label label3;
        private TextBox txtSuma;
        private Label label2;
        private ComboBox cmbHospitales;
        private Label label1;
        private Label label6;
        private TextBox txtSalario;
        private Label label7;
        private TextBox txtOficio;
    }
}