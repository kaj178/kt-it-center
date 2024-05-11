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
    public partial class Thông_Tin_Khóa_Học : Form
    {
        public Thông_Tin_Khóa_Học()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data =new DataClasses1DataContext();
        private void Thông_Tin_Khóa_Học_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.KhoaHocs

                        select new
                        {
                            Mã_Khóa_Học = a.MaKhoaHoc,
                            Tên_Khóa_Học = a.TenKhoaHoc,
                            Mô_Tả = a.MoTa,
                        };
            data_kh.DataSource = quyry.ToList();
            data_kh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
