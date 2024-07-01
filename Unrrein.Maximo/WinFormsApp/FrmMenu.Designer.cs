namespace WinFormsApp
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenido = new Label();
            btnIngresar = new Button();
            btnRegistrarse = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("SimSun", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(291, 56);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(237, 29);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "¡ Bienvenido !";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(335, 199);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(120, 23);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(334, 306);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(120, 23);
            btnRegistrarse.TabIndex = 2;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 85);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 3;
            label1.Text = "------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(247, 117);
            label2.Name = "label2";
            label2.Size = new Size(327, 15);
            label2.TabIndex = 4;
            label2.Text = "Si desea tener una consulta medica . . .";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(283, 142);
            label3.Name = "label3";
            label3.Size = new Size(215, 15);
            label3.TabIndex = 5;
            label3.Text = "está en el lugar correcto!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(225, 279);
            label4.Name = "label4";
            label4.Size = new Size(359, 15);
            label4.TabIndex = 6;
            label4.Text = "Si todavia no tiene una cuenta, ingrese aquí";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(830, 457);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIngresar);
            Controls.Add(lblBienvenido);
            Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Button btnIngresar;
        private Button btnRegistrarse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}