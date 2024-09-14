using LibraryManagement.controllers;
using LibraryManagement.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.GUIs
{
    public partial class DeleteCopies : Form
    {
        CopiedBookController copiedBookController = new CopiedBookController();
        BookController bookController = new BookController();
        public int bookId;
        public bool isSuccess = false;
        public DeleteCopies(int bookId)
        {
            InitializeComponent();
            this.bookId = bookId;
        }

        private void loadData()
        {
            Book book = bookController.getById(bookId);
            bookNameTB.Text = book.Name;
            copiesCB.Items.Clear();
            DataTable copiesList = copiedBookController.getByBookId(bookId);
            foreach (DataRow copies in copiesList.Rows)
            {
                copiesCB.Items.Add(new KeyValuePair<string, int>("Bản sao có mã số " + copies["id"], int.Parse(copies["id"].ToString())));
                copiesCB.DisplayMember = "Key";
                copiesCB.ValueMember = "Value";
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (copiesCB.SelectedItem == null) {
                MessageBox.Show("Vui lòng chọn bản sao cần xóa!", "Thông báo");
            }
            else
            {
                object selectedValue = copiesCB.SelectedItem;
                int value = 0;
                if (selectedValue is KeyValuePair<string, int> pair)
                {
                    value = pair.Value;
                }
                if (value != 0) {
                    if (copiedBookController.delete(value)) {
                        MessageBox.Show("Xóa bản sao mã số " + value + " của sách " + bookNameTB.ToString() + " thành công!", "Thông báo");
                        isSuccess = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa bản sao mã số " + value + " của sách " + bookNameTB.ToString() + " thất bại!", "Thông báo");
                        this.Close();
                    }
                }
            }
        }

        private void DeleteCopies_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
