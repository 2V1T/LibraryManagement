using LibraryManagement.controllers;
using LibraryManagement.Models;
using System.Data;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MemberController memberController = new MemberController();
            Member member = memberController.getById(1);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID No", typeof(long));  // Tên cột
            dataTable.Columns.Add("Name", typeof(string));  // Tên cột
            dataTable.Columns.Add("Phone No", typeof(long)); // Tên cột
            dataTable.Columns.Add("Email", typeof(string));  // Tên cột
                                                             // Thêm các cột khác nếu cần

            // Thêm dữ liệu vào DataTable
            dataTable.Rows.Add(member.IdNo, member.Name, member.PhoneNo, member.Email);
            // Thêm các giá trị khác vào hàng nếu cần

            // Gán DataTable cho DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
