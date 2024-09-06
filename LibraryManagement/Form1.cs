using LibraryManagement.controllers;
using LibraryManagement.GUIs;
using LibraryManagement.models;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        static Login loginForm = new Login();
        int id;
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
            dataGridViewCategory.Columns[0].Width = 50;
            dataGridViewAuthor.Columns[0].Width = 50;
            bookPanel.Visible = true;
        }


        private void addAvailibleBook(DataGridView dataGridView, int bookId)
        {
            CopiedBookController copiesController = new CopiedBookController();
            DataTable data = copiesController.getAvailable(bookId);
            dataGridView.DataSource = data;
        }
        private void addComboboxCategory(ComboBox comboBox)
        {
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
                    this.Close();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                Member member = memberController.getByName(name);
                if (member != null)
                {
                    List<Member> list = new List<Member>();
                    list.Add(member);
                    dataGridViewMember.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bạn đọc vui lòng thử lại!", "Thông báo");
                }
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
            QRReader qR = new QRReader(false);
            qR.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QRReader qR = new QRReader(true);
            qR.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(this.id);
            changePassword.ShowDialog();
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
                        if (value == book.AuthorId)
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
                    loadData();
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
                    loadData();
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
                            loadData();
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
                    loadData();
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
                    loadData();
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
                            loadData();
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
    }
}
