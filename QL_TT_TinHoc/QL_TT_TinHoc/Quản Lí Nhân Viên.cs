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
    public partial class Quản_Lí_Nhân_Viên : Form
    {
        public Quản_Lí_Nhân_Viên()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien pb = new NhanVien();

                pb.HoTen = txt_tennv.Text.ToString();
               
                pb.DiaChi = txt_diachi.Text.ToString();
                pb.GioiTinh = cbo_gioitinh.Text.ToString();
                
                pb.tk = txt_tkk.Text.ToString();
                pb.mk = txt_mkk.Text.ToString();
                pb.MucLuong = Convert.ToInt32(txt_mucluong.Text.ToString());
                pb.IdRole = 2;

                data.NhanViens.InsertOnSubmit(pb);
                data.SubmitChanges();
                var a = pb.HoTen;
                MessageBox.Show("Thêm thông tin nhân viên " + a.ToString() + " thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            finally
            {
                var qlpb = data.NhanViens;
                data_nv.DataSource = qlpb;
                Quản_Lí_Nhân_Viên_Load(sender, e);
            }
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Quản_Lí_Nhân_Viên_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.NhanViens

                        select new
                        {
                            Mã_Nhân_Viên = a.IdNV,
                            Tên_NV = a.HoTen,
                            Giới_Tính = a.GioiTinh,
                            Mức_Lương = a.MucLuong,
                           
                            Địa_Chỉ = a.DiaChi,
                            Tài_Khoản = a.tk,
                            Mật_Khẩu = a.mk,
                           


                        };

         cbo_tennv.DataSource = data.NhanViens;
         cbo_tennv.DisplayMember = "HoTen";
         cbo_tennv.ValueMember = "IdNV";


            data_nv.DataSource = quyry.ToList();
            data_nv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_manv.Enabled = false;
            txt_tennv.Text = "";
            txt_mucluong.Text = "";
           
            txt_diachi.Text = "";
            txt_mkk.Text = "";
            txt_tkk.Text = "";
            txt_manv.Text = "";
            txt_manv.Enabled=false;
          
        }

        private void data_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_nv.Rows[e.RowIndex];
            txt_manv.Text = row.Cells["Mã_Nhân_Viên"].Value.ToString();

          
            txt_mkk.Text = row.Cells["Mật_Khẩu"].Value.ToString();
            txt_diachi.Text = row.Cells["Địa_Chỉ"].Value.ToString();
            txt_mucluong.Text = row.Cells["Mức_Lương"].Value.ToString();
            txt_tennv.Text = row.Cells["Tên_NV"].Value.ToString();
            txt_tkk.Text = row.Cells["Tài_Khoản"].Value.ToString();
            cbo_gioitinh.Text = row.Cells["Giới_Tính"].Value.ToString();
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var pb1 = txt_manv.Text;
                NhanVien edit_nv = data.NhanViens.Where(o => o.IdNV.Equals(pb1)).FirstOrDefault();
                edit_nv.HoTen = txt_tennv.Text.ToString();

                edit_nv.DiaChi = txt_diachi.Text.ToString();
                edit_nv.GioiTinh = cbo_gioitinh.Text.ToString();

                edit_nv.tk = txt_tkk.Text.ToString();
                edit_nv.mk = txt_mkk.Text.ToString();
                edit_nv.MucLuong = Convert.ToInt32(txt_mucluong.Text.ToString());
                edit_nv.IdRole = 2;
                var a = edit_nv.HoTen;
                MessageBox.Show("Sửa thông tin nhân viên " + a.ToString() + " thành công");

            }
            catch (Exception)
            {
                MessageBox.Show("Sửa Thông Tin Nhân Viên Thất Bại!");
            }
            finally
            {
                var qlpb = data.NhanViens;
                data_nv.DataSource = qlpb;
                data.SubmitChanges();

                Quản_Lí_Nhân_Viên_Load(sender, e);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var pb2 = txt_manv.Text;
                NhanVien del_pb = data.NhanViens.Where(o => o.IdNV.Equals(pb2)).FirstOrDefault();
                data.NhanViens.DeleteOnSubmit(del_pb);
                data.SubmitChanges();
                var a = del_pb.HoTen;
                MessageBox.Show("Đã xóa thông tin nhân viên " + a.ToString() + " khỏi cơ sở dữ liệu");
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa Thất Bại !");
            }
            finally
            {
                var pb3 = data.NhanViens;
                data_nv.DataSource = pb3;

                Quản_Lí_Nhân_Viên_Load(sender, e);

            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            Quản_Lí_Nhân_Viên_Load(sender,e);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            pnl_calam.Visible= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CaLam pb = new CaLam();

                pb.caLam1 = cbo_calam.Text.ToString();


                var a = (from ass in data.NhanViens
                         where ass.HoTen == cbo_tennv.Text
                         select ass.IdNV).FirstOrDefault();
                pb.IdNV = a;

                data.CaLams.InsertOnSubmit(pb);
                data.SubmitChanges();
              
                MessageBox.Show("Thêm ca làm thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            finally
            {
                var qlpb = data.CaLams;
                data_nv.DataSource = qlpb;
                Quản_Lí_Nhân_Viên_Load(sender, e);
            }
        }
    }
}
