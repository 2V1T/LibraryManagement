namespace LibraryManagement.GUIs
{
    partial class ChangePassword
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
            oldPassTB = new TextBox();
            label3 = new Label();
            newPassTB = new TextBox();
            label4 = new Label();
            retypePassTB = new TextBox();
            submitBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(198, 19);
            label1.Name = "label1";
            label1.Size = new Size(377, 67);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 134);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu cũ: ";
            // 
            // oldPassTB
            // 
            oldPassTB.Location = new Point(242, 131);
            oldPassTB.Name = "oldPassTB";
            oldPassTB.Size = new Size(333, 27);
            oldPassTB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 195);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu mới: ";
            // 
            // newPassTB
            // 
            newPassTB.Location = new Point(242, 192);
            newPassTB.Name = "newPassTB";
            newPassTB.Size = new Size(333, 27);
            newPassTB.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 259);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 1;
            label4.Text = "Nhập lại mật khẩu:";
            // 
            // retypePassTB
            // 
            retypePassTB.Location = new Point(242, 256);
            retypePassTB.Name = "retypePassTB";
            retypePassTB.Size = new Size(333, 27);
            retypePassTB.TabIndex = 2;
            // 
            // submitBT
            // 
            submitBT.Location = new Point(481, 315);
            submitBT.Name = "submitBT";
            submitBT.Size = new Size(94, 29);
            submitBT.TabIndex = 3;
            submitBT.Text = "Đổi";
            submitBT.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 371);
            Controls.Add(submitBT);
            Controls.Add(retypePassTB);
            Controls.Add(newPassTB);
            Controls.Add(oldPassTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox oldPassTB;
        private Label label3;
        private TextBox newPassTB;
        private Label label4;
        private TextBox retypePassTB;
        private Button submitBT;
    }
}