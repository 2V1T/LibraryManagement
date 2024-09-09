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
            label1.Location = new Point(204, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(523, 67);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(289, 191);
            nameTB.Margin = new Padding(4);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(525, 31);
            nameTB.TabIndex = 3;
            nameTB.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 195);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên đầy đủ:";
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 261);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 4;
            label7.Text = "Email:";
            label7.Click += label3_Click;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(289, 258);
            emailTB.Margin = new Padding(4);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(528, 31);
            emailTB.TabIndex = 3;
            emailTB.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(98, 321);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 4;
            label8.Text = "Địa chỉ:";
            label8.Click += label3_Click;
            // 
            // addressTB
            // 
            addressTB.Location = new Point(290, 321);
            addressTB.Margin = new Padding(4);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(528, 31);
            addressTB.TabIndex = 3;
            addressTB.TextChanged += textBox2_TextChanged;
            // 
            // phoneNoTB
            // 
            phoneNoTB.Location = new Point(289, 376);
            phoneNoTB.Margin = new Padding(4);
            phoneNoTB.Name = "phoneNoTB";
            phoneNoTB.Size = new Size(528, 31);
            phoneNoTB.TabIndex = 3;
            phoneNoTB.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(98, 380);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(121, 25);
            label10.TabIndex = 4;
            label10.Text = "Số điện thoại:";
            label10.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(688, 456);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 6;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameLB
            // 
            usernameLB.AutoSize = true;
            usernameLB.Location = new Point(289, 132);
            usernameLB.Margin = new Padding(4, 0, 4, 0);
            usernameLB.Name = "usernameLB";
            usernameLB.Size = new Size(128, 25);
            usernameLB.TabIndex = 7;
            usernameLB.Text = "ten dang nhap";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 539);
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
            Margin = new Padding(4);
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