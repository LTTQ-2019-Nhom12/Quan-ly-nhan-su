using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class layMNV : UserControl
    {
        public layMNV()
        {
            InitializeComponent();
        }
        sqlCong sqlCong = new sqlCong();
        DataTable dt = new DataTable();

        private void layMaNhanVien()
        {
            dt.Clear();
            dt = sqlCong.layMaNV("0");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "HoTen";
            comboBox1.ValueMember = "MaNV";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhuCap.manv = comboBox1.SelectedValue.ToString();
            ThuongPhat.manv = comboBox1.SelectedValue.ToString();
        }

        private void layMNV_Load(object sender, EventArgs e)
        {
            layMaNhanVien();
        }
    }
}
