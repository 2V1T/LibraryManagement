using AForge.Video.DirectShow;

namespace LibraryManagement.GUIs
{
    partial class QRReader
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
            this.components = new System.ComponentModel.Container();
            this.startScanBt = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startScanBt
            // 
            this.startScanBt.Location = new System.Drawing.Point(405, 390);
            this.startScanBt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startScanBt.Name = "startScanBt";
            this.startScanBt.Size = new System.Drawing.Size(106, 29);
            this.startScanBt.TabIndex = 0;
            this.startScanBt.Text = "Start";
            this.startScanBt.UseVisualStyleBackColor = true;
            this.startScanBt.Click += new System.EventHandler(this.startScanBt_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(28, 104);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(512, 254);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(28, 47);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(512, 28);
            this.comboBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 393);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status: ";
            // 
            // statusLB
            // 
            this.statusLB.AutoSize = true;
            this.statusLB.ForeColor = System.Drawing.Color.DarkBlue;
            this.statusLB.Location = new System.Drawing.Point(122, 394);
            this.statusLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(67, 20);
            this.statusLB.TabIndex = 8;
            this.statusLB.Text = "Pending";
            this.statusLB.Visible = false;
            // 
            // QRReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.statusLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.startScanBt);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QRReader";
            this.Text = "Thành viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRReader_FormClosing);
            this.Load += new System.EventHandler(this.QRReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void QRReader_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Button startScanBt;
        private PictureBox pictureBox;
        private ComboBox comboBox;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label statusLB;
    }
}