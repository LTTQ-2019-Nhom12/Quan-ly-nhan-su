using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication6
{
    class sqlCong
    {
        mydatabase mybt = new mydatabase();
        SqlConnection con = new SqlConnection(mydatabase.conStr);
        DataTable dt = new DataTable();

        public SqlDataReader LayChamCong(string manv, string ngaycong)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("LayChamCong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngay", ngaycong);
            dr = cm.ExecuteReader();
            return dr;
        }
        public DataTable LayChamCong1(string manv, string ngaycong)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("LayChamCong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngay", ngaycong);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader KTNgayCong(string ngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("KTNgayCong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ngay", ngay);
            dr = cm.ExecuteReader();
            return dr;
        }

        public DataTable LayTenNhanVien(string manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("LayTenNhanVien", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader ChamCong(string manv, string ngay, string tinhtrang)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("ChamCong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngaycong", ngay);
            cm.Parameters.AddWithValue("@tinhtrang", tinhtrang);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader SuaCong(string manv, string ngay, string tinhtrang)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("SuaCong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngaycong", ngay);
            cm.Parameters.AddWithValue("@tinhtrang", tinhtrang);
            dr = cm.ExecuteReader();
            return dr;
        }

        public DataTable LayPhuCap(string manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("LayPhuCap", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable layMaNV(string manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("layMaNV", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader ThemPhuCap(string manv, string loaipc, int tien, string tungay, string denngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("ThemPhuCap", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@loaipc", loaipc);
            cm.Parameters.AddWithValue("@tien", tien);
            cm.Parameters.AddWithValue("@tungay", tungay);
            cm.Parameters.AddWithValue("@denngay", denngay);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader LayMNV(string tenTK)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("LayMNV", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@tentaikhoan", tenTK);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader SuaPhuCap(string manv, string loaipcc, string loaipcm, int tien, string tungay, string denngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("SuaPhuCap", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@loaipcc", loaipcc);
            cm.Parameters.AddWithValue("@loaipcm", loaipcm);
            cm.Parameters.AddWithValue("@tien", tien);
            cm.Parameters.AddWithValue("@tungay", tungay);
            cm.Parameters.AddWithValue("@denngay", denngay);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader XoaPhuCap(string manv, string loaipc)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("XoaPhuCap", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("loaipc", loaipc);
            dr = cm.ExecuteReader();
            return dr;
        }
        public DataTable LayThuongPhat(string manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("LayThuongPhat", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader ThemThuongPhat(string manv, string loai, int tien, string lydo, string ngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("ThemThuong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@loai", loai);
            cm.Parameters.AddWithValue("@tien", tien);
            cm.Parameters.AddWithValue("@lydo", lydo);
            cm.Parameters.AddWithValue("@ngay", ngay);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader SuaThuong(string manv, string loai, int tien, string lydo, string ngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("SuaThuong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@loai", loai);
            cm.Parameters.AddWithValue("@tien", tien);
            cm.Parameters.AddWithValue("@lydo", lydo);
            cm.Parameters.AddWithValue("@ngay", ngay);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader XoaThuong(string manv, string loai, int tien, string lydo, string ngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("XoaThuong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@loai", loai);
            cm.Parameters.AddWithValue("@tien", tien);
            cm.Parameters.AddWithValue("@lydo", lydo);
            cm.Parameters.AddWithValue("@ngay", ngay);
            dr = cm.ExecuteReader();
            return dr;
        }
        public DataTable TongLuongNV(string manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("TongLuongNV", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader DemNgayDiLam(string manv, DateTime ngaydau, DateTime ngaycuoi)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("DemNgayDiLam", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngaydau", ngaydau);
            cm.Parameters.AddWithValue("@ngaycuoi", ngaycuoi);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader DemNgaynghiCoPhep(string manv, DateTime ngaydau, DateTime ngaycuoi)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("DemNgaynghiCoPhep", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngaydau", ngaydau);
            cm.Parameters.AddWithValue("@ngaycuoi", ngaycuoi);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader LayTienThuong(string manv, DateTime ngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("LayTienThuong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngay", ngay);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader LayTienPhat(string manv, DateTime ngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("LayTienPhat", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngay", ngay);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader TongLuongNV1(string manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("TongLuongNV", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader LayChucVu( string manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("LayChucVu", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader LayTienPhuCap(string manv, DateTime ngay)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("LayTienPhuCap", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            cm.Parameters.AddWithValue("@ngay", ngay);
            dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader LayLuongCB (string hesl)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("LayLuongCB", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@hesl", hesl);
            dr = cm.ExecuteReader();
            return dr;
        }



        internal SqlDataReader SuaCong(string manv, string p, System.Windows.Forms.DataGridViewComboBoxColumn tinhtrang)
        {
            throw new NotImplementedException();
        }
    }
}
