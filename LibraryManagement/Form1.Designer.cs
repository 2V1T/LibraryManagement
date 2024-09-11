namespace LibraryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hànhĐộngToolStripMenuItem = new ToolStripMenuItem();
            đổiThôngTinToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            sáchToolStripMenuItem = new ToolStripMenuItem();
            tácGiảToolStripMenuItem = new ToolStripMenuItem();
            bạnĐọcMớiToolStripMenuItem = new ToolStripMenuItem();
            đăngKíMớiToolStripMenuItem = new ToolStripMenuItem();
            tìmBạnĐọcToolStripMenuItem = new ToolStripMenuItem();
            bookPanel = new Panel();
            showAllBT = new Button();
            borrowBT = new Button();
            deleteCopyBT = new Button();
            addBookBT = new Button();
            updateBookBT = new Button();
            deleteBookBT = new Button();
            groupBox3 = new GroupBox();
            dataGridViewCopies = new DataGridView();
            label8 = new Label();
            searchBookBT = new Button();
            searchNameTB = new TextBox();
            groupBox1 = new GroupBox();
            addAuthorBT = new Button();
            deleteAuthorBT = new Button();
            dataGridViewAuthor = new DataGridView();
            authorTB = new TextBox();
            updateAuthorBT = new Button();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            deleteCategoryBT = new Button();
            updateCategoryBT = new Button();
            addCategoryBT = new Button();
            categoryTB = new TextBox();
            dataGridViewCategory = new DataGridView();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            label19 = new Label();
            quantityNumberic = new NumericUpDown();
            quantityLabel = new Label();
            label18 = new Label();
            descriptionBookAddTB = new RichTextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            nameAddBookTB = new TextBox();
            categoryAddBookCB = new ComboBox();
            authorAddBookCB = new ComboBox();
            label3 = new Label();
            searchAuthorCB = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBox4 = new ComboBox();
            searchCategoryCB = new ComboBox();
            dataGridViewBook = new DataGridView();
            memberPanel = new Panel();
            showAllMemsBT = new Button();
            groupBox5 = new GroupBox();
            statusBorrowLabel = new Label();
            detailReturnDateTB = new TextBox();
            detailCopiesIdTB = new TextBox();
            detailBookIdTB = new TextBox();
            detailBookNameTB = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            returnBT = new Button();
            searchMemberTB = new TextBox();
            searchMembersBT = new Button();
            panel3 = new Panel();
            button13 = new Button();
            button15 = new Button();
            memberEmailTB = new TextBox();
            memberAddressTB = new TextBox();
            memberPhoneNoTB = new TextBox();
            memberNameTB = new TextBox();
            memberCCCDTB = new TextBox();
            S = new Label();
            label12 = new Label();
            label11 = new Label();
            label20 = new Label();
            label10 = new Label();
            dataGridViewMember = new DataGridView();
            label9 = new Label();
            menuStrip1.SuspendLayout();
            bookPanel.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCopies).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).BeginInit();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumberic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            memberPanel.SuspendLayout();
            groupBox5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMember).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hànhĐộngToolStripMenuItem, quảnLýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1897, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hànhĐộngToolStripMenuItem
            // 
            hànhĐộngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiThôngTinToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hànhĐộngToolStripMenuItem.Name = "hànhĐộngToolStripMenuItem";
            hànhĐộngToolStripMenuItem.Size = new Size(97, 24);
            hànhĐộngToolStripMenuItem.Text = "Hành động";
            hànhĐộngToolStripMenuItem.Click += hànhĐộngToolStripMenuItem_Click;
            // 
            // đổiThôngTinToolStripMenuItem
            // 
            đổiThôngTinToolStripMenuItem.Name = "đổiThôngTinToolStripMenuItem";
            đổiThôngTinToolStripMenuItem.Size = new Size(224, 26);
            đổiThôngTinToolStripMenuItem.Text = "Đổi thông tin ";
            đổiThôngTinToolStripMenuItem.Click += đổiThôngTinToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(224, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sáchToolStripMenuItem, tácGiảToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // sáchToolStripMenuItem
            // 
            sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            sáchToolStripMenuItem.Size = new Size(146, 26);
            sáchToolStripMenuItem.Text = "Sách";
            sáchToolStripMenuItem.Click += sáchToolStripMenuItem_Click_1;
            // 
            // tácGiảToolStripMenuItem
            // 
            tácGiảToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bạnĐọcMớiToolStripMenuItem, đăngKíMớiToolStripMenuItem, tìmBạnĐọcToolStripMenuItem });
            tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            tácGiảToolStripMenuItem.Size = new Size(146, 26);
            tácGiảToolStripMenuItem.Text = "Bạn đọc";
            // 
            // bạnĐọcMớiToolStripMenuItem
            // 
            bạnĐọcMớiToolStripMenuItem.Name = "bạnĐọcMớiToolStripMenuItem";
            bạnĐọcMớiToolStripMenuItem.Size = new Size(175, 26);
            bạnĐọcMớiToolStripMenuItem.Text = "Đã đăng kí";
            bạnĐọcMớiToolStripMenuItem.Click += bạnĐọcMớiToolStripMenuItem_Click;
            // 
            // đăngKíMớiToolStripMenuItem
            // 
            đăngKíMớiToolStripMenuItem.Name = "đăngKíMớiToolStripMenuItem";
            đăngKíMớiToolStripMenuItem.Size = new Size(175, 26);
            đăngKíMớiToolStripMenuItem.Text = "Đăng kí mới";
            đăngKíMớiToolStripMenuItem.Click += đăngKíMớiToolStripMenuItem_Click;
            // 
            // tìmBạnĐọcToolStripMenuItem
            // 
            tìmBạnĐọcToolStripMenuItem.Name = "tìmBạnĐọcToolStripMenuItem";
            tìmBạnĐọcToolStripMenuItem.Size = new Size(175, 26);
            tìmBạnĐọcToolStripMenuItem.Text = "Tìm bạn đọc";
            tìmBạnĐọcToolStripMenuItem.Click += tìmBạnĐọcToolStripMenuItem_Click;
            // 
            // bookPanel
            // 
            bookPanel.Controls.Add(showAllBT);
            bookPanel.Controls.Add(borrowBT);
            bookPanel.Controls.Add(deleteCopyBT);
            bookPanel.Controls.Add(addBookBT);
            bookPanel.Controls.Add(updateBookBT);
            bookPanel.Controls.Add(deleteBookBT);
            bookPanel.Controls.Add(groupBox3);
            bookPanel.Controls.Add(label8);
            bookPanel.Controls.Add(searchBookBT);
            bookPanel.Controls.Add(searchNameTB);
            bookPanel.Controls.Add(groupBox1);
            bookPanel.Controls.Add(panel4);
            bookPanel.Controls.Add(panel2);
            bookPanel.Controls.Add(label3);
            bookPanel.Controls.Add(searchAuthorCB);
            bookPanel.Controls.Add(label2);
            bookPanel.Controls.Add(label1);
            bookPanel.Controls.Add(comboBox4);
            bookPanel.Controls.Add(searchCategoryCB);
            bookPanel.Controls.Add(dataGridViewBook);
            bookPanel.Location = new Point(69, 59);
            bookPanel.Name = "bookPanel";
            bookPanel.Size = new Size(1905, 926);
            bookPanel.TabIndex = 2;
            bookPanel.Visible = false;
            bookPanel.Paint += panel1_Paint;
            // 
            // showAllBT
            // 
            showAllBT.Location = new Point(789, 552);
            showAllBT.Name = "showAllBT";
            showAllBT.Size = new Size(94, 29);
            showAllBT.TabIndex = 11;
            showAllBT.Text = "Tất cả";
            showAllBT.UseVisualStyleBackColor = true;
            showAllBT.Click += showAllBT_Click;
            // 
            // borrowBT
            // 
            borrowBT.Location = new Point(789, 816);
            borrowBT.Name = "borrowBT";
            borrowBT.Size = new Size(94, 29);
            borrowBT.TabIndex = 8;
            borrowBT.Text = "Cho mượn";
            borrowBT.UseVisualStyleBackColor = true;
            borrowBT.Click += button4_Click;
            // 
            // deleteCopyBT
            // 
            deleteCopyBT.Location = new Point(0, 816);
            deleteCopyBT.Name = "deleteCopyBT";
            deleteCopyBT.Size = new Size(94, 29);
            deleteCopyBT.TabIndex = 10;
            deleteCopyBT.Text = "Xóa mất";
            deleteCopyBT.UseVisualStyleBackColor = true;
            // 
            // addBookBT
            // 
            addBookBT.Location = new Point(1017, 816);
            addBookBT.Name = "addBookBT";
            addBookBT.Size = new Size(94, 29);
            addBookBT.TabIndex = 0;
            addBookBT.Text = "Thêm";
            addBookBT.UseVisualStyleBackColor = true;
            // 
            // updateBookBT
            // 
            updateBookBT.Location = new Point(1594, 816);
            updateBookBT.Name = "updateBookBT";
            updateBookBT.Size = new Size(94, 29);
            updateBookBT.TabIndex = 1;
            updateBookBT.Text = "Sửa";
            updateBookBT.UseVisualStyleBackColor = true;
            updateBookBT.Click += updateBookBT_Click;
            // 
            // deleteBookBT
            // 
            deleteBookBT.Location = new Point(1324, 816);
            deleteBookBT.Name = "deleteBookBT";
            deleteBookBT.Size = new Size(94, 29);
            deleteBookBT.TabIndex = 1;
            deleteBookBT.Text = "Xóa ";
            deleteBookBT.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewCopies);
            groupBox3.Location = new Point(3, 580);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(880, 211);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các bản sách khả dụng";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridViewCopies
            // 
            dataGridViewCopies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCopies.Location = new Point(-1, 26);
            dataGridViewCopies.Name = "dataGridViewCopies";
            dataGridViewCopies.ReadOnly = true;
            dataGridViewCopies.RowHeadersWidth = 51;
            dataGridViewCopies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCopies.Size = new Size(883, 173);
            dataGridViewCopies.TabIndex = 10;
            dataGridViewCopies.CellContentClick += dataGridView4_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 159);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 8;
            label8.Text = "Từ khóa:";
            // 
            // searchBookBT
            // 
            searchBookBT.Location = new Point(762, 155);
            searchBookBT.Name = "searchBookBT";
            searchBookBT.Size = new Size(94, 29);
            searchBookBT.TabIndex = 7;
            searchBookBT.Text = "Tìm kiếm";
            searchBookBT.UseVisualStyleBackColor = true;
            searchBookBT.Click += searchBookBT_Click;
            // 
            // searchNameTB
            // 
            searchNameTB.Location = new Point(110, 156);
            searchNameTB.Name = "searchNameTB";
            searchNameTB.Size = new Size(616, 27);
            searchNameTB.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addAuthorBT);
            groupBox1.Controls.Add(deleteAuthorBT);
            groupBox1.Controls.Add(dataGridViewAuthor);
            groupBox1.Controls.Add(authorTB);
            groupBox1.Controls.Add(updateAuthorBT);
            groupBox1.Location = new Point(901, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 255);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tác giả";
            // 
            // addAuthorBT
            // 
            addAuthorBT.Location = new Point(301, 36);
            addAuthorBT.Name = "addAuthorBT";
            addAuthorBT.Size = new Size(94, 29);
            addAuthorBT.TabIndex = 0;
            addAuthorBT.Text = "Thêm";
            addAuthorBT.UseVisualStyleBackColor = true;
            addAuthorBT.Click += addAuthorBT_Click;
            // 
            // deleteAuthorBT
            // 
            deleteAuthorBT.Location = new Point(301, 196);
            deleteAuthorBT.Name = "deleteAuthorBT";
            deleteAuthorBT.Size = new Size(94, 29);
            deleteAuthorBT.TabIndex = 1;
            deleteAuthorBT.Text = "Xóa ";
            deleteAuthorBT.UseVisualStyleBackColor = true;
            deleteAuthorBT.Click += deleteAuthorBT_Click;
            // 
            // dataGridViewAuthor
            // 
            dataGridViewAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthor.Location = new Point(0, 92);
            dataGridViewAuthor.Name = "dataGridViewAuthor";
            dataGridViewAuthor.ReadOnly = true;
            dataGridViewAuthor.RowHeadersWidth = 51;
            dataGridViewAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAuthor.Size = new Size(282, 133);
            dataGridViewAuthor.TabIndex = 2;
            dataGridViewAuthor.CellClick += dataGridViewAuthor_CellClick;
            dataGridViewAuthor.CellContentClick += dataGridView2_CellContentClick;
            // 
            // authorTB
            // 
            authorTB.Location = new Point(0, 38);
            authorTB.Name = "authorTB";
            authorTB.Size = new Size(276, 27);
            authorTB.TabIndex = 3;
            // 
            // updateAuthorBT
            // 
            updateAuthorBT.Location = new Point(301, 115);
            updateAuthorBT.Name = "updateAuthorBT";
            updateAuthorBT.Size = new Size(94, 29);
            updateAuthorBT.TabIndex = 1;
            updateAuthorBT.Text = "Sửa";
            updateAuthorBT.UseVisualStyleBackColor = true;
            updateAuthorBT.Click += updateAuthorBT_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Location = new Point(1321, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(405, 255);
            panel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteCategoryBT);
            groupBox2.Controls.Add(updateCategoryBT);
            groupBox2.Controls.Add(addCategoryBT);
            groupBox2.Controls.Add(categoryTB);
            groupBox2.Controls.Add(dataGridViewCategory);
            groupBox2.Location = new Point(3, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(426, 255);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thể loại";
            // 
            // deleteCategoryBT
            // 
            deleteCategoryBT.Location = new Point(299, 196);
            deleteCategoryBT.Name = "deleteCategoryBT";
            deleteCategoryBT.Size = new Size(94, 29);
            deleteCategoryBT.TabIndex = 1;
            deleteCategoryBT.Text = "Xóa ";
            deleteCategoryBT.UseVisualStyleBackColor = true;
            deleteCategoryBT.Click += deleteCategoryBT_Click;
            // 
            // updateCategoryBT
            // 
            updateCategoryBT.Location = new Point(299, 115);
            updateCategoryBT.Name = "updateCategoryBT";
            updateCategoryBT.Size = new Size(94, 29);
            updateCategoryBT.TabIndex = 1;
            updateCategoryBT.Text = "Sửa";
            updateCategoryBT.UseVisualStyleBackColor = true;
            updateCategoryBT.Click += updateCategoryBT_Click;
            // 
            // addCategoryBT
            // 
            addCategoryBT.Location = new Point(299, 35);
            addCategoryBT.Name = "addCategoryBT";
            addCategoryBT.Size = new Size(94, 29);
            addCategoryBT.TabIndex = 0;
            addCategoryBT.Text = "Thêm";
            addCategoryBT.UseVisualStyleBackColor = true;
            addCategoryBT.Click += addCategoryBT_Click;
            // 
            // categoryTB
            // 
            categoryTB.Location = new Point(-3, 36);
            categoryTB.Name = "categoryTB";
            categoryTB.Size = new Size(277, 27);
            categoryTB.TabIndex = 4;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.Location = new Point(0, 92);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.ReadOnly = true;
            dataGridViewCategory.RowHeadersWidth = 51;
            dataGridViewCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategory.Size = new Size(274, 133);
            dataGridViewCategory.TabIndex = 2;
            dataGridViewCategory.CellClick += dataGridViewCategory_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Location = new Point(901, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 689);
            panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(quantityNumberic);
            groupBox4.Controls.Add(quantityLabel);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(descriptionBookAddTB);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(nameAddBookTB);
            groupBox4.Controls.Add(categoryAddBookCB);
            groupBox4.Controls.Add(authorAddBookCB);
            groupBox4.Location = new Point(3, 248);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(849, 500);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sách";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(497, 402);
            label19.Name = "label19";
            label19.Size = new Size(111, 20);
            label19.TabIndex = 11;
            label19.Text = "Thêm số lượng:";
            // 
            // quantityNumberic
            // 
            quantityNumberic.Location = new Point(631, 400);
            quantityNumberic.Name = "quantityNumberic";
            quantityNumberic.Size = new Size(150, 27);
            quantityNumberic.TabIndex = 10;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(131, 402);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(17, 20);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(42, 402);
            label18.Name = "label18";
            label18.Size = new Size(76, 20);
            label18.TabIndex = 9;
            label18.Text = "Số lượng: ";
            // 
            // descriptionBookAddTB
            // 
            descriptionBookAddTB.Location = new Point(126, 160);
            descriptionBookAddTB.Name = "descriptionBookAddTB";
            descriptionBookAddTB.Size = new Size(658, 215);
            descriptionBookAddTB.TabIndex = 8;
            descriptionBookAddTB.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 163);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 5;
            label5.Text = "Mô tả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(420, 106);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 7;
            label7.Text = "Tác giả: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 106);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 6;
            label6.Text = "Thể loại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 45);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên sách:";
            // 
            // nameAddBookTB
            // 
            nameAddBookTB.Location = new Point(126, 42);
            nameAddBookTB.Name = "nameAddBookTB";
            nameAddBookTB.Size = new Size(658, 27);
            nameAddBookTB.TabIndex = 3;
            // 
            // categoryAddBookCB
            // 
            categoryAddBookCB.FormattingEnabled = true;
            categoryAddBookCB.Location = new Point(126, 101);
            categoryAddBookCB.Name = "categoryAddBookCB";
            categoryAddBookCB.Size = new Size(263, 28);
            categoryAddBookCB.TabIndex = 1;
            categoryAddBookCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // authorAddBookCB
            // 
            authorAddBookCB.FormattingEnabled = true;
            authorAddBookCB.Location = new Point(497, 101);
            authorAddBookCB.Name = "authorAddBookCB";
            authorAddBookCB.Size = new Size(287, 28);
            authorAddBookCB.TabIndex = 1;
            authorAddBookCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 32F);
            label3.Location = new Point(692, 0);
            label3.Name = "label3";
            label3.Size = new Size(399, 72);
            label3.TabIndex = 5;
            label3.Text = "QUẢN LÝ SÁCH";
            label3.Click += label3_Click;
            // 
            // searchAuthorCB
            // 
            searchAuthorCB.FormattingEnabled = true;
            searchAuthorCB.Location = new Point(460, 104);
            searchAuthorCB.Name = "searchAuthorCB";
            searchAuthorCB.Size = new Size(266, 28);
            searchAuthorCB.TabIndex = 4;
            searchAuthorCB.SelectedIndexChanged += authorDropDownSearch_SelectedIndexChanged;
            searchAuthorCB.SelectedValueChanged += AuthorDropDownSearch_SelectedValueChanged;
            // 
            // label2
            // 
            label2.Location = new Point(374, 107);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "Tác giả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 104);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Thể loại:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(1310, 498);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(194, 28);
            comboBox4.TabIndex = 1;
            comboBox4.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // searchCategoryCB
            // 
            searchCategoryCB.FormattingEnabled = true;
            searchCategoryCB.Location = new Point(110, 101);
            searchCategoryCB.Name = "searchCategoryCB";
            searchCategoryCB.Size = new Size(241, 28);
            searchCategoryCB.TabIndex = 1;
            searchCategoryCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Location = new Point(0, 233);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowHeadersWidth = 51;
            dataGridViewBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBook.Size = new Size(883, 308);
            dataGridViewBook.TabIndex = 0;
            dataGridViewBook.CellClick += dataGridViewBook_CellClick;
            dataGridViewBook.CellContentClick += dataGridView1_CellContentClick;
            // 
            // memberPanel
            // 
            memberPanel.Controls.Add(showAllMemsBT);
            memberPanel.Controls.Add(groupBox5);
            memberPanel.Controls.Add(searchMemberTB);
            memberPanel.Controls.Add(searchMembersBT);
            memberPanel.Controls.Add(panel3);
            memberPanel.Controls.Add(dataGridViewMember);
            memberPanel.Controls.Add(label9);
            memberPanel.Location = new Point(69, 59);
            memberPanel.Name = "memberPanel";
            memberPanel.Size = new Size(1780, 884);
            memberPanel.TabIndex = 14;
            memberPanel.Visible = false;
            memberPanel.VisibleChanged += memberPanel_VisibleChanged;
            memberPanel.Paint += memberPanel_Paint;
            // 
            // showAllMemsBT
            // 
            showAllMemsBT.Location = new Point(758, 816);
            showAllMemsBT.Name = "showAllMemsBT";
            showAllMemsBT.Size = new Size(94, 29);
            showAllMemsBT.TabIndex = 8;
            showAllMemsBT.Text = "Hiện tất cả";
            showAllMemsBT.UseVisualStyleBackColor = true;
            showAllMemsBT.Click += showAllMemsBT_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(statusBorrowLabel);
            groupBox5.Controls.Add(detailReturnDateTB);
            groupBox5.Controls.Add(detailCopiesIdTB);
            groupBox5.Controls.Add(detailBookIdTB);
            groupBox5.Controls.Add(detailBookNameTB);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(returnBT);
            groupBox5.Location = new Point(912, 444);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(865, 401);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chi tiết mượn:";
            // 
            // statusBorrowLabel
            // 
            statusBorrowLabel.AutoSize = true;
            statusBorrowLabel.BackColor = SystemColors.Control;
            statusBorrowLabel.ForeColor = Color.Blue;
            statusBorrowLabel.Location = new Point(150, 280);
            statusBorrowLabel.Name = "statusBorrowLabel";
            statusBorrowLabel.Size = new Size(119, 20);
            statusBorrowLabel.TabIndex = 3;
            statusBorrowLabel.Text = "Chưa mượn sách";
            // 
            // detailReturnDateTB
            // 
            detailReturnDateTB.Location = new Point(150, 216);
            detailReturnDateTB.Name = "detailReturnDateTB";
            detailReturnDateTB.ReadOnly = true;
            detailReturnDateTB.Size = new Size(623, 27);
            detailReturnDateTB.TabIndex = 2;
            // 
            // detailCopiesIdTB
            // 
            detailCopiesIdTB.Location = new Point(152, 159);
            detailCopiesIdTB.Name = "detailCopiesIdTB";
            detailCopiesIdTB.ReadOnly = true;
            detailCopiesIdTB.Size = new Size(623, 27);
            detailCopiesIdTB.TabIndex = 2;
            // 
            // detailBookIdTB
            // 
            detailBookIdTB.Location = new Point(153, 105);
            detailBookIdTB.Name = "detailBookIdTB";
            detailBookIdTB.ReadOnly = true;
            detailBookIdTB.Size = new Size(623, 27);
            detailBookIdTB.TabIndex = 2;
            // 
            // detailBookNameTB
            // 
            detailBookNameTB.Location = new Point(153, 54);
            detailBookNameTB.Name = "detailBookNameTB";
            detailBookNameTB.ReadOnly = true;
            detailBookNameTB.Size = new Size(623, 27);
            detailBookNameTB.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(29, 280);
            label17.Name = "label17";
            label17.Size = new Size(78, 20);
            label17.TabIndex = 1;
            label17.Text = "Trạng thái:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(29, 219);
            label16.Name = "label16";
            label16.Size = new Size(102, 20);
            label16.TabIndex = 1;
            label16.Text = "Ngày trả sách:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(31, 162);
            label15.Name = "label15";
            label15.Size = new Size(105, 20);
            label15.TabIndex = 1;
            label15.Text = "Mã bản mượn:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 108);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 1;
            label14.Text = "Mã sách:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 57);
            label13.Name = "label13";
            label13.Size = new Size(68, 20);
            label13.TabIndex = 1;
            label13.Text = "Tên sách:";
            // 
            // returnBT
            // 
            returnBT.Location = new Point(679, 276);
            returnBT.Name = "returnBT";
            returnBT.Size = new Size(94, 29);
            returnBT.TabIndex = 0;
            returnBT.Text = "Trả sách";
            returnBT.UseVisualStyleBackColor = true;
            returnBT.Click += button14_Click;
            // 
            // searchMemberTB
            // 
            searchMemberTB.Location = new Point(48, 217);
            searchMemberTB.Name = "searchMemberTB";
            searchMemberTB.Size = new Size(667, 27);
            searchMemberTB.TabIndex = 4;
            searchMemberTB.TextChanged += searchMemberTB_TextChanged;
            // 
            // searchMembersBT
            // 
            searchMembersBT.Location = new Point(758, 217);
            searchMembersBT.Name = "searchMembersBT";
            searchMembersBT.Size = new Size(94, 29);
            searchMembersBT.TabIndex = 3;
            searchMembersBT.Text = "Tìm kiếm";
            searchMembersBT.UseVisualStyleBackColor = true;
            searchMembersBT.Click += searchMembersBT_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button13);
            panel3.Controls.Add(button15);
            panel3.Controls.Add(memberEmailTB);
            panel3.Controls.Add(memberAddressTB);
            panel3.Controls.Add(memberPhoneNoTB);
            panel3.Controls.Add(memberNameTB);
            panel3.Controls.Add(memberCCCDTB);
            panel3.Controls.Add(S);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(912, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(868, 266);
            panel3.TabIndex = 2;
            // 
            // button13
            // 
            button13.Location = new Point(717, 147);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 5;
            button13.Text = "Xóa";
            button13.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(717, 81);
            button15.Name = "button15";
            button15.Size = new Size(94, 29);
            button15.TabIndex = 5;
            button15.Text = "Sửa";
            button15.UseVisualStyleBackColor = true;
            // 
            // memberEmailTB
            // 
            memberEmailTB.Location = new Point(153, 213);
            memberEmailTB.Name = "memberEmailTB";
            memberEmailTB.Size = new Size(487, 27);
            memberEmailTB.TabIndex = 2;
            // 
            // memberAddressTB
            // 
            memberAddressTB.Location = new Point(153, 162);
            memberAddressTB.Name = "memberAddressTB";
            memberAddressTB.Size = new Size(487, 27);
            memberAddressTB.TabIndex = 2;
            // 
            // memberPhoneNoTB
            // 
            memberPhoneNoTB.Location = new Point(153, 113);
            memberPhoneNoTB.Name = "memberPhoneNoTB";
            memberPhoneNoTB.Size = new Size(487, 27);
            memberPhoneNoTB.TabIndex = 2;
            // 
            // memberNameTB
            // 
            memberNameTB.Location = new Point(154, 10);
            memberNameTB.Name = "memberNameTB";
            memberNameTB.ReadOnly = true;
            memberNameTB.Size = new Size(487, 27);
            memberNameTB.TabIndex = 1;
            // 
            // memberCCCDTB
            // 
            memberCCCDTB.Location = new Point(153, 59);
            memberCCCDTB.Name = "memberCCCDTB";
            memberCCCDTB.ReadOnly = true;
            memberCCCDTB.Size = new Size(487, 27);
            memberCCCDTB.TabIndex = 1;
            // 
            // S
            // 
            S.AutoSize = true;
            S.Location = new Point(34, 216);
            S.Name = "S";
            S.Size = new Size(49, 20);
            S.TabIndex = 0;
            S.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 166);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 0;
            label12.Text = "Địa chỉ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 116);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 0;
            label11.Text = "Số điện thoại:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(35, 13);
            label20.Name = "label20";
            label20.Size = new Size(35, 20);
            label20.TabIndex = 0;
            label20.Text = "Tên:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 62);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 0;
            label10.Text = "CCCD:";
            // 
            // dataGridViewMember
            // 
            dataGridViewMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMember.Location = new Point(48, 286);
            dataGridViewMember.Name = "dataGridViewMember";
            dataGridViewMember.RowHeadersWidth = 51;
            dataGridViewMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMember.Size = new Size(804, 509);
            dataGridViewMember.TabIndex = 1;
            dataGridViewMember.CellClick += dataGridViewMember_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 32F);
            label9.Location = new Point(809, 16);
            label9.Name = "label9";
            label9.Size = new Size(263, 72);
            label9.TabIndex = 0;
            label9.Text = "BẠN ĐỌC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1897, 970);
            Controls.Add(menuStrip1);
            Controls.Add(memberPanel);
            Controls.Add(bookPanel);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thư viện";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            bookPanel.ResumeLayout(false);
            bookPanel.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCopies).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).EndInit();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumberic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            memberPanel.ResumeLayout(false);
            memberPanel.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

     
        private void AuthorDropDownSearch_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hànhĐộngToolStripMenuItem;
        private ToolStripMenuItem đổiThôngTinToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private Panel bookPanel;
        private DataGridView dataGridViewBook;
        private ComboBox searchCategoryCB;
        private Label label1;
        private ComboBox searchAuthorCB;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripMenuItem tácGiảToolStripMenuItem;
        private Button deleteBookBT;
        private Button addBookBT;
        private TextBox nameAddBookTB;
        private Label label4;
        private Button updateBookBT;
        private Label label5;
        private Label label7;
        private Label label6;
        private ComboBox authorAddBookCB;
        private ComboBox categoryAddBookCB;
        private ComboBox comboBox4;
        private Button borrowBT;
        private Panel panel4;
        private Button addAuthorBT;
        private Button updateAuthorBT;
        private Button deleteAuthorBT;
        private Button addCategoryBT;
        private Button updateCategoryBT;
        private Button deleteCategoryBT;
        private DataGridView dataGridViewCategory;
        private DataGridView dataGridViewAuthor;
        private TextBox authorTB;
        private TextBox categoryTB;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Button searchBookBT;
        private TextBox searchNameTB;
        private GroupBox groupBox3;
        private DataGridView dataGridViewCopies;
        private GroupBox groupBox4;
        private ToolStripMenuItem bạnĐọcMớiToolStripMenuItem;
        private ToolStripMenuItem đăngKíMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Button deleteCopyBT;
        private Panel memberPanel;
        private GroupBox groupBox5;
        private TextBox detailReturnDateTB;
        private TextBox detailCopiesIdTB;
        private TextBox detailBookIdTB;
        private TextBox detailBookNameTB;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button returnBT;
        private TextBox searchMemberTB;
        private Button searchMembersBT;
        private Panel panel3;
        private Button button13;
        private Button button15;
        private TextBox memberEmailTB;
        private TextBox memberAddressTB;
        private TextBox memberPhoneNoTB;
        private TextBox memberCCCDTB;
        private Label S;
        private Label label12;
        private Label label11;
        private Label label10;
        private DataGridView dataGridViewMember;
        private Label label9;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private RichTextBox descriptionBookAddTB;
        private Label label18;
        private Label quantityLabel;
        private Label label19;
        private NumericUpDown quantityNumberic;
        private Button showAllBT;
        private TextBox memberNameTB;
        private Label label20;
        private Label label21;
        private Label statusBorrowLabel;
        private ToolStripMenuItem tìmBạnĐọcToolStripMenuItem;
        private Button showAllMemsBT;
    }
}
