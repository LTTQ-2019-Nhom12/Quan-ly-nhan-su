using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace WindowsFormsApplication6
{
    public partial class PhuCap : Form
    {
        public PhuCap()
        {
            InitializeComponent();
        }
        mydatabase mydt = new mydatabase();
        sqlCong sqlCong = new sqlCong();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        string ma = null, loai = null;
        public static string manv = null;
        public void loatPC()
        {            
            dt.Clear();
            dt = sqlCong.LayPhuCap("0");
            gridViewPhuCap.DataSource = dt;
            layMNV laymnv = new layMNV();
            panel.Controls.Add(laymnv);
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            radioBtnTheoTen.Checked = true;
        }

        private void PhuCap_Load(object sender, EventArgs e)
        {
            loatPC();
        }

        private void gridViewPhuCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gridViewPhuCap.CurrentRow.Index;
            
            txtTenPC.Text= gridViewPhuCap.Rows[i].Cells["LoaiPC"].Value.ToString();
            loai = gridViewPhuCap.Rows[i].Cells["LoaiPC"].Value.ToString();
            txtTien.Text = gridViewPhuCap.Rows[i].Cells["Tien"].Value.ToString();
            datetimeTuNgay.Text = gridViewPhuCap.Rows[i].Cells["TuNgay"].Value.ToString();
            dateTimeDenNgay.Text = gridViewPhuCap.Rows[i].Cells["DenNgay"].Value.ToString();
            ma = gridViewPhuCap.Rows[i].Cells["MaNhanVien"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtTenPC.Clear();
            txtTien.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(radioBtnTheoTen.Checked == true)
            {
                dr = sqlCong.ThemPhuCap(manv, txtTenPC.Text, Convert.ToInt32(txtTien.Text), datetimeTuNgay.Text, dateTimeDenNgay.Text);
            }
            loatPC();
            }

        private void btnSua_Click(object sender, EventArgs e) 
        {
            dr = sqlCong.SuaPhuCap(ma, loai, txtTenPC.Text, Convert.ToInt32(txtTien.Text), datetimeTuNgay.Text, dateTimeDenNgay.Text);
            loatPC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn xóa!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dr = sqlCong.XoaPhuCap(ma, loai);
                loatPC();
            }
            
        }

    }

       
       
    }
