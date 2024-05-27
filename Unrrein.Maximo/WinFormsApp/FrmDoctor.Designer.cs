namespace WinFormsApp
{
    partial class FrmDoctor
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
            label2 = new Label();
            btnBack = new Button();
            btnMostrarDatosPaciente = new Button();
            cmbBoxPacientes = new ComboBox();
            lstBoxDatos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 115);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(435, 54);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Datos:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 426);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(23, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnMostrarDatosPaciente
            // 
            btnMostrarDatosPaciente.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrarDatosPaciente.Location = new Point(152, 298);
            btnMostrarDatosPaciente.Name = "btnMostrarDatosPaciente";
            btnMostrarDatosPaciente.Size = new Size(173, 93);
            btnMostrarDatosPaciente.TabIndex = 3;
            btnMostrarDatosPaciente.Text = "Mostrar Datos del paciente";
            btnMostrarDatosPaciente.UseVisualStyleBackColor = true;
            btnMostrarDatosPaciente.Click += btnMostrarDatosPaciente_Click;
            // 
            // cmbBoxPacientes
            // 
            cmbBoxPacientes.AllowDrop = true;
            cmbBoxPacientes.FormattingEnabled = true;
            cmbBoxPacientes.Location = new Point(152, 133);
            cmbBoxPacientes.Name = "cmbBoxPacientes";
            cmbBoxPacientes.Size = new Size(173, 23);
            cmbBoxPacientes.TabIndex = 4;
            // 
            // lstBoxDatos
            // 
            lstBoxDatos.FormattingEnabled = true;
            lstBoxDatos.ItemHeight = 15;
            lstBoxDatos.Location = new Point(435, 72);
            lstBoxDatos.Name = "lstBoxDatos";
            lstBoxDatos.Size = new Size(352, 319);
            lstBoxDatos.TabIndex = 5;
            // 
            // FrmDoctor
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(834, 461);
            Controls.Add(lstBoxDatos);
            Controls.Add(cmbBoxPacientes);
            Controls.Add(btnMostrarDatosPaciente);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDoctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBack;
        private Button btnMostrarDatosPaciente;
        private ComboBox cmbBoxPacientes;
        private ListBox lstBoxDatos;
    }
}