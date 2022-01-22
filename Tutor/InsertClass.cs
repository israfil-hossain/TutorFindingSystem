using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Tutor_Student_Interface
{
    class InsertClass
    {
        //private const CommandType storedProcedure = CommandType.StoredProcedure;
        private string cs = ConfigurationManager.ConnectionStrings["Tu"].ConnectionString;

        public string insert_srecord(questions q)
        {
            string msg = " ";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                SqlCommand cmd = new SqlCommand("[insert_questions]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@q_title", SqlDbType.NVarChar).Value = q.q_title;
                cmd.Parameters.Add("@q_opa", SqlDbType.NVarChar, 200).Value = q.q_opa;
                cmd.Parameters.Add("@q_opb", SqlDbType.NVarChar, 200).Value = q.q_opb;
                cmd.Parameters.Add("@q_opc", SqlDbType.NVarChar, 200).Value = q.q_opc;
                cmd.Parameters.Add("@q_opd", SqlDbType.NVarChar, 200).Value = q.q_opd;
                cmd.Parameters.Add("@q_opcorrect", SqlDbType.NVarChar, 200).Value = q.q_opcorrect;
                cmd.Parameters.Add("@q_addeddate", SqlDbType.NVarChar, 20).Value = q.q_addeddate;
                cmd.Parameters.Add("@q_fk_ad", SqlDbType.Int).Value = q.q_fk_ad;
                cmd.Parameters.Add("@q_fk_ex", SqlDbType.Int).Value = q.q_fk_ex;

                con.Open();
                cmd.ExecuteNonQuery();
                msg = " Data Successfully inserted ";
                
            }
            catch(Exception)
            {
                msg = "data is not successfully inserted ! ";
            }
            finally
            {
                con.Close();
            }
            return msg;
        } // method end ..... 

        public string insert_srecord2(questions q2)
        {
            string msg = " ";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                SqlCommand cmd = new SqlCommand("[insert_questions]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@q_title", SqlDbType.NVarChar).Value = q2.q_title;
                cmd.Parameters.Add("@q_opa", SqlDbType.NVarChar, 200).Value = q2.q_opa;
                cmd.Parameters.Add("@q_opb", SqlDbType.NVarChar, 200).Value = q2.q_opb;
                cmd.Parameters.Add("@q_opc", SqlDbType.NVarChar, 200).Value = q2.q_opc;
                cmd.Parameters.Add("@q_opd", SqlDbType.NVarChar, 200).Value = q2.q_opd;
                cmd.Parameters.Add("@q_opcorrect", SqlDbType.NVarChar, 200).Value = q2.q_opcorrect;
                cmd.Parameters.Add("@q_addeddate", SqlDbType.NVarChar, 20).Value = q2.q_addeddate;
                cmd.Parameters.Add("@q_fk_ad", SqlDbType.Int).Value = q2.q_fk_ad;
                cmd.Parameters.Add("@q_fk_ex", SqlDbType.Int).Value = q2.q_fk_ex;

                con.Open();
                cmd.ExecuteNonQuery();
                msg = " Data Successfully Update ";

            }
            catch (Exception)
            {
                msg = "data is not successfully Update ! ";
            }
            finally
            {
                con.Close();
            }
            return msg;
        } // method end ..... 



        public string insert_setexam(string date,string stid,string exid)
        {
            string msg = " ";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                SqlCommand sqlCommand = new SqlCommand("[INSERT_SET_EXAM]", con);
                SqlCommand cmd = sqlCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@set_exam_date", SqlDbType.NVarChar).Value = date;
                cmd.Parameters.Add("@stu_id_fk", SqlDbType.Int).Value = stid;
                cmd.Parameters.Add("@exam_id_fk", SqlDbType.Int).Value = exid;


                con.Open();
                cmd.ExecuteNonQuery();
                msg = " Data Successfully inserted ";

            }
            catch (Exception)
            {
                msg = "data is not successfully inserted ! ";
            }
            finally
            {
                con.Close();
            }
            return msg;
        }   
    }
}
