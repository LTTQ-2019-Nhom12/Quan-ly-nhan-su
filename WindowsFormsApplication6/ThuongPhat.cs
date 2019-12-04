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

namespace WindowsFormsApplication6
{
    public partial class ThuongPhat : Form
    {
        public ThuongPhat()
        {
            InitializeComponent();
        }
        mydatabase mydt = new mydatabase();
        sqlCong sqlCong = new sqlCong();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        string ma = null, loai = null;
        public static string manv = null;

        public void loatTP()
        {
            dt.Clear();
            dt = sqlCong.LayThuongPhat("0");
            gridViewThuongPhat.DataSource = dt;
            layMNV laymnv = new layMNV();
            panel1.Controls.Add(laymnv);
            radioBtnKT.Enabled = false;
            radioBtnPhat.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void ThuongPhat_Load(object sender, EventArgs e)
        {
            loatTP();
        }

        private void gridViewThuongPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gridViewThuongPhat.CurrentRow.Index;
            if(gridViewThuongPhat.Rows[i].Cells["Loaitp"].Value.ToString()== "Thưởng")
            {
                radioBtnKT.Checked = true;
                loai = "Thưởng";
            }
            else
            {
                radioBtnPhat.Checked = true;
                loai = "Phạt";
            }
            txtTien.Text = gridViewThuongPhat.Rows[i].Cells["Tientp"].Value.ToString();            
            txtLyDo.Text = gridViewThuongPhat.Rows[i].Cells["LyDo"].Value.ToString();            
            dateTP.Text = gridViewThuongPhat.Rows[i].Cells["Ngay"].Value.ToString();
            ma = gridViewThuongPhat.Rows[i].Cells["MaNhanVien"].Value.ToString();
            radioBtnKT.Enabled = true;
            radioBtnPhat.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            radioBtnKT.Enabled = true;
            radioBtnPhat.Enabled = true;
            txtLyDo.Clear();
            txtTien.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (radioBtnKT.Checked == true)
                loai = "Thưởng";
            else loai = " Phạt";
            if(!string.IsNullOrEmpty(txtLyDo.Text))
            {
                if(!string.IsNullOrEmpty(txtTien.Text))
                {
                    dr = sqlCong.ThemThuongPhat(manv, loai, Convert.ToInt32(txtTien.Text), txtLyDo.Text, dateTP.Text);
                    loatTP();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập số tiền!", "Thông báo", MessageBoxButtons.OKCancel);
                }
           
            } 
            else
                {
                    MessageBox.Show("Bạn chưa nhập lý do!", "Thông báo", MessageBoxButtons.OKCancel);
                }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (radioBtnKT.Checked == true)
                loai = "Thưởng";
            else loai = " Phạt";
            dr = sqlCong.SuaThuong(ma, loai, Convert.ToInt32(txtTien.Text), txtLyDo.Text, dateTP.Text);
            loatTP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (radioBtnKT.Checked == true)
                loai = "Thưởng";
            else loai = " Phạt";
             if (MessageBox.Show("Bạn Thật Sự Muốn Xóa!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
             {
                 dr = sqlCong.XoaThuong(ma, loai, Convert.ToInt32(txtTien.Text), txtLyDo.Text, dateTP.Text);
                 loatTP();
             }
        }
        
    }
}
