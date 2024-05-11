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
    public partial class mainNV : Form
    {
        public mainNV()
        {
            InitializeComponent();
        }

        private void qUẢNLÍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            THÔNG_TIN_HỌC_VIÊN ac = new THÔNG_TIN_HỌC_VIÊN();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void bÁNHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thông_Tin_Khóa_Học ac = new Thông_Tin_Khóa_Học();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thông_Tin_Phòng_Họccs ac = new Thông_Tin_Phòng_Họccs();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void đẶTPHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thông_Tin_Giảng_Viên ac = new Thông_Tin_Giảng_Viên();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void tRẢPHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thông_Tin_Lớp_Học ac = new Thông_Tin_Lớp_Học();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Đăng_Kí_Học_Viên ac = new Đăng_Kí_Học_Viên();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xem_Giao_Dịch ac = new Xem_Giao_Dịch();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }
    }
}
