using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class DangNhap : Form
    {
        mydatabase mydt = new mydatabase();
        SqlConnection con = new SqlConnection(mydatabase.conStr);

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnĐn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mydatabase.conStr))
            {
                con.Open();
                String tk = txtTenDN.Text;
                String mk = txtMK.Text;
                String query = "select * from tblTaiKhoan where TenTaiKhoan ='" + tk + "' and MatKhau ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read() == true)
                {

                    Form1 i = new Form1();
                    this.Hide();
                    i.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tai khoan sai");
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}