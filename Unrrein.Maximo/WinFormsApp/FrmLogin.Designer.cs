namespace WinFormsApp
{
    partial class FrmLogin
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
            txtBoxUsuario = new TextBox();
            txtBoxContraseña = new TextBox();
            btnIngresar = new Button();
            linkLabel1 = new LinkLabel();
            lblConfirmacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 108);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(301, 232);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            label2.UseWaitCursor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 426);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(26, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.UseWaitCursor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(301, 126);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(221, 25);
            txtBoxUsuario.TabIndex = 3;
            txtBoxUsuario.UseWaitCursor = true;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.Location = new Point(301, 250);
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.Size = new Size(221, 25);
            txtBoxContraseña.TabIndex = 4;
            txtBoxContraseña.UseWaitCursor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(360, 329);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(92, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.UseWaitCursor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(223, 287);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(403, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿No recuerdas tu contraseña? Haga click aquí";
            linkLabel1.UseWaitCursor = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.ForeColor = Color.Firebrick;
            lblConfirmacion.Location = new Point(283, 373);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(0, 15);
            lblConfirmacion.TabIndex = 7;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(834, 461);
            Controls.Add(lblConfirmacion);
            Controls.Add(linkLabel1);
            Controls.Add(btnIngresar);
            Controls.Add(txtBoxContraseña);
            Controls.Add(txtBoxUsuario);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBack;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxContraseña;
        private Button btnIngresar;
        private LinkLabel linkLabel1;
        private Label lblConfirmacion;
    }
}