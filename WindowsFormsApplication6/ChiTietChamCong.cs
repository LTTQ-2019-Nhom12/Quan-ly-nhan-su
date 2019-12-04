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

    public partial class ChiTietChamCong : Form
    {
        mydatabase mydt = new mydatabase();
        sqlCong sqlcong = new sqlCong();
        public ChiTietChamCong()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        SqlDataReader dr;
        int dem = 0;
        string manv = null;
        int a=0;

        private void loaddt()
        {
            label2.Text = null;
            lbNV.Text = null;
            lbHT.Text = null;
            btnCapNhat.Enabled = false;
            dateCong.Value.ToString("yyyy/MM/dd");
            btnCapNhat.Enabled = true;
            dr = sqlcong.KTNgayCong(dateCong.Text);
            {
                while (dr.Read())
                {
                    a += dr.GetInt32(0);
                }


                if (a > 0)
                {
                    MessageBox.Show("Đã chấm công cho ngày hôm nay", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    dt.Clear();
                    gridViewChamCong.Refresh();
                    dt = sqlcong.LayChamCong1("0", dateCong.Text);
                    gridViewChamCong.DataSource = dt;
                    dem = 1;
                }
                else
                {
                    dt.Clear();
                    gridViewChamCong.Refresh();
                    dt = sqlcong.LayTenNhanVien("0");
                    gridViewChamCong.DataSource = dt;
                    dem = 0;
                }
            }
        }
        private void ChiTietChamCong_Load(object sender, EventArgs e)
        {       
            loaddt();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int d = 0;
            for (int i = 0; i < gridViewChamCong.RowCount; i++)
            {
                if (gridViewChamCong.Rows[i].Cells["tinhtrang"].Value == null)
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Lỗi!! \n Vui lòng kiểm tra lại";
                    gridViewChamCong.Rows[i].Cells["tinhtrang"].Selected = true;
                    d = 0;
                }
                else d++;
            }
            if (d != 0)
            {
                for (int i = 0; i < gridViewChamCong.RowCount; i++)
                {
                    string tinhtrang = gridViewChamCong.Rows[i].Cells["tinhtrang"].Value.ToString();
                    manv = gridViewChamCong.Rows[i].Cells["ma"].Value.ToString();
                    dr = sqlcong.ChamCong(manv , dateCong.Text, tinhtrang);
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo ", MessageBoxButtons.OK);
                loaddt();
            }
        }

        private void gridViewChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && dem == 1)
            {
                lbNV.Text = gridViewChamCong.CurrentRow.Cells["ma"].Value.ToString();
                lbHT.Text = gridViewChamCong.CurrentRow.Cells["ht"].Value.ToString();
                lbTT.Text = gridViewChamCong.CurrentRow.Cells["tinhtrang"].Value.ToString();
            }
            else if (e.ColumnIndex != 0 && dem == 0)
            {
                lbNV.Text = gridViewChamCong.CurrentRow.Cells["ma"].Value.ToString();
                lbHT.Text = gridViewChamCong.CurrentRow.Cells["ht"].Value.ToString();
                lbTT.Text = "";
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            mydt.loaddata(gridViewChamCong, " select cc.MaNV, HoTen, TinhTrang from tblChiTietChamCong cc inner join tblNhanVien nv on cc.MaNV = nv.MaNV where NgayCong = '" + dateCong.Text + "'");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from tblChiTietChamCong where NgayCong ='" + dateCong.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                mydt.runQuery(delete);
            loaddt();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            loaddt();
        }

        private void ckBChamCong_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBChamCong.Checked == true)
            {
                for (int i = 0; i < gridViewChamCong.RowCount; i++)
                    gridViewChamCong.Rows[i].Cells["TinhTrang"].Value = "Đi làm";
            }
            else
            {
                for (int i = 0; i < gridViewChamCong.RowCount; i++)
                    gridViewChamCong.Rows[i].Cells["TinhTrang"].Value = "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dr = sqlcong.SuaCong(manv, dateCong.Text,tinhtrang);
            MessageBox.Show("Bạn đã sửa thành công!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}