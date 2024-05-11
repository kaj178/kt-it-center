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
    public partial class THÔNG_TIN_HỌC_VIÊN : Form
    {
        public THÔNG_TIN_HỌC_VIÊN()
        {
            InitializeComponent();
        }
        DataClasses1DataContext  data = new DataClasses1DataContext();
        private void THÔNG_TIN_HỌC_VIÊN_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.HocViens

                        select new
                        {
                            Mã_Học_Viên = a.MaHocVien,
                            Họ_Tên = a.HoTen,
                            Giới_Tính = a.GioiTinh,
                            Tuổi = a.Tuoi,

                            Địa_Chỉ = a.DiaChi,
                            Số_CMND = a.DienThoai,
                            Email = a.Email,



                        };
            data_hv.DataSource = quyry.ToList();
            data_hv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
        }
    }
}
