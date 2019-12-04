using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 


        private void btnĐX_Click(object sender, EventArgs e)
        {
            DangNhap i = new DangNhap();
            i.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picHSNV_Click(object sender, EventArgs e)
        {
            HosoNV i = new HosoNV();
            i.ShowDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemĐK_Click(object sender, EventArgs e)
        {
            DangKi i = new DangKi();
            i.ShowDialog();
        }

        private void picCTLuong_Click(object sender, EventArgs e)
        {
            Luong i = new Luong();
            i.ShowDialog();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietChamCong chcong = new ChiTietChamCong();
            chcong.ShowDialog();
        }

        private void picCong_Click(object sender, EventArgs e)
        {
            ChiTietChamCong chcong = new ChiTietChamCong();
            chcong.ShowDialog();
        }


        private void menuItemPhuCap_Click(object sender, EventArgs e)
        {
            PhuCap i = new PhuCap();
            i.ShowDialog();
        }

        private void menuItemThuongPhat_Click(object sender, EventArgs e)
        {
            ThuongPhat i = new ThuongPhat();
            i.ShowDialog();
        }

        private void menuItemLuong_Click(object sender, EventArgs e)
        {
            Luong i = new Luong();
            i.ShowDialog();
        }

        private void btnĐX_Click_1(object sender, EventArgs e)
        {
            
            DangNhap i = new DangNhap();
            MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông Báo", MessageBoxButtons.YesNo);
            this.Hide();      
            i.ShowDialog();
            
        }
    }

}