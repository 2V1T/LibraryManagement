using LibraryManagement.controllers;
using LibraryManagement.GUIs;
using LibraryManagement.Models;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        static Login loginForm = new Login();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MemberController memberController = new MemberController();
            bookPanel.Visible = true;
            List<Member> memberList = new List<Member>();
            DataTable members = memberController.getAll();
            DataTable showView = new DataTable();
            showView.Columns.Add("ID No", typeof(long));  // Tên cột
            showView.Columns.Add("Name", typeof(string));  // Tên cột
            showView.Columns.Add("Address", typeof(string));
            showView.Columns.Add("Phone No", typeof(string)); // Tên cột
            showView.Columns.Add("Email", typeof(string));  // Tên cột
            foreach (DataRow row in members.Rows)
            {
                showView.Rows.Add((long)row["id_no"], (string)row["name"], (string)row["address"], '0' + (string)row["phone_no"].ToString(), (string)row["email"]);
            }
            dataGridViewMember.DataSource = showView;
            // Gán DataTable cho DataGridView
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
            InfoForm infoForm = new InfoForm();
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
            string selectedText = authorDropDownSearch.Text;
            Object selectedValue = authorDropDownSearch.SelectedItem;
            if (selectedValue is KeyValuePair<int, string> pair)
            {
                int key = pair.Key;
                string value = pair.Value;

                MessageBox.Show("Giá trị Key: " + key + ", Giá trị Value: " + value);
            }
            else
            {
                MessageBox.Show("Giá trị được chọn không phải là KeyValuePair");
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
    }
}
