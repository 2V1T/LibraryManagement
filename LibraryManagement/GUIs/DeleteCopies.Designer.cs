namespace LibraryManagement.GUIs
{
    partial class DeleteCopies
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
            copiesCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bookNameTB = new TextBox();
            deleteBTN = new Button();
            SuspendLayout();
            // 
            // copiesCB
            // 
            copiesCB.FormattingEnabled = true;
            copiesCB.Location = new Point(72, 239);
            copiesCB.Name = "copiesCB";
            copiesCB.Size = new Size(530, 28);
            copiesCB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(194, 9);
            label1.Name = "label1";
            label1.Size = new Size(377, 72);
            label1.TabIndex = 1;
            label1.Text = "XÓA BẢN SAO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 195);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Bản sao:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 96);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên sách:";
            // 
            // bookNameTB
            // 
            bookNameTB.Location = new Point(72, 135);
            bookNameTB.Name = "bookNameTB";
            bookNameTB.ReadOnly = true;
            bookNameTB.Size = new Size(530, 27);
            bookNameTB.TabIndex = 4;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(508, 311);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(94, 29);
            deleteBTN.TabIndex = 5;
            deleteBTN.Text = "Xóa";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // DeleteCopies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 374);
            Controls.Add(deleteBTN);
            Controls.Add(bookNameTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(copiesCB);
            Name = "DeleteCopies";
            Text = "DeleteCopies";
            Load += DeleteCopies_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox copiesCB;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox bookNameTB;
        private Button deleteBTN;
    }
}