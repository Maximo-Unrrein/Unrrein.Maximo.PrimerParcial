namespace WinFormsApp
{
    partial class FrmAdmin
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
            dataGridViewUsuarios = new DataGridView();
            Seleccion = new DataGridViewCheckBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Ocupacion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            btnEliminar = new Button();
            btnBack = new Button();
            btnCrearDoctor = new Button();
            lblConfirmacion = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.AllowUserToResizeColumns = false;
            dataGridViewUsuarios.AllowUserToResizeRows = false;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { Seleccion, Usuario, Contraseña, Ocupacion });
            dataGridViewUsuarios.Location = new Point(156, 64);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowTemplate.Height = 25;
            dataGridViewUsuarios.Size = new Size(543, 348);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // Seleccion
            // 
            Seleccion.HeaderText = "Seleccion";
            Seleccion.Name = "Seleccion";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            Contraseña.ReadOnly = true;
            // 
            // Ocupacion
            // 
            Ocupacion.HeaderText = "Ocupacion";
            Ocupacion.Name = "Ocupacion";
            Ocupacion.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 1;
            label1.Text = "ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(156, 46);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuarios";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(615, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(84, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 426);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(24, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCrearDoctor
            // 
            btnCrearDoctor.BackColor = Color.YellowGreen;
            btnCrearDoctor.Location = new Point(156, 426);
            btnCrearDoctor.Name = "btnCrearDoctor";
            btnCrearDoctor.Size = new Size(121, 23);
            btnCrearDoctor.TabIndex = 5;
            btnCrearDoctor.Text = "Crear Doctor";
            btnCrearDoctor.UseVisualStyleBackColor = false;
            btnCrearDoctor.Click += btnCrearDoctor_Click;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Location = new Point(12, 127);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(0, 15);
            lblConfirmacion.TabIndex = 6;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(834, 461);
            Controls.Add(lblConfirmacion);
            Controls.Add(btnCrearDoctor);
            Controls.Add(btnBack);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewUsuarios);
            Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsuarios;
        private Label label1;
        private Label label2;
        private DataGridViewCheckBoxColumn Seleccion;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Ocupacion;
        private Button btnEliminar;
        private Button btnBack;
        private Button btnCrearDoctor;
        private Label lblConfirmacion;
    }
}