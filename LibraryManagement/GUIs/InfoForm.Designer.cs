namespace LibraryManagement.GUIs
{
    partial class InfoForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label10 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(163, 26);
            label1.Name = "label1";
            label1.Size = new Size(441, 57);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 106);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(231, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(421, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 156);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên đầy đủ:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 209);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 5;
            label4.Text = "Password cũ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 265);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 5;
            label5.Text = "Password mới:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 312);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 5;
            label6.Text = "Nhập lại password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(421, 27);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 262);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(423, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox2_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(231, 309);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(423, 27);
            textBox5.TabIndex = 3;
            textBox5.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 362);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 4;
            label7.Text = "Email:";
            label7.Click += label3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(229, 359);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(423, 27);
            textBox6.TabIndex = 3;
            textBox6.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 410);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 4;
            label8.Text = "Địa chỉ:";
            label8.Click += label3_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(231, 407);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(423, 27);
            textBox7.TabIndex = 3;
            textBox7.TextChanged += textBox2_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(229, 454);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(423, 27);
            textBox8.TabIndex = 3;
            textBox8.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 457);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 4;
            label10.Text = "Số điện thoại:";
            label10.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(548, 518);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 6;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label10;
        private Button button1;
    }
}