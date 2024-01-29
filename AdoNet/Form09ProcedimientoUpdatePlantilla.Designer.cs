namespace AdoNet
{
    partial class Form09ProcedimientoUpdatePlantilla
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
            cmbHospitales = new ComboBox();
            btnModificarSalarios = new Button();
            label2 = new Label();
            lstPlantilla = new ListBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(35, 53);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(259, 40);
            cmbHospitales.TabIndex = 1;
            // 
            // btnModificarSalarios
            // 
            btnModificarSalarios.Location = new Point(354, 43);
            btnModificarSalarios.Name = "btnModificarSalarios";
            btnModificarSalarios.Size = new Size(178, 77);
            btnModificarSalarios.TabIndex = 2;
            btnModificarSalarios.Text = "Modificar salarios";
            btnModificarSalarios.UseVisualStyleBackColor = true;
            btnModificarSalarios.Click += btnModificarSalarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 116);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 3;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.ItemHeight = 32;
            lstPlantilla.Location = new Point(35, 154);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(509, 196);
            lstPlantilla.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(190, 9);
            button1.Name = "button1";
            button1.Size = new Size(119, 38);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 8);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // Form09ProcedimientoUpdatePlantilla
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 363);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(btnModificarSalarios);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form09ProcedimientoUpdatePlantilla";
            Text = "Form09ProcedimientoUpdatePlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Button btnModificarSalarios;
        private Label label2;
        private ListBox lstPlantilla;
        private Button button1;
        private Label label3;
    }
}