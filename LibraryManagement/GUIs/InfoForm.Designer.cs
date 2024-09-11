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
            nameTB = new TextBox();
            label3 = new Label();
            label7 = new Label();
            emailTB = new TextBox();
            label8 = new Label();
            addressTB = new TextBox();
            phoneNoTB = new TextBox();
            label10 = new Label();
            button1 = new Button();
            usernameLB = new Label();
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
            // nameTB
            // 
            nameTB.Location = new Point(231, 153);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(421, 27);
            nameTB.TabIndex = 0;
            nameTB.TextChanged += textBox2_TextChanged;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 209);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 4;
            label7.Text = "Email:";
            label7.Click += label3_Click;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(231, 206);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(423, 27);
            emailTB.TabIndex = 1;
            emailTB.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 257);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 4;
            label8.Text = "Địa chỉ:";
            label8.Click += label3_Click;
            // 
            // addressTB
            // 
            addressTB.Location = new Point(232, 257);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(423, 27);
            addressTB.TabIndex = 2;
            addressTB.TextChanged += textBox2_TextChanged;
            // 
            // phoneNoTB
            // 
            phoneNoTB.Location = new Point(231, 301);
            phoneNoTB.Name = "phoneNoTB";
            phoneNoTB.Size = new Size(423, 27);
            phoneNoTB.TabIndex = 3;
            phoneNoTB.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(78, 304);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 4;
            label10.Text = "Số điện thoại:";
            label10.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(550, 365);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 4;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameLB
            // 
            usernameLB.AutoSize = true;
            usernameLB.Location = new Point(231, 106);
            usernameLB.Name = "usernameLB";
            usernameLB.Size = new Size(105, 20);
            usernameLB.TabIndex = 7;
            usernameLB.Text = "ten dang nhap";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 431);
            Controls.Add(usernameLB);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(phoneNoTB);
            Controls.Add(addressTB);
            Controls.Add(emailTB);
            Controls.Add(nameTB);
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
        private TextBox nameTB;
        private Label label3;
        private Label label7;
        private TextBox emailTB;
        private Label label8;
        private TextBox addressTB;
        private TextBox phoneNoTB;
        private Label label10;
        private Button button1;
        private Label usernameLB;
    }
}