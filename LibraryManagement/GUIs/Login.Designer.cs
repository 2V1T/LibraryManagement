namespace LibraryManagement.GUIs
{
    partial class Login
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
            loginUsername = new TextBox();
            loginPass = new TextBox();
            label3 = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(189, 27);
            label1.Name = "label1";
            label1.Size = new Size(338, 72);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 169);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // loginUsername
            // 
            loginUsername.Location = new Point(201, 166);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(338, 27);
            loginUsername.TabIndex = 2;
            loginUsername.KeyDown += Login_KeyDown;
            // 
            // loginPass
            // 
            loginPass.Location = new Point(201, 230);
            loginPass.Name = "loginPass";
            loginPass.PasswordChar = '*';
            loginPass.Size = new Size(338, 27);
            loginPass.TabIndex = 3;
            loginPass.KeyDown += Login_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 233);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(445, 305);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 4;
            loginButton.Text = "Đăng nhập";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button1_Click;
            loginButton.KeyDown += loginButton_KeyDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 377);
            Controls.Add(loginButton);
            Controls.Add(loginPass);
            Controls.Add(loginUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private TextBox loginUsername;
        private TextBox loginPass;
        private Label label3;
        private Button loginButton;
    }
}