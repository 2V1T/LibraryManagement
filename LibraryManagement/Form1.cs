﻿using LibraryManagement.controllers;
using LibraryManagement.GUIs;
using LibraryManagement.models;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        static Login loginForm = new Login();
        public int id;
        public bool isLogout;

        public Form1 () { }
        public Form1(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            addComboboxCategory(searchCategoryCB);
            addComboboxAuthor(searchAuthorCB);
            addBookToView(dataGridViewBook);
            addComboboxAuthor(authorAddBookCB);
            addComboboxCategory(categoryAddBookCB);
            addCategoryToTable(dataGridViewCategory);
            addAuthorToTable(dataGridViewAuthor);
            addMemberToView(dataGridViewMember);
            dataGridViewCategory.Columns[0].Width = 50;
            dataGridViewAuthor.Columns[1].Width = dataGridViewAuthor.Width - 130;
            dataGridViewAuthor.Columns[0].Width = 50;
            dataGridViewCategory.Columns[1].Width = dataGridViewCategory.Width - 130;
            bookPanel.Visible = true;
            int maxWidthDGWBook = dataGridViewBook.Width;
            dataGridViewBook.Columns[0].Width = 50;
            for (int i = 1; i <= 5; i++)
            {
                dataGridViewBook.Columns[i].Width = (maxWidthDGWBook - 130) / 5;
            }
            returnBT.Enabled = false;
        }


        private void addAvailibleBook(DataGridView dataGridView, int bookId)
        {
            CopiedBookController copiesController = new CopiedBookController();
            DataTable data = copiesController.getByBookId(bookId);
            dataGridView.DataSource = data;
            int maxWidthCopies = dataGridView.Width;
            for (int i = 0; i < 3; i++)
            {
                dataGridView.Columns[i].Width = (maxWidthCopies - 80) / 3;
            }
        }

        private void reloadCategory()
        {
            addComboboxCategory(searchCategoryCB);
            addComboboxCategory(categoryAddBookCB);
            addAuthorToTable(dataGridViewAuthor);
        }


        private void reloadAuthor()
        {
            addComboboxAuthor(searchAuthorCB);
            addComboboxAuthor(categoryAddBookCB);
            addCategoryToTable(dataGridViewCategory);

        }

        private void reloadBook()
        {
            addBookToView(dataGridViewBook);

        }

        private void addMemberToView(DataGridView dataGridView)
        {
            MemberController memberController = new MemberController();
            DataTable data = memberController.getAll();
            dataGridView.DataSource = data;
        }

        private void reloadMember()
        {
            addMemberToView(dataGridViewMember);
        }
        private void addComboboxCategory(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            CategoryController controller = new CategoryController();
            DataTable dt = controller.getAll();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox.Items.Add(new KeyValuePair<string, int>(dr["name"].ToString(), int.Parse(dr["id"].ToString())));
                comboBox.DisplayMember = "Key";
                comboBox.Text = "-- Chọn thể loại --";
                comboBox.ValueMember = "Value";
            }
        }

        private void addComboboxAuthor(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            AuthorController controller = new AuthorController();
            DataTable dt = controller.getAll();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox.Items.Add(new KeyValuePair<string, int>(dr["name"].ToString(), int.Parse(dr["id"].ToString())));
                comboBox.DisplayMember = "Key";
                comboBox.Text = "-- Chọn tác giả --";
                comboBox.ValueMember = "Value";
            }
        }

        private void addBookToView(DataGridView dataGridView)
        {
            BookController controller = new BookController();
            DataTable book = controller.getAll();
            dataGridView.DataSource = book;
        }


        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hànhĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookPanel.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = searchCategoryCB.Text;
            object selectedValue = searchCategoryCB.SelectedItem;
            if (selectedValue is KeyValuePair<string, int> pair)
            {
                string key = pair.Key;
                int value = pair.Value;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sáchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bookPanel.Visible = true;
            memberPanel.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bạnĐọcMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberPanel.Visible = true;
            bookPanel.Visible = false;

        }

        private void đổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(this.id);
            infoForm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.OK:
                    this.isLogout = false;
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.OK:
                    this.isLogout = true;   
                    this.Close();
                    loginForm.ShowDialog();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookController bookController = new BookController();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBook.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                addAvailibleBook(dataGridViewCopies, id);
                Book book = bookController.getById(id);
                nameAddBookTB.Text = book.Name;
                descriptionBookAddTB.Text = book.Description;
                quantityLabel.Text = bookController.getQuantity(id).ToString();
                foreach (var item in authorAddBookCB.Items)
                {
                    if (item is KeyValuePair<string, int> pair)
                    {
                        string key = pair.Key;
                        int value = pair.Value;
                        if (value == book.AuthorId)
                        {
                            authorAddBookCB.SelectedItem = item;
                        }
                    }
                }
                foreach (var item in categoryAddBookCB.Items)
                {
                    if (item is KeyValuePair<string, int> pair)
                    {
                        string key = pair.Key;
                        int value = pair.Value;
                        if (value == book.CategoryId)
                        {
                            categoryAddBookCB.SelectedItem = item;
                        }
                    }
                }
            }
        }

        private void authorDropDownSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = searchAuthorCB.Text;
            object selectedValue = searchAuthorCB.SelectedItem;
            if (selectedValue is KeyValuePair<string, int> pair)
            {
                string key = pair.Key;
                int value = pair.Value;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchMembersBT_Click(object sender, EventArgs e)
        {
            MemberController memberController = new MemberController();
            string name = searchMemberTB.Text;
            if (name == null || name.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên bạn đọc!", "Thông báo");
            }
            else
            {
                DataTable dt = memberController.getByKeyword(name);
                dataGridViewMember.DataSource = dt;
            }
        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewMember.CurrentRow;
            string cellValue = currentRow.Cells["ID No"].Value.ToString();
            MessageBox.Show(cellValue);
        }

        private void đăngKíMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRReader qR = new QRReader(false, 0);
            qR.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bookId = 0;

            if (dataGridViewCopies.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCopies.SelectedRows[0];
                bookId = Convert.ToInt32(selectedRow.Cells["id"].Value);
            }
            if (bookId != 0)
            {
                QRReader qR = new QRReader(true, bookId);
                qR.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cho mượn!", "Thông báo");
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(this.id);
            changePassword.ShowDialog();
            if (changePassword.isExit == true)
            {
                this.isLogout = true;
                this.Close();
                loginForm.ShowDialog();
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void addCategoryToTable(DataGridView dataGridView)
        {
            CategoryController categoryController = new CategoryController();
            DataTable dt = categoryController.getAll();
            dataGridView.DataSource = dt;
        }

        private void addAuthorToTable(DataGridView dataGridView)
        {
            AuthorController authorController = new AuthorController();
            DataTable dt = authorController.getAll();
            dataGridView.DataSource = dt;
        }
        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookController bookController = new BookController();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBook.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                addAvailibleBook(dataGridViewCopies, id);
                Book book = bookController.getById(id);
                nameAddBookTB.Text = book.Name;
                descriptionBookAddTB.Text = book.Description;
                quantityLabel.Text = bookController.getQuantity(id).ToString();
                foreach (var item in authorAddBookCB.Items)
                {
                    if (item is KeyValuePair<string, int> pair)
                    {
                        string key = pair.Key;
                        int value = pair.Value;
                        if (value == book.AuthorId)
                        {
                            authorAddBookCB.SelectedItem = item;
                        }
                    }
                }
                foreach (var item in categoryAddBookCB.Items)
                {
                    if (item is KeyValuePair<string, int> pair)
                    {
                        string key = pair.Key;
                        int value = pair.Value;
                        if (value == book.CategoryId)
                        {
                            categoryAddBookCB.SelectedItem = item;
                        }
                    }
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogout)
            {
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }


        private void addAuthorBT_Click(object sender, EventArgs e)
        {
            string name = authorTB.Text;
            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Thông báo");
            }
            else
            {
                AuthorController authorController = new AuthorController();
                bool result = authorController.add(new Author(1, name));
                if (result)
                {
                    MessageBox.Show("Thêm tác giả thành công!", "Thông tin");
                    reloadAuthor();
                    authorTB.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm tác giả thất bại!", "Thông tin");
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void updateAuthorBT_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthor.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAuthor.SelectedRows[0];
                int authorID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string authorName = authorTB.Text;
                AuthorController authorController = new AuthorController();
                bool result = authorController.update(new Author(authorID, authorName));
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin tác giả thành công!", "Thông báo");
                    reloadAuthor();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin tác giả thất bại!", "Thông báo");
                }
            }
        }

        private void dataGridViewAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewAuthor.CurrentRow;
            string name = currentRow.Cells["name"].Value.ToString();
            authorTB.Text = name;
        }

        private void deleteAuthorBT_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthor.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAuthor.SelectedRows[0];
                int authorID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                AuthorController authorController = new AuthorController();
                DialogResult resultDialog = MessageBox.Show("Nếu xóa tác giả sẽ xóa các sách thuộc tác giả này. Bạn có muốn tiếp tục hành động này?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (resultDialog)
                {
                    case DialogResult.Yes:
                        bool result = authorController.delete(authorID);
                        if (result)
                        {
                            authorTB.Text = "";
                            MessageBox.Show("Xóa tác giả thành công!", "Thông báo");
                            reloadAuthor();
                        }
                        else
                        {
                            MessageBox.Show("Xóa tác giả thất bại!", "Thông báo");
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewCategory.CurrentRow;
            string name = currentRow.Cells["name"].Value.ToString();
            categoryTB.Text = name;
        }

        private void addCategoryBT_Click(object sender, EventArgs e)
        {
            string name = categoryTB.Text;
            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!", "Thông báo");
            }
            else
            {
                CategoryController categoryController = new CategoryController();
                bool result = categoryController.add(new Category(1, name));
                if (result)
                {
                    MessageBox.Show("Thêm thể loại thành công!", "Thông báo");
                    reloadCategory();
                    categoryTB.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thể loại thất bại!", "Thông báo");
                }
            }
        }

        private void updateCategoryBT_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCategory.SelectedRows[0];
                int categoryID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string categoryName = categoryTB.Text;
                CategoryController categoryController = new CategoryController();
                bool result = categoryController.update(new Category(categoryID, categoryName));
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin thể loại thành công!", "Thông báo");
                    reloadAuthor();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thể loại thất bại!", "Thông báo");
                }
            }
        }

        private void deleteCategoryBT_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCategory.SelectedRows[0];
                int categoryID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                CategoryController categoryController = new CategoryController();
                DialogResult resultDialog = MessageBox.Show("Nếu xóa thể loại sẽ xóa các sách thuộc thể loại này. Bạn có muốn tiếp tục hành động này?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (resultDialog)
                {
                    case DialogResult.Yes:
                        bool result = categoryController.delete(categoryID);
                        if (result)
                        {
                            categoryTB.Text = "";
                            MessageBox.Show("Xóa thể loại thành công!", "Thông báo");
                            reloadCategory();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thể loại thất bại!", "Thông báo");
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void searchBookBT_Click(object sender, EventArgs e)
        {
            object selectedValueAuthor = searchAuthorCB.SelectedItem;
            int idAuthor = 0;
            int idCategory = 0;
            if (selectedValueAuthor is KeyValuePair<string, int> pairAuthor)
            {
                idAuthor = pairAuthor.Value;
            }

            object selectedValueCategory = searchCategoryCB.SelectedItem;
            if (selectedValueCategory is KeyValuePair<string, int> pairCategory)
            {
                idCategory = pairCategory.Value;
            }
            BookController bookController = new BookController();
            DataTable dtAuthor = bookController.search(searchNameTB.Text, idCategory, idAuthor);
            dataGridViewBook.DataSource = dtAuthor;
        }
        private void clearAddBook()
        {
            descriptionBookAddTB.Text = "";
            nameAddBookTB.Text = "";
            categoryAddBookCB.Text = "";
            authorAddBookCB.Text = "";
            quantityNumberic.Value = 0;
        }

        private void updateBookBT_Click(object sender, EventArgs e)
        {
            int idBook = 0;
            if (dataGridViewBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBook.SelectedRows[0];
                idBook = Convert.ToInt32(selectedRow.Cells["id"].Value);
            }
            BookController bookController = new BookController();
            object selectedValueAuthor = authorAddBookCB.SelectedItem;
            int idAuthor = 0;
            int idCategory = 0;
            if (selectedValueAuthor is KeyValuePair<string, int> pairAuthor)
            {
                idAuthor = pairAuthor.Value;
            }

            object selectedValueCategory = categoryAddBookCB.SelectedItem;
            if (selectedValueCategory is KeyValuePair<string, int> pairCategory)
            {
                idCategory = pairCategory.Value;
            }
            string name = nameAddBookTB.Text;
            string description = descriptionBookAddTB.Text;
            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo");
                return;
            }
            if (idCategory == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Thông báo");
                return;
            }
            if (idAuthor == 0)
            {
                MessageBox.Show("Vui lòng chọn tác giả!", "Thông báo");
                return;
            }
            if (description == "")
            {
                MessageBox.Show("Vui lòng điền mô tả cho sách!", "Thông báo");
            }
            int quantity = (int)quantityNumberic.Value;
            CopiedBookController copiedBookController = new CopiedBookController();
            if (quantity != 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    bool success = copiedBookController.add(idBook);
                    if (success)
                    {
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("Thêm số lượng thất bại!", "Thông báo");
                        break;
                    }
                }
            }
            Book book = new Book();
            book.Name = name;
            book.Description = description;
            book.CategoryId = idCategory;
            book.AuthorId = idAuthor;
            book.Id = idBook;
            bool result = bookController.update(book);
            if (result)
            {
                clearAddBook();
                reloadBook();
                MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sách thất bại!", "Thông báo");
                return;
            }
        }

        private void showAllBT_Click(object sender, EventArgs e)
        {
            reloadBook();
        }

        private void memberPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addInforMember(Member member)
        {
            memberNameTB.Text = member.Name;
            memberAddressTB.Text = member.Address;
            memberCCCDTB.Text = '0' + member.IdNo.ToString();
            memberEmailTB.Text = member.Email;
            memberPhoneNoTB.Text = '0' + member.PhoneNo.ToString();

            BorrowedDetailController borrowedDetailController = new BorrowedDetailController();
            DataRow data = borrowedDetailController.getByIdNo(member.IdNo);
            if (data != null)
            {
                returnBT.Enabled = true;
                detailBookIdTB.Text = data["book_id"].ToString();
                detailBookNameTB.Text = data["name"].ToString();
                detailCopiesIdTB.Text = data["id"].ToString();
                detailReturnDateTB.Text = ((DateTime)data["return_date"]).ToString("dd-MM-yyyy");
                DateTime returnDate = ((DateTime)data["return_date"]);
                DateTime currentDate = DateTime.Now;
                if (returnDate >= currentDate)
                {
                    statusBorrowLabel.Text = "Còn hạn trả";
                    statusBorrowLabel.ForeColor = Color.Green;
                }
                else
                {
                    statusBorrowLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                detailBookIdTB.Text = "";
                detailBookNameTB.Text = "";
                detailReturnDateTB.Text = "";
                detailCopiesIdTB.Text = "";
                statusBorrowLabel.Text = "Chưa mượn sách";
                statusBorrowLabel.ForeColor = Color.Blue;
            }
        }
        private void dataGridViewMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idMember = 0;
            if (dataGridViewMember.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMember.SelectedRows[0];
                idMember = Convert.ToInt32(selectedRow.Cells["id"].Value);
                MemberController memberController = new MemberController();
                Member member = memberController.getById(idMember);
                addInforMember(member);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            QRReader qRReader = new QRReader(true, 1, true, false);
            qRReader.ShowDialog();
        }

        private void tìmBạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRReader qRReader = new QRReader(false, 1, false, true);
            qRReader.ShowDialog();
            long idNo = 0;
            idNo = qRReader.resultIdNo;
            if (idNo != 0)
            {
                memberPanel.Visible = true;
                bookPanel.Visible = false;
                foreach (DataGridViewRow row in dataGridViewMember.Rows)
                {
                    if (row.Cells["id_no"].Value != null)
                    {
                        long parsedIdNo;
                        if (long.TryParse(row.Cells["id_no"].Value.ToString(), out parsedIdNo))
                        {
                            if (idNo == parsedIdNo)
                            {
                                dataGridViewMember.Rows[0].Selected = false;
                                dataGridViewMember.Rows[row.Index].Selected = true;
                                MemberController memberController = new MemberController();
                                Member member = memberController.getByIdNo(parsedIdNo);
                                addInforMember(member);
                            }
                        }
                    }
                }
            }
        }

        private void memberPanel_VisibleChanged(object sender, EventArgs e)
        {
            addMemberToView(dataGridViewMember);
        }

        private void searchMemberTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void showAllMemsBT_Click(object sender, EventArgs e)
        {
            addMemberToView(dataGridViewMember);
        }
    }
}
