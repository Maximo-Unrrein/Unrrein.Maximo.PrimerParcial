namespace WinFormsApp
{
    partial class FrmCreation
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxUsuario = new TextBox();
            txtBoxContraseña = new TextBox();
            txtBoxConfirmarContraseña = new TextBox();
            button1 = new Button();
            btnCrearUsuario = new Button();
            grpBoxDatosPersona = new GroupBox();
            txtBoxDNIPersona = new TextBox();
            txtBoxApellidoPersona = new TextBox();
            txtBoxNombrePersona = new TextBox();
            cmbBoxGeneroPersona = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            lblConfirmacionCreacionUsuario = new Label();
            grpBoxDatosPersona.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "CREACION USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "----------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 103);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(118, 169);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(118, 235);
            label5.Name = "label5";
            label5.Size = new Size(167, 15);
            label5.TabIndex = 4;
            label5.Text = "Confirmar Contraseña";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(118, 121);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(212, 25);
            txtBoxUsuario.TabIndex = 5;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.Location = new Point(118, 187);
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.Size = new Size(212, 25);
            txtBoxContraseña.TabIndex = 6;
            // 
            // txtBoxConfirmarContraseña
            // 
            txtBoxConfirmarContraseña.Location = new Point(118, 253);
            txtBoxConfirmarContraseña.Name = "txtBoxConfirmarContraseña";
            txtBoxConfirmarContraseña.Size = new Size(212, 25);
            txtBoxConfirmarContraseña.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(12, 426);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 8;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(105, 328);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(239, 23);
            btnCrearUsuario.TabIndex = 9;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // grpBoxDatosPersona
            // 
            grpBoxDatosPersona.Controls.Add(txtBoxDNIPersona);
            grpBoxDatosPersona.Controls.Add(txtBoxApellidoPersona);
            grpBoxDatosPersona.Controls.Add(txtBoxNombrePersona);
            grpBoxDatosPersona.Controls.Add(cmbBoxGeneroPersona);
            grpBoxDatosPersona.Controls.Add(label9);
            grpBoxDatosPersona.Controls.Add(label8);
            grpBoxDatosPersona.Controls.Add(label7);
            grpBoxDatosPersona.Controls.Add(label6);
            grpBoxDatosPersona.Location = new Point(413, 87);
            grpBoxDatosPersona.Name = "grpBoxDatosPersona";
            grpBoxDatosPersona.Size = new Size(370, 218);
            grpBoxDatosPersona.TabIndex = 10;
            grpBoxDatosPersona.TabStop = false;
            grpBoxDatosPersona.Text = "Datos persona";
            // 
            // txtBoxDNIPersona
            // 
            txtBoxDNIPersona.Location = new Point(152, 123);
            txtBoxDNIPersona.Name = "txtBoxDNIPersona";
            txtBoxDNIPersona.Size = new Size(194, 25);
            txtBoxDNIPersona.TabIndex = 7;
            // 
            // txtBoxApellidoPersona
            // 
            txtBoxApellidoPersona.Location = new Point(152, 79);
            txtBoxApellidoPersona.Name = "txtBoxApellidoPersona";
            txtBoxApellidoPersona.Size = new Size(194, 25);
            txtBoxApellidoPersona.TabIndex = 6;
            // 
            // txtBoxNombrePersona
            // 
            txtBoxNombrePersona.Location = new Point(152, 34);
            txtBoxNombrePersona.Name = "txtBoxNombrePersona";
            txtBoxNombrePersona.Size = new Size(194, 25);
            txtBoxNombrePersona.TabIndex = 5;
            // 
            // cmbBoxGeneroPersona
            // 
            cmbBoxGeneroPersona.FormattingEnabled = true;
            cmbBoxGeneroPersona.Items.AddRange(new object[] { "F", "M" });
            cmbBoxGeneroPersona.Location = new Point(152, 166);
            cmbBoxGeneroPersona.Name = "cmbBoxGeneroPersona";
            cmbBoxGeneroPersona.Size = new Size(194, 23);
            cmbBoxGeneroPersona.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 169);
            label9.Name = "label9";
            label9.Size = new Size(119, 15);
            label9.TabIndex = 3;
            label9.Text = "Genero    ===>";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 126);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 2;
            label8.Text = "D.N.I     ===>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 87);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 1;
            label7.Text = "Apellido  ===>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 44);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 0;
            label6.Text = "Nombre    ===>";
            // 
            // lblConfirmacionCreacionUsuario
            // 
            lblConfirmacionCreacionUsuario.AutoSize = true;
            lblConfirmacionCreacionUsuario.Location = new Point(105, 365);
            lblConfirmacionCreacionUsuario.Name = "lblConfirmacionCreacionUsuario";
            lblConfirmacionCreacionUsuario.Size = new Size(0, 15);
            lblConfirmacionCreacionUsuario.TabIndex = 11;
            // 
            // FrmCreation
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(834, 461);
            Controls.Add(lblConfirmacionCreacionUsuario);
            Controls.Add(grpBoxDatosPersona);
            Controls.Add(btnCrearUsuario);
            Controls.Add(button1);
            Controls.Add(txtBoxConfirmarContraseña);
            Controls.Add(txtBoxContraseña);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCreation";
            Text = "Creation";
            grpBoxDatosPersona.ResumeLayout(false);
            grpBoxDatosPersona.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxContraseña;
        private TextBox txtBoxConfirmarContraseña;
        private Button button1;
        private Button btnCrearUsuario;
        private GroupBox grpBoxDatosPersona;
        private TextBox txtBoxDNIPersona;
        private TextBox txtBoxApellidoPersona;
        private TextBox txtBoxNombrePersona;
        private ComboBox cmbBoxGeneroPersona;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblConfirmacionCreacionUsuario;
    }
}