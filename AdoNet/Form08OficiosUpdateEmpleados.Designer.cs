namespace AdoNet
{
    partial class Form08OficiosUpdateEmpleados
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
            lstOficios = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnUpdate = new Button();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lstEmpleados = new ListBox();
            lblMinimoSalario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.ItemHeight = 32;
            lstOficios.Location = new Point(38, 61);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(262, 164);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 25);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(621, 27);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 4;
            label3.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(626, 62);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(168, 39);
            txtIncremento.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(628, 122);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(166, 80);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Incrementar salarios";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.ForeColor = Color.Blue;
            lblSumaSalarial.Location = new Point(35, 256);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(175, 32);
            lblSumaSalarial.TabIndex = 7;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.ForeColor = Color.Red;
            lblMediaSalarial.Location = new Point(38, 302);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(182, 32);
            lblMediaSalarial.TabIndex = 8;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 32;
            lstEmpleados.Location = new Point(350, 58);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(246, 356);
            lstEmpleados.TabIndex = 3;
            // 
            // lblMinimoSalario
            // 
            lblMinimoSalario.AutoSize = true;
            lblMinimoSalario.ForeColor = Color.FromArgb(192, 0, 192);
            lblMinimoSalario.Location = new Point(38, 345);
            lblMinimoSalario.Name = "lblMinimoSalario";
            lblMinimoSalario.Size = new Size(194, 32);
            lblMinimoSalario.TabIndex = 9;
            lblMinimoSalario.Text = "lblMinimoSalario";
            // 
            // Form08OficiosUpdateEmpleados
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 437);
            Controls.Add(lblMinimoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(btnUpdate);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form08OficiosUpdateEmpleados";
            Text = "Form08OficiosUpdateEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnUpdate;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private ListBox lstEmpleados;
        private Label lblMinimoSalario;
    }
}