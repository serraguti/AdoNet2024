namespace AdoNet
{
    partial class Form05DepartamentosEmpleados
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
            lstDepartamentos = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtOficio = new TextBox();
            label4 = new Label();
            txtSalario = new TextBox();
            btnModificarDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 32;
            lstDepartamentos.Location = new Point(33, 59);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(271, 228);
            lstDepartamentos.TabIndex = 1;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 22);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 32;
            lstEmpleados.Location = new Point(338, 59);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(258, 324);
            lstEmpleados.TabIndex = 3;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(623, 24);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 4;
            label3.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(630, 56);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(224, 39);
            txtOficio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(630, 108);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 6;
            label4.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(631, 142);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(223, 39);
            txtSalario.TabIndex = 7;
            // 
            // btnModificarDatos
            // 
            btnModificarDatos.Location = new Point(633, 206);
            btnModificarDatos.Name = "btnModificarDatos";
            btnModificarDatos.Size = new Size(221, 52);
            btnModificarDatos.TabIndex = 8;
            btnModificarDatos.Text = "Modificar datos";
            btnModificarDatos.UseVisualStyleBackColor = true;
            btnModificarDatos.Click += btnModificarDatos_Click;
            // 
            // Form05DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 400);
            Controls.Add(btnModificarDatos);
            Controls.Add(txtSalario);
            Controls.Add(label4);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form05DepartamentosEmpleados";
            Text = "Form05DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtOficio;
        private Label label4;
        private TextBox txtSalario;
        private Button btnModificarDatos;
    }
}