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
            components = new System.ComponentModel.Container();
            startScanBt = new Button();
            pictureBox = new PictureBox();
            comboBox = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            statusLB = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // startScanBt
            // 
            startScanBt.Location = new Point(450, 488);
            startScanBt.Margin = new Padding(4, 4, 4, 4);
            startScanBt.Name = "startScanBt";
            startScanBt.Size = new Size(118, 36);
            startScanBt.TabIndex = 0;
            startScanBt.Text = "Start";
            startScanBt.UseVisualStyleBackColor = true;
            startScanBt.Click += startScanBt_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(31, 130);
            pictureBox.Margin = new Padding(4, 4, 4, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(569, 318);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(31, 59);
            comboBox.Margin = new Padding(4, 4, 4, 4);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(568, 33);
            comboBox.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 491);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 7;
            label1.Text = "Status: ";
            // 
            // statusLB
            // 
            statusLB.AutoSize = true;
            statusLB.ForeColor = Color.DarkBlue;
            statusLB.Location = new Point(135, 492);
            statusLB.Margin = new Padding(4, 0, 4, 0);
            statusLB.Name = "statusLB";
            statusLB.Size = new Size(76, 25);
            statusLB.TabIndex = 8;
            statusLB.Text = "Pending";
            statusLB.Visible = false;
            // 
            // QRReader
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 562);
            Controls.Add(statusLB);
            Controls.Add(label1);
            Controls.Add(comboBox);
            Controls.Add(pictureBox);
            Controls.Add(startScanBt);
            Margin = new Padding(4, 4, 4, 4);
            Name = "QRReader";
            Text = "Thành viên";
            FormClosing += QRReader_FormClosing;
            Load += QRReader_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void QRReader_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                comboBox.Items.Add(filterInfo.Name);
                comboBox.SelectedIndex = 0;
            }
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