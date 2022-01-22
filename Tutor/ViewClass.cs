using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutor_Student_Interface
{
    class ViewClass
    {
        private string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;
        string query; 
        public ViewClass(string q)
        {
            this.query = q;
        }

        public DataTable showrecord()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, con);
            try 
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    dt.Load(dr);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No Records were Found !! ");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

    }
}
