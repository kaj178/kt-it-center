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
    public partial class Thông_Tin_Giảng_Viên : Form
    {
        public Thông_Tin_Giảng_Viên()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Thông_Tin_Giảng_Viên_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.GiangViens
                        select new
                        {
                            Mã_Giảng_Viên = a.MaGiangVien,
                            Họ_Tên = a.HoTen,
                            Địa_Chỉ = a.DiaChi,
                            Số_CMND = a.DienThoai,
                            Email = a.Email,
                        };
            data_gv.DataSource = quyry.ToList();
            data_gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
