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
    public partial class Tk : Form
    {
        public Tk()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data =  new DataClasses1DataContext();
        private void button2_Click(object sender, EventArgs e)
        {
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
            var date = date1.Text;
            var da = date2.Text;

            var aa = (from ass in quyry
                     
                     where ass.Ngày_Đăng_Kí >= Convert.ToDateTime(date) && ass.Ngày_Đăng_Kí <= Convert.ToDateTime(da)
                     select ass.Giá_Khóa_Học).Sum();
            dtkhoang.Text = aa.ToString();

            var bb = (from ass in quyry

                     where ass.Ngày_Đăng_Kí >= Convert.ToDateTime(date) && ass.Ngày_Đăng_Kí <= Convert.ToDateTime(da)
                     select ass);
            var g = bb.ToList();
            data_tk.DataSource = g;

        }

        private void Tk_Load(object sender, EventArgs e)
        {
            load();  
        }

        public void load()
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

            data_tk.DataSource = quyry.ToList();
            data_tk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
