namespace AdoNet
{
    partial class Form03EliminarEnfermos
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
            txtInscripcion = new TextBox();
            btnEliminarEnfermo = new Button();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "Inscripción";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(26, 53);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(190, 39);
            txtInscripcion.TabIndex = 1;
            // 
            // btnEliminarEnfermo
            // 
            btnEliminarEnfermo.Location = new Point(26, 117);
            btnEliminarEnfermo.Name = "btnEliminarEnfermo";
            btnEliminarEnfermo.Size = new Size(190, 45);
            btnEliminarEnfermo.TabIndex = 2;
            btnEliminarEnfermo.Text = "Eliminar enfermo";
            btnEliminarEnfermo.UseVisualStyleBackColor = true;
            btnEliminarEnfermo.Click += btnEliminarEnfermo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 15);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.ItemHeight = 32;
            lstEnfermos.Location = new Point(253, 53);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(348, 292);
            lstEnfermos.TabIndex = 4;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 361);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(btnEliminarEnfermo);
            Controls.Add(txtInscripcion);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInscripcion;
        private Button btnEliminarEnfermo;
        private Label label2;
        private ListBox lstEnfermos;
    }
}