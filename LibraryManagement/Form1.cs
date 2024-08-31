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
            DataTable members = memberController.getAll();
            panel1.Visible = false;

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
            panel1.Visible = true;
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
            panel1.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
