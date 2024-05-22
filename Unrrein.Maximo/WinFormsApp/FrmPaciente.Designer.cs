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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 426);
            button1.Name = "button1";
            button1.Size = new Size(29, 23);
            button1.TabIndex = 0;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(129, 195);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(129, 272);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 177);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Doctor";
            // 
            // button2
            // 
            button2.Location = new Point(376, 272);
            button2.Name = "button2";
            button2.Size = new Size(248, 23);
            button2.TabIndex = 8;
            button2.Text = "Confirmar Turno";
            button2.UseVisualStyleBackColor = true;
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(129, 351);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(495, 64);
            listBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(129, 333);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 12;
            label6.Text = "Datos del Turno";
            // 
            // FrmPaciente
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(761, 461);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPaciente";
            Text = "FrmPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private Label label6;
    }
}