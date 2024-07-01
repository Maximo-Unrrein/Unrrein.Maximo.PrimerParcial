namespace WinFormsApp
{
    partial class FrmCreacionDoctor
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
            ComboBox cmbBoxGenero;
            groupBoxDatosPersonales = new GroupBox();
            lblDNI = new Label();
            txtBoxDNI = new TextBox();
            txtBoxApellido = new TextBox();
            txtBoxNombre = new TextBox();
            lblGenero = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            groupBoxUsuario = new GroupBox();
            txtBoxMail = new TextBox();
            lblMail = new Label();
            label1 = new Label();
            txtBoxContraseñaUsuario = new TextBox();
            txtBoxNombreUsuario = new TextBox();
            lblNombreDeUsuario = new Label();
            btnBack = new Button();
            groupBoxDatosDoctor = new GroupBox();
            cmbBoxEspecialidad = new ComboBox();
            cmbBoxTurno = new ComboBox();
            lblEspecialidad = new Label();
            lblTurno = new Label();
            BtnCrear = new Button();
            btnVolverAlMenu = new Button();
            lblConfirmacion = new Label();
            cmbBoxGenero = new ComboBox();
            groupBoxDatosPersonales.SuspendLayout();
            groupBoxUsuario.SuspendLayout();
            groupBoxDatosDoctor.SuspendLayout();
            SuspendLayout();
            // 
            // cmbBoxGenero
            // 
            cmbBoxGenero.FormattingEnabled = true;
            cmbBoxGenero.Items.AddRange(new object[] { "M", "F" });
            cmbBoxGenero.Location = new Point(6, 275);
            cmbBoxGenero.Name = "cmbBoxGenero";
            cmbBoxGenero.Size = new Size(215, 23);
            cmbBoxGenero.TabIndex = 8;
            // 
            // groupBoxDatosPersonales
            // 
            groupBoxDatosPersonales.Controls.Add(lblDNI);
            groupBoxDatosPersonales.Controls.Add(txtBoxDNI);
            groupBoxDatosPersonales.Controls.Add(cmbBoxGenero);
            groupBoxDatosPersonales.Controls.Add(txtBoxApellido);
            groupBoxDatosPersonales.Controls.Add(txtBoxNombre);
            groupBoxDatosPersonales.Controls.Add(lblGenero);
            groupBoxDatosPersonales.Controls.Add(lblApellido);
            groupBoxDatosPersonales.Controls.Add(lblNombre);
            groupBoxDatosPersonales.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDatosPersonales.Location = new Point(54, 37);
            groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            groupBoxDatosPersonales.Size = new Size(234, 381);
            groupBoxDatosPersonales.TabIndex = 0;
            groupBoxDatosPersonales.TabStop = false;
            groupBoxDatosPersonales.Text = "Datos Personales";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(6, 180);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(47, 15);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "D.N.I";
            // 
            // txtBoxDNI
            // 
            txtBoxDNI.Location = new Point(6, 198);
            txtBoxDNI.Name = "txtBoxDNI";
            txtBoxDNI.Size = new Size(215, 25);
            txtBoxDNI.TabIndex = 7;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(6, 131);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(215, 25);
            txtBoxApellido.TabIndex = 5;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(6, 55);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(215, 25);
            txtBoxNombre.TabIndex = 4;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(6, 257);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(55, 15);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "Genero";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 113);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(71, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // groupBoxUsuario
            // 
            groupBoxUsuario.Controls.Add(txtBoxMail);
            groupBoxUsuario.Controls.Add(lblMail);
            groupBoxUsuario.Controls.Add(label1);
            groupBoxUsuario.Controls.Add(txtBoxContraseñaUsuario);
            groupBoxUsuario.Controls.Add(txtBoxNombreUsuario);
            groupBoxUsuario.Controls.Add(lblNombreDeUsuario);
            groupBoxUsuario.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxUsuario.Location = new Point(308, 37);
            groupBoxUsuario.Name = "groupBoxUsuario";
            groupBoxUsuario.Size = new Size(272, 220);
            groupBoxUsuario.TabIndex = 1;
            groupBoxUsuario.TabStop = false;
            groupBoxUsuario.Text = "Datos Usuario";
            // 
            // txtBoxMail
            // 
            txtBoxMail.Location = new Point(6, 177);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.Size = new Size(241, 25);
            txtBoxMail.TabIndex = 5;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(6, 154);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(39, 15);
            lblMail.TabIndex = 4;
            lblMail.Text = "Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 95);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 3;
            label1.Text = "Contraseña de Usuario";
            // 
            // txtBoxContraseñaUsuario
            // 
            txtBoxContraseñaUsuario.Location = new Point(6, 113);
            txtBoxContraseñaUsuario.Name = "txtBoxContraseñaUsuario";
            txtBoxContraseñaUsuario.Size = new Size(241, 25);
            txtBoxContraseñaUsuario.TabIndex = 2;
            // 
            // txtBoxNombreUsuario
            // 
            txtBoxNombreUsuario.Location = new Point(6, 55);
            txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            txtBoxNombreUsuario.Size = new Size(241, 25);
            txtBoxNombreUsuario.TabIndex = 1;
            // 
            // lblNombreDeUsuario
            // 
            lblNombreDeUsuario.AutoSize = true;
            lblNombreDeUsuario.Location = new Point(6, 37);
            lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            lblNombreDeUsuario.Size = new Size(143, 15);
            lblNombreDeUsuario.TabIndex = 0;
            lblNombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(54, 426);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(26, 23);
            btnBack.TabIndex = 8;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBoxDatosDoctor
            // 
            groupBoxDatosDoctor.Controls.Add(cmbBoxEspecialidad);
            groupBoxDatosDoctor.Controls.Add(cmbBoxTurno);
            groupBoxDatosDoctor.Controls.Add(lblEspecialidad);
            groupBoxDatosDoctor.Controls.Add(lblTurno);
            groupBoxDatosDoctor.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDatosDoctor.Location = new Point(314, 263);
            groupBoxDatosDoctor.Name = "groupBoxDatosDoctor";
            groupBoxDatosDoctor.Size = new Size(266, 151);
            groupBoxDatosDoctor.TabIndex = 9;
            groupBoxDatosDoctor.TabStop = false;
            groupBoxDatosDoctor.Text = "Datos Doctor";
            // 
            // cmbBoxEspecialidad
            // 
            cmbBoxEspecialidad.FormattingEnabled = true;
            cmbBoxEspecialidad.Location = new Point(6, 111);
            cmbBoxEspecialidad.Name = "cmbBoxEspecialidad";
            cmbBoxEspecialidad.Size = new Size(241, 23);
            cmbBoxEspecialidad.TabIndex = 3;
            // 
            // cmbBoxTurno
            // 
            cmbBoxTurno.FormattingEnabled = true;
            cmbBoxTurno.Location = new Point(6, 49);
            cmbBoxTurno.Name = "cmbBoxTurno";
            cmbBoxTurno.Size = new Size(241, 23);
            cmbBoxTurno.TabIndex = 2;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(6, 93);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(103, 15);
            lblEspecialidad.TabIndex = 1;
            lblEspecialidad.Text = "Especialidad";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(6, 31);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(47, 15);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "Turno";
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(669, 155);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(106, 51);
            BtnCrear.TabIndex = 10;
            BtnCrear.Text = "Crear";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(628, 231);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(194, 23);
            btnVolverAlMenu.TabIndex = 11;
            btnVolverAlMenu.Text = "Volver al Menu";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Location = new Point(649, 294);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(0, 15);
            lblConfirmacion.TabIndex = 12;
            // 
            // FrmCreacionDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(834, 461);
            Controls.Add(lblConfirmacion);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(BtnCrear);
            Controls.Add(groupBoxDatosDoctor);
            Controls.Add(btnBack);
            Controls.Add(groupBoxUsuario);
            Controls.Add(groupBoxDatosPersonales);
            Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCreacionDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCreacionDoctor";
            groupBoxDatosPersonales.ResumeLayout(false);
            groupBoxDatosPersonales.PerformLayout();
            groupBoxUsuario.ResumeLayout(false);
            groupBoxUsuario.PerformLayout();
            groupBoxDatosDoctor.ResumeLayout(false);
            groupBoxDatosDoctor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxDatosPersonales;
        private GroupBox groupBoxUsuario;
        private TextBox txtBoxDNI;
        private TextBox txtBoxApellido;
        private TextBox txtBoxNombre;
        private Label lblDNI;
        private Label lblGenero;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnBack;
        private TextBox txtBoxNombreUsuario;
        private Label lblNombreDeUsuario;
        private Label label1;
        private TextBox txtBoxContraseñaUsuario;
        private GroupBox groupBoxDatosDoctor;
        private TextBox txtBoxMail;
        private Label lblMail;
        private Label lblEspecialidad;
        private Label lblTurno;
        private ComboBox cmbBoxEspecialidad;
        private ComboBox cmbBoxTurno;
        private Button BtnCrear;
        private Button btnVolverAlMenu;
        private Label lblConfirmacion;
    }
}