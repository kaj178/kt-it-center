using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QL_TT_TinHoc
{
    public partial class Đăng_Kí_Học_Viên : Form
    {
        public Đăng_Kí_Học_Viên()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Đăng_Kí_Học_Viên_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.HocViens
                        join b  in data.DKKhoaHocs on a.MaHocVien equals b.MaHocVien
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
                            Ngày_Đăng_Kí =  b.Ngaydk,
                            Tên_Khóa_Học = c.TenKhoaHoc,
                            Giá_Khóa_Học = c.GiaKh,




                        };
            cbo_tenkh.DataSource = data.KhoaHocs;
            cbo_tenkh.DisplayMember = "TenKhoaHoc";
            cbo_tenkh.ValueMember = "MaKhoaHoc";
            date_ngaydk.Enabled= false;

            data_dkhv.DataSource = quyry.ToList();
            data_dkhv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void data_dkhv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_dkhv.Rows[e.RowIndex];
            txt_mahv.Text = row.Cells["Mã_Học_Viên"].Value.ToString();
         
            cbo_gioitinh.Text = row.Cells["Giới_Tính"].Value.ToString();
            txt_sdt.Text = row.Cells["SĐT"].Value.ToString();
            txt_diachi.Text = row.Cells["Địa_Chỉ"].Value.ToString();
            date_ngaydk.Text = row.Cells["Ngày_Đăng_Kí"].Value.ToString();
            txt_tenhv.Text = row.Cells["Họ_Tên"].Value.ToString();
            txt_tuoi.Text = row.Cells["Tuổi"].Value.ToString();
            txt_email.Text = row.Cells["Email"].Value.ToString();
            cbo_tenkh.Text = row.Cells["Tên_Khóa_Học"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HocVien pb = new HocVien();

                pb.MaHocVien = Convert.ToInt32(txt_mahv.Text.ToString());
                pb.HoTen = txt_tenhv.Text.ToString();
                pb.Tuoi = Convert.ToInt32(txt_tuoi.Text.ToString());
                pb.GioiTinh = cbo_gioitinh.Text.ToString();
                pb.Email = txt_email.Text.ToString();
                pb.DienThoai = txt_sdt.Text.ToString();
                pb.DiaChi = txt_diachi.Text.ToString();
                data.HocViens.InsertOnSubmit(pb);
                data.SubmitChanges();


                DKKhoaHoc dk = new DKKhoaHoc();
                dk.MaHocVien = Convert.ToInt32(txt_mahv.Text.ToString());

               
                var a = (from ass in data.KhoaHocs
                         where ass.TenKhoaHoc == cbo_tenkh.Text
                         select ass.MaKhoaHoc).FirstOrDefault();
                dk.MaKhoaHoc = a;

                dk.Ngaydk= DateTime.Now;

                data.DKKhoaHocs.InsertOnSubmit(dk);
                data.SubmitChanges();
              
                MessageBox.Show("Học viên " + txt_tenhv.Text + " đăng kí khóa học "+ cbo_tenkh.Text +" thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng Kí Thất Bại");
            }
            finally
            {
                var qlpb = data.HocViens;
                data_dkhv.DataSource = qlpb;
                Đăng_Kí_Học_Viên_Load(sender, e);
            }
        }
    }
}
