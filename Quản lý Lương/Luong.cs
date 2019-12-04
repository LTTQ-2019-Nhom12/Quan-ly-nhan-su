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
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }
        mydatabase mydt = new mydatabase();
        sqlCong sqlcong = new sqlCong();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        int thang = DateTime.Now.Month, nam = DateTime.Now.Year, ngay = DateTime.Now.Day, luongcoban = 0, tongluong = 0, tienthuong = 0, tienphat = 0, phucap = 0, m = 0;
        string manv = null, songaylam = null, songaynghicophep = null, chucvu = null;

        private void LoatL()
        {
            DateTime ngaydau, ngaycuoi;
            songaylam = "0";
            if (m == 0)
            {
                ngaydau = Convert.ToDateTime(thang + "/" + "01/" + nam);
                ngaycuoi = Convert.ToDateTime(thang + "/" + "30/" + nam);
            }
            else
            {
                ngaydau = Convert.ToDateTime(txtThang.Text + "/" + "01/" + txtNam.Text);
                ngaycuoi = Convert.ToDateTime(txtThang.Text + "/" + "30/" + txtNam.Text);
            }
            btnCapNhat.Enabled = false;
            LbTen.Text = null;
            LbCV.Text = null;
            lbTB.Text = null;
            mydt.loadcombobox(comboHSL, "select HeSoLuong from tblLuong", "HeSoLuong");
            dt.Clear();
            dt = sqlcong.TongLuongNV("0");
            gridViewLuong.DataSource = dt;
            for (int i = 0; i < gridViewLuong.RowCount; i++)
            {
                manv = gridViewLuong.Rows[i].Cells["ma"].Value == null ?
                    string.Empty : gridViewLuong.Rows[i].Cells["ma"].Value.ToString();
                gridViewLuong.Rows[i].Cells["SNL"].Value = LaySoNgayLam(manv, ngaydau, ngaycuoi);
                gridViewLuong.Rows[i].Cells["TT"].Value = TienThuong(manv, ngaycuoi);
                gridViewLuong.Rows[i].Cells["TP"].Value = TienPhat(manv,  ngaycuoi);
                gridViewLuong.Rows[i].Cells["PC"].Value = tienPhuCap(manv, ngaycuoi);
                tongluong = TinhLuong1(manv, songaylam, ngaydau, ngaycuoi);
                gridViewLuong.Rows[i].Cells["TL"].Value = String.Format("{0:0,0}", tongluong);
            }
        }
        private string LayChucVu(string manv)
        {
            dr = sqlcong.LayChucVu(manv);
            while (dr.Read())
            {
                chucvu = dr.GetString(0);
            }
            return chucvu;
        }
       

        private void gridViewLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gridViewLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LbTen.Text = gridViewLuong.CurrentRow.Cells["HoTen"].Value.ToString();
            LbCV.Text = LayChucVu(gridViewLuong.CurrentRow.Cells["ma"].Value.ToString());
            comboHSL.Text = gridViewLuong.CurrentRow.Cells["HSL"].Value.ToString();
            txtLuongCB.Text = LayLuongCoBan(gridViewLuong.CurrentRow.Cells["ma"].Value.ToString()).ToString();
            btnCapNhat.Enabled = true;

        }

        private void Luong_Load(object sender, EventArgs e)
        {
            LoatL();
            txtNam.Text = "2019";
        }
        private void comboHSL_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = sqlcong.LayLuongCB(comboHSL.Text);
            while (dr.Read())
            {
                txtLuongCB.Text = dr.GetInt32(0).ToString();
                btnCapNhat.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string query = string.Format("update tblLuong set LuongCoBan = '" + txtLuongCB.Text + "' where HeSoLuong = '" + comboHSL.Text + "'");
            mydt.runQuery(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtLuongCB.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into tblLuong ( LuongCoBan) output inserted.HeSoLuong values ( '" + txtLuongCB.Text + "')");
            mydt.runQuery(query);
            mydt.loadcombobox(comboHSL, "select HeSoLuong from tblLuong", "HeSoLuong");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from tblLuong where LuongCoBan = '" + txtLuongCB.Text + "'");
            mydt.runQuery(query);
            mydt.loadcombobox(comboHSL, "select HeSoLuong from tblLuong", "HeSoLuong");
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtThang.Text) > 12 || Convert.ToInt32(txtThang.Text) < 1)
            {
                 lbTB.Text = "Tháng không hợp lệ";
            }
            else
            {
                m = 1;
                gridViewLuong.Refresh();
                LoatL();
                lbTB.Text = null;
            }               
        }
        private int LayLuongCoBan(string manv)
        {
            dr =  sqlcong.TongLuongNV1(manv);
            while (dr.Read())
            {
                luongcoban = dr.GetInt32(1);
            }
            return luongcoban;
        }
        private string LaySoNgayLam(string manv, DateTime ngaydau, DateTime ngaycuoi)
        {
            dr = sqlcong.DemNgayDiLam(manv, ngaydau, ngaycuoi);
            while (dr.Read())
            {
                songaylam = dr.GetInt32(1).ToString();
            }
            return songaylam;
        }
        private string NgayNghiCoPhep(string manv, DateTime ngaydau, DateTime ngaycuoi)
        {
            dr = sqlcong.DemNgaynghiCoPhep(manv, ngaydau, ngaycuoi);
            while (dr.Read())
            {
                songaynghicophep = dr.GetInt32(1).ToString();
            }
            return songaynghicophep;
        }
        private int tienPhuCap(string manv, DateTime ngay)
        {
            phucap = 0;
            try
            {
                dr = sqlcong.LayTienPhuCap(manv, ngay);
                while (dr.Read())
                {
                    phucap += dr.GetInt32(1); 
                }
            }
            catch (Exception)
            {
                phucap = 0;
            }
            return phucap;
        }
        private int TienThuong(string manv, DateTime ngay)
        {
            tienthuong = 0;
            try
            {
                dr = sqlcong.LayTienThuong(manv, ngay);
                while (dr.Read())
                {
                    tienthuong += dr.GetInt32(0);
                }
            }
            catch (Exception)
            {
                tienthuong = 0;
            }

            return tienthuong;
        }
        private int TienPhat(string manv, DateTime ngay)
        {
            tienphat =0 ;
            try
            {
                dr = sqlcong.LayTienPhat(manv, ngay);
                while (dr.Read())
                {
                    tienphat += dr.GetInt32(0);
                }
            }
            catch (Exception)
            {
                tienphat = 0;
            }
            return tienphat;
        }
        
                
        private int TinhLuong1(string manv, string soNgayLam, DateTime ngaydau, DateTime ngaycuoi)
        {

            int a = TienThuong(manv, ngaycuoi);
            int b = TienPhat(manv, ngaycuoi);
            int ncp = Convert.ToInt32(NgayNghiCoPhep(manv, ngaydau, ngaycuoi));
            int luongCoBan = LayLuongCoBan(manv);
            int nl = Convert.ToInt32(songaylam);
            int p = tienPhuCap(manv, ngaycuoi);
            if (ncp > 3)
                nl = nl - (ncp % 3);
            tongluong = (luongCoBan / 26) * nl + a - b + p;

            return tongluong;
        }                
    }
}
