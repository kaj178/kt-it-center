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
    public partial class dmkcs : Form
    {
        public dmkcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var conn = data.NhanViens;
            var admin = data.ADMINs;

            try
            {
                var tk = txt_tk.Text;
                var mk = txt_mk.Text;
                var nv = conn.FirstOrDefault(a => a.tk == tk && a.mk == mk && a.IdRole==2);

                if (nv != null)
                {
                    var pb1 = txt_mkm.Text;

                    if (string.IsNullOrEmpty(pb1))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                    }
                    else
                    {

                        if (nv != null)
                        {
                            nv.mk = pb1;
                            data.SubmitChanges();
                            MessageBox.Show("Đổi mật khẩu thành công!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Lỗi kết nối!");
            }
        }
    }
}
