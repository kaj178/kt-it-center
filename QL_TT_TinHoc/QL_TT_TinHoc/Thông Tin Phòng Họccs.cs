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
    public partial class Thông_Tin_Phòng_Họccs : Form
    {
        public Thông_Tin_Phòng_Họccs()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void Thông_Tin_Phòng_Họccs_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.PhongHocs

                        select new
                        {
                            Mã_Phòng_Học = a.MaPhong,
                            Tên_Phòng = a.TenPhong,
                            Sức_Chứa = a.SucChua,

                        };
            data_hv.DataSource = quyry.ToList();
            data_hv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
