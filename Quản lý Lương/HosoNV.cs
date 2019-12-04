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

namespace WindowsFormsApplication6
{
    public partial class HosoNV : Form
    {
        mydatabase mydt = new mydatabase();
        public HosoNV()
        {
            InitializeComponent();
            
        }

        private void HosoNV_Load(object sender, EventArgs e)
        {
            gridViewHSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewHSNV.DataSource = hSNV().Tables[0];
            ngaySinh.CustomFormat = "MM/dd/yyyy";
            mydt.loadcombobox(combPB, "Select MaPhongBan from tblPhongBan", "MaPhongBan");
            mydt.loadcombobox(combCV, "select MaChucVu from tblChucVu","MaChucVu");
            mydt.loadcombobox(comHSL, "select HeSoLuong from tblLuong","HeSoLuong");
        }
        
        DataSet hSNV()
        {
            DataSet data = new DataSet();
            String query = "select * from tblNhanVien ";
            using(SqlConnection con = new SqlConnection(mydatabase.conStr))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        } 
       
        private void gridViewHSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gridViewHSNV.CurrentRow.Index;
            txtMaNV.Text = gridViewHSNV.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = gridViewHSNV.Rows[i].Cells[1].Value.ToString();
            cbGioiTinh.Text = gridViewHSNV.Rows[i].Cells[2].Value.ToString();
            ngaySinh.Text = gridViewHSNV.Rows[i].Cells[3].Value.ToString();
            txtCMND.Text = gridViewHSNV.Rows[i].Cells[4].Value.ToString();
            txtQueQuan.Text = gridViewHSNV.Rows[i].Cells[5].Value.ToString();
            combPB.Text = gridViewHSNV.Rows[i].Cells[6].Value.ToString();
            combCV.Text = gridViewHSNV.Rows[i].Cells[7].Value.ToString();
            ckbCo.Text = gridViewHSNV.Rows[i].Cells[8].Value.ToString();
            comHSL.Text = gridViewHSNV.Rows[i].Cells[9].Value.ToString();

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cbGioiTinh.Clear();
            txtCMND.Clear();
            txtQueQuan.Clear();
            ckbCo.ResetText();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
                string delete = "delete from tblNhanVien where MaNV=N'" + txtMaNV.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    mydt.runQuery(delete);
                gridViewHSNV.Refresh();
                mydt.loaddata(gridViewHSNV, "select * from tblNhanVien");
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "insert into tblNhanVien(MaNV, HoTen, GioiTinh, NgaySinh, SoCMND, QueQuan, MaPhongBan, MaChucVu, DongBHXH, HeSoLuong ) values('" + txtMaNV.Text + "', N'" + txtHoTen.Text + "', N'" + cbGioiTinh.Text + "','" + ngaySinh.Text + "', '" + txtCMND.Text + "',N'" + txtQueQuan.Text + "',N'" + combPB.Text + "',N'" + combCV.Text + "', '" + ckbCo.Text + "','" + comHSL.Text + "')";           
            mydt.runQuery(query);
            gridViewHSNV.Refresh();
            mydt.loaddata(gridViewHSNV, "select * from tblNhanVien");            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string query = "update tblNhanVien set HoTen = N'" + txtHoTen.Text + "',GioiTinh = N'" + cbGioiTinh.Text + "',NgaySinh = '" + ngaySinh.Text + "',SoCMND = '" + txtCMND.Text + "',QueQuan = N'" + txtQueQuan.Text + "',MaPhongBan = '" + combPB.Text + "',MaChucVu = '" + combCV.Text + "',DongBHXH = '" + ckbCo.Text + "',HeSoLuong = '" + comHSL.Text + "' where MaNV = '" + txtMaNV.Text + "'";
            mydt.runQuery(query);
            gridViewHSNV.Refresh();
            mydt.loaddata(gridViewHSNV, "select * from tblNhanVien");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 i = new Form1();
            i.ShowDialog();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM tblNhanVien WHERE HoTen LIKE N'%{0}%'", txtTimkiem.Text);
            mydatabase db = new mydatabase();
            gridViewHSNV.DataSource = db.getData(sql);         
        }
    }
}