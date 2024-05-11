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
    public partial class Thông_Tin_Lớp_Học : Form
    {
        public Thông_Tin_Lớp_Học()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Thông_Tin_Lớp_Học_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.LopHocs
                        join b in data.PhongHocs on a.MaPhong equals b.MaPhong
                        join c in data.GiangViens on a.MaGiangVien equals c.MaGiangVien
                        join d in data.KhoaHocs on a.MaKhoaHoc equals d.MaKhoaHoc

                        select new
                        {
                            Mã_Lớp_Học = a.MaLop,
                            Tên_Lớp = a.TenLop,
                            Tên_Phòng_Học = b.TenPhong,
                            Tên_Giảng_Viên = c.HoTen,
                            Tên_Khóa_Học = d.TenKhoaHoc,
                          


                        };
            data_lophoc.DataSource = quyry.ToList();
            data_lophoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
