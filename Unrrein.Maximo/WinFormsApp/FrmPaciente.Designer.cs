namespace WinFormsApp
{
    partial class FrmPaciente
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
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            cmbBoxEspecialidad = new ComboBox();
            cmbBoxDoctor = new ComboBox();
            cmbBoxHora = new ComboBox();
            label3 = new Label();
            btnConfirmarTurno = new Button();
            label4 = new Label();
            label5 = new Label();
            lblDatosDelTurno = new Label();
            lblDatosTurno = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 426);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(23, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 254);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 98);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Especialidad";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(376, 98);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // cmbBoxEspecialidad
            // 
            cmbBoxEspecialidad.FormattingEnabled = true;
            cmbBoxEspecialidad.Location = new Point(129, 116);
            cmbBoxEspecialidad.Name = "cmbBoxEspecialidad";
            cmbBoxEspecialidad.Size = new Size(186, 23);
            cmbBoxEspecialidad.TabIndex = 4;
            cmbBoxEspecialidad.SelectedIndexChanged += cmbBoxEspecialidad_SelectedIndexChanged;
            // 
            // cmbBoxDoctor
            // 
            cmbBoxDoctor.FormattingEnabled = true;
            cmbBoxDoctor.Location = new Point(129, 197);
            cmbBoxDoctor.Name = "cmbBoxDoctor";
            cmbBoxDoctor.Size = new Size(186, 23);
            cmbBoxDoctor.TabIndex = 5;
            cmbBoxDoctor.SelectedIndexChanged += cmbBoxDoctor_SelectedIndexChanged;
            // 
            // cmbBoxHora
            // 
            cmbBoxHora.FormattingEnabled = true;
            cmbBoxHora.Location = new Point(129, 272);
            cmbBoxHora.Name = "cmbBoxHora";
            cmbBoxHora.Size = new Size(186, 23);
            cmbBoxHora.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 179);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Doctor";
            // 
            // btnConfirmarTurno
            // 
            btnConfirmarTurno.Location = new Point(376, 272);
            btnConfirmarTurno.Name = "btnConfirmarTurno";
            btnConfirmarTurno.Size = new Size(248, 23);
            btnConfirmarTurno.TabIndex = 8;
            btnConfirmarTurno.Text = "Confirmar Turno";
            btnConfirmarTurno.UseVisualStyleBackColor = true;
            btnConfirmarTurno.Click += btnConfirmarTurno_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 19);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 9;
            label4.Text = "TURNO ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 38);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "-------";
            // 
            // lblDatosDelTurno
            // 
            lblDatosDelTurno.AutoSize = true;
            lblDatosDelTurno.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosDelTurno.Location = new Point(129, 333);
            lblDatosDelTurno.Name = "lblDatosDelTurno";
            lblDatosDelTurno.Size = new Size(135, 15);
            lblDatosDelTurno.TabIndex = 12;
            lblDatosDelTurno.Text = "DATOS DEL TURNO:";
            // 
            // lblDatosTurno
            // 
            lblDatosTurno.AutoSize = true;
            lblDatosTurno.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosTurno.Location = new Point(129, 358);
            lblDatosTurno.Name = "lblDatosTurno";
            lblDatosTurno.Size = new Size(0, 15);
            lblDatosTurno.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Location = new Point(522, 426);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmPaciente
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(761, 461);
            Controls.Add(btnCancelar);
            Controls.Add(lblDatosTurno);
            Controls.Add(lblDatosDelTurno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnConfirmarTurno);
            Controls.Add(cmbBoxHora);
            Controls.Add(label3);
            Controls.Add(cmbBoxDoctor);
            Controls.Add(cmbBoxEspecialidad);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private ComboBox cmbBoxEspecialidad;
        private ComboBox cmbBoxDoctor;
        private ComboBox cmbBoxHora;
        private Label label3;
        private Button btnConfirmarTurno;
        private Label label4;
        private Label label5;
        private ListBox lstBoxDatosDelTurno;
        private Label lblDatosDelTurno;
        private Label lblDatosTurno;
        private Button btnCancelar;
    }
}