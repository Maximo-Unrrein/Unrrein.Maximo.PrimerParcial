namespace WinFormsApp
{
    partial class FrmRecuperacionContraseña
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
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblNuevaContraseña = new Label();
            txtBoxUsuario = new TextBox();
            txtBoxContraseña = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lblConfirmacion = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("SimSun", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(191, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "RECUPERACION CONTRASEÑA";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(12, 57);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.AutoSize = true;
            lblNuevaContraseña.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNuevaContraseña.Location = new Point(12, 127);
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(135, 15);
            lblNuevaContraseña.TabIndex = 2;
            lblNuevaContraseña.Text = "Nueva contraseña";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(12, 75);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(191, 23);
            txtBoxUsuario.TabIndex = 3;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.Location = new Point(12, 145);
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.Size = new Size(191, 23);
            txtBoxContraseña.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(12, 203);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(191, 23);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confimar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(64, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmacion.Location = new Point(12, 185);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(0, 15);
            lblConfirmacion.TabIndex = 7;
            // 
            // FrmRecuperacionContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(231, 271);
            Controls.Add(lblConfirmacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtBoxContraseña);
            Controls.Add(txtBoxUsuario);
            Controls.Add(lblNuevaContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmRecuperacionContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRecuperacionContraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblNuevaContraseña;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxContraseña;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lblConfirmacion;
    }
}