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
            label1.Location = new Point(248, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(452, 81);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu cũ: ";
            // 
            // oldPassTB
            // 
            oldPassTB.Location = new Point(302, 164);
            oldPassTB.Margin = new Padding(4, 4, 4, 4);
            oldPassTB.Name = "oldPassTB";
            oldPassTB.Size = new Size(415, 31);
            oldPassTB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 244);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu mới: ";
            // 
            // newPassTB
            // 
            newPassTB.Location = new Point(302, 240);
            newPassTB.Margin = new Padding(4, 4, 4, 4);
            newPassTB.Name = "newPassTB";
            newPassTB.Size = new Size(415, 31);
            newPassTB.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 324);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 1;
            label4.Text = "Nhập lại mật khẩu:";
            // 
            // retypePassTB
            // 
            retypePassTB.Location = new Point(302, 320);
            retypePassTB.Margin = new Padding(4, 4, 4, 4);
            retypePassTB.Name = "retypePassTB";
            retypePassTB.Size = new Size(415, 31);
            retypePassTB.TabIndex = 2;
            // 
            // submitBT
            // 
            submitBT.Location = new Point(601, 394);
            submitBT.Margin = new Padding(4, 4, 4, 4);
            submitBT.Name = "submitBT";
            submitBT.Size = new Size(118, 36);
            submitBT.TabIndex = 3;
            submitBT.Text = "Đổi";
            submitBT.UseVisualStyleBackColor = true;
            submitBT.Click += submitBT_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 464);
            Controls.Add(submitBT);
            Controls.Add(retypePassTB);
            Controls.Add(newPassTB);
            Controls.Add(oldPassTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
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