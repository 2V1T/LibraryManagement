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

    public partial class ChangePassword : Form
    {
        int id;
        public ChangePassword(int id)
        {
            this.id = id;
            InitializeComponent();
        }
    }
}
