using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Tutor_Student_Interface
{
    class returnclass
    {
        string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
       // string cs2 = ConfigurationManager.ConnectionStrings["tutorsPoint"].ConnectionString;

        public string scalarReturn(string q)
        {
            string s;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, con);
                s = cmd.ExecuteScalar().ToString();
            }
            catch(Exception)
            {
                s = " ";
            }
            con.Close();
            return s;
        }
        public string scalarReturn2(string q2)
        {
            string s2;
            SqlConnection con2 = new SqlConnection(cs);
            con2.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q2, con2);
                s2 = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                s2 = " ";
            }
            con2.Close();
            return s2;
        }
    }
}
