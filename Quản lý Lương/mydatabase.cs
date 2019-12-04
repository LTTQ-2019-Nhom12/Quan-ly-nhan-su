using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication6
{
    class mydatabase
    {
        public static string conStr = @"Data Source=EX-20190830IMIV\SQLHOAI;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection sqlcon;
        SqlCommand sqlcomm;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();

         void ketnoi()
        {
            sqlcon = new SqlConnection(conStr);
            sqlcon.Open();
        }
        public void ngatketnoi()
        {
            sqlcon.Close();
        }

        public DataTable getData(string sql)
        {
            ketnoi();
            sqlda = new SqlDataAdapter(sql, sqlcon);
            DataTable myDt = new DataTable();
            sqlda.Fill(myDt);
            return myDt;
            
        }

        public void runQuery(string sql)
        {         
            ketnoi();
            sqlcomm = new SqlCommand(sql, sqlcon);
            sqlcomm.ExecuteNonQuery();
            ngatketnoi();
        }
        public SqlDataReader reader(string sql)
        {
            sqlcon.Open();
            sqlcomm = new SqlCommand(sql, sqlcon);
            sqldr = sqlcomm.ExecuteReader();
            return sqldr;
        }
        
        public void loadcombobox(ComboBox cb, string sql, string name )
        {
            DataTable dt = new DataTable();
            ketnoi();
            sqlcomm = new SqlCommand(sql, sqlcon);
            sqldr = sqlcomm.ExecuteReader();
            dt.Load(sqldr);
            sqldr.Dispose();
            cb.DisplayMember = name;
            cb.DataSource = dt;
        }
        public void loaddata(DataGridView dg, string strselect)
        {
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, conStr);
            sqlda.Fill(ds, "tenbang");
            dg.DataSource = ds.Tables[0];
        }
               
    }

}
