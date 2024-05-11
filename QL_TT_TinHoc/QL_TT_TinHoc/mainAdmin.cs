using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TT_TinHoc
{
    public partial class mainAdmin : Form
    {
        public mainAdmin()
        {
            InitializeComponent();
        }

        private void qUẢNLÍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quản_Lí_Nhân_Viên ac = new Quản_Lí_Nhân_Viên();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tk ac = new Tk();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }
    }
}
