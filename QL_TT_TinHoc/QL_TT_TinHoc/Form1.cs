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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dnhap_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var conn = data.NhanViens;
            var ass = data.ADMINs;

            try
            {

                var tk = txt_tk.Text;
                var mk = txt_mk.Text;
                var admin = ass.FirstOrDefault(a => a.tk == tk && a.mk == mk && a.IdRole == 1);

                var nv = conn.FirstOrDefault(a => a.tk == tk && a.mk == mk && a.IdRole == 2);

                if (admin != null)
                {


                    this.Hide();
                    mainAdmin ac = new mainAdmin();
                    ac.ShowDialog();
                    ac = null;
                    this.Show();


                }
                else if (nv != null)
                {
                    this.Hide();
                    mainNV ac = new mainNV();
                    ac.ShowDialog();
                    ac = null;
                    this.Show();
                }

                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dmkcs ac = new dmkcs();
            ac.ShowDialog();
            ac = null;
            this.Show();
        }
    }
}
