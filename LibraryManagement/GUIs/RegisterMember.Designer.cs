namespace LibraryManagement.GUIs
{
    partial class RegisterMember
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
            cccdTB = new TextBox();
            label3 = new Label();
            nameTB = new TextBox();
            label4 = new Label();
            phoneNoTB = new TextBox();
            label5 = new Label();
            addressTB = new TextBox();
            label6 = new Label();
            emailTB = new TextBox();
            addBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(232, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(630, 81);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÍ THÀNH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "Số CCCD:";
            // 
            // cccdTB
            // 
            cccdTB.Enabled = false;
            cccdTB.Location = new Point(270, 165);
            cccdTB.Margin = new Padding(4, 4, 4, 4);
            cccdTB.Name = "cccdTB";
            cccdTB.Size = new Size(670, 31);
            cccdTB.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 236);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 1;
            label3.Text = "Họ tên:";
            // 
            // nameTB
            // 
            nameTB.Enabled = false;
            nameTB.Location = new Point(270, 232);
            nameTB.Margin = new Padding(4, 4, 4, 4);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(670, 31);
            nameTB.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 302);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 1;
            label4.Text = "Số điện thoại:";
            // 
            // phoneNoTB
            // 
            phoneNoTB.Location = new Point(270, 299);
            phoneNoTB.Margin = new Padding(4, 4, 4, 4);
            phoneNoTB.Name = "phoneNoTB";
            phoneNoTB.Size = new Size(670, 31);
            phoneNoTB.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 375);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 1;
            label5.Text = "Địa chỉ:";
            // 
            // addressTB
            // 
            addressTB.Location = new Point(270, 371);
            addressTB.Margin = new Padding(4, 4, 4, 4);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(670, 31);
            addressTB.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 442);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 1;
            label6.Text = "Email:";
            // 
            // emailTB
            // 
            emailTB.Location = new Point(270, 439);
            emailTB.Margin = new Padding(4, 4, 4, 4);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(670, 31);
            emailTB.TabIndex = 4;
            // 
            // addBT
            // 
            addBT.Location = new Point(720, 508);
            addBT.Margin = new Padding(4, 4, 4, 4);
            addBT.Name = "addBT";
            addBT.Size = new Size(221, 36);
            addBT.TabIndex = 3;
            addBT.Text = "Thêm thành viên";
            addBT.UseVisualStyleBackColor = true;
            addBT.Click += addBT_Click;
            // 
            // RegisterMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 585);
            Controls.Add(addBT);
            Controls.Add(emailTB);
            Controls.Add(addressTB);
            Controls.Add(phoneNoTB);
            Controls.Add(nameTB);
            Controls.Add(cccdTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "RegisterMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterMember";
            Load += RegisterMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox cccdTB;
        private Label label3;
        private TextBox nameTB;
        private Label label4;
        private TextBox phoneNoTB;
        private Label label5;
        private TextBox addressTB;
        private Label label6;
        private TextBox emailTB;
        private Button addBT;
    }
}