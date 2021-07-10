using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Online_Store
{
    class DAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-0B0HEJ3\SQLEXPRESS; Initial Catalog = onlinestore; Integrated Security = True");
        public bool Online_Store(string myname, string mypw)
        {
            string loginvalue = "select admin_name,pw from useradmin where name ='" + myname + "' and pw ='" + mypw + "'";
            SqlCommand com = new SqlCommand(loginvalue, conn);
            SqlDataReader rdr;
            conn.Open();
            rdr = com.ExecuteReader();
            return rdr.Read();
        }
        public void insert(string name, int phone_no, string addreess, string email)
        {
           // SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-0B0HEJ3\SQLEXPRESS; Initial Catalog = onlinestore; Integrated Security = True");
            string inst = "insert into user_info values('" + name + "','" + phone_no + "','" + addreess + "''" + email + "')";
            SqlCommand com = new SqlCommand(inst, conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public void delete(int info_id)
        { 
            string del = "delete from user_info where info_id = '" + info_id + "'"; 
            SqlCommand com = new SqlCommand(del, conn);
            conn.Open(); 
            com.ExecuteNonQuery();
            conn.Close(); 
        }
    }
}
