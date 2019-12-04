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
    public partial class DangKi : Form
    {
        mydatabase mydt = new mydatabase();
        SqlConnection con = new SqlConnection(mydatabase.conStr);
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public DangKi()
        {
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtĐN.Clear();
            txtMK.Clear();
        }
        private SqlDataReader DemMa( string manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("DemMaNV", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            dr = cm.ExecuteReader();
            return dr;
        }
        private SqlDataReader DemTen(string tentk)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("DemTenTK", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@tentk", tentk);
            dr = cm.ExecuteReader();
            return dr;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            int a=0, b=0;
            dr = DemMa(txtMaNV.Text);
            while (dr.Read())
            {
                a += dr.GetInt32(0);
            } 
            dr = DemTen(txtĐN.Text);
            while (dr.Read())
            {
                b = dr.GetInt32(0);
            }

            String query = "insert into tblTaiKhoan( MaNV, TenNhanVien, TenTaiKhoan, MatKhau) values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtĐN.Text + "','" + txtMK.Text + "')";
            if (a > 0)
            {
                  MessageBox.Show("Nhân viên đã có tài khoản đăng nhập");
                  txtMaNV.Clear();
            }
            else
            {
                if (b > 0)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại");
                    txtĐN.Clear();
                }
                else
                {
                    mydt.runQuery(query);
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công");
                    this.Close();
                }   
             }
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
