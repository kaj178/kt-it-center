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
    public partial class Xem_Giao_Dịch : Form
    {
        public Xem_Giao_Dịch()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Xem_Giao_Dịch_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.HocViens
                        join b in data.DKKhoaHocs on a.MaHocVien equals b.MaHocVien
                        join c in data.KhoaHocs on b.MaKhoaHoc equals c.MaKhoaHoc

                        select new
                        {
                            Mã_Học_Viên = a.MaHocVien,
                            Họ_Tên = a.HoTen,
                            Giới_Tính = a.GioiTinh,
                            Tuổi = a.Tuoi,
                            Địa_Chỉ = a.DiaChi,
                            SĐT = a.DienThoai,
                            Email = a.Email,
                            Ngày_Đăng_Kí = b.Ngaydk,
                            Tên_Khóa_Học = c.TenKhoaHoc,
                            Giá_Khóa_Học = c.GiaKh,
                        };
            data_gd.DataSource = quyry.ToList();
            data_gd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
