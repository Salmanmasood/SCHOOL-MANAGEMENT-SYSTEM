using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class insert_class
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;
        
        public insert_class()
        {

        }

        public void insert_record(string[]biodata)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERTING_RECORD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@s_name", SqlDbType.NVarChar, 50).Value = biodata[0];
                cmd.Parameters.Add("@s_fname", SqlDbType.NVarChar, 50).Value = biodata[1];
                cmd.Parameters.Add("@s_relegion", SqlDbType.NVarChar, 50).Value = biodata[2];
                cmd.Parameters.Add("@s_date_of_birth", SqlDbType.NVarChar, 50).Value = biodata[3];
                cmd.Parameters.Add("@s_class", SqlDbType.NVarChar, 50).Value = biodata[4];
                cmd.Parameters.Add("@s_address", SqlDbType.NVarChar, 50).Value = biodata[5];
                cmd.Parameters.Add("@s_contact", SqlDbType.NVarChar, 50).Value = biodata[6];
                cmd.Parameters.Add("@s_admission_date", SqlDbType.NVarChar, 50).Value = biodata[7];
                cmd.Parameters.Add("@s_admission_fees", SqlDbType.Int).Value = biodata[8];
                cmd.Parameters.Add("@s_permssion", SqlDbType.NVarChar, 50).Value = biodata[9];

                conn.Open();
                cmd.ExecuteNonQuery();


                MessageBox.Show("DATA record has been inserted successfully.....");

            }
            catch (Exception)
            {
                MessageBox.Show("data is not inserted !!!");

            }

            finally{
                conn.Close();
            }


        } //method end...........

        public void insert_medicalreord(string []medical)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERTING_medical", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@m_s_id", SqlDbType.Int).Value = medical[4];
                cmd.Parameters.Add("@m_height", SqlDbType.NVarChar, 50).Value = medical[0];
                cmd.Parameters.Add("@m_weight", SqlDbType.NVarChar, 50).Value = medical[1];
                cmd.Parameters.Add("@m_eyesight", SqlDbType.NVarChar, 50).Value = medical[2];
                cmd.Parameters.Add("@m_bloodgroup", SqlDbType.NVarChar, 50).Value = medical[3];

                conn.Open();
                cmd.ExecuteNonQuery();


                MessageBox.Show("MEDICAL DATA record has been inserted successfully.....");

            }

            catch(Exception)
            {

                MessageBox.Show("MEDICAL data is not inserted !!!");
            }

            finally
            {
                conn.Close();
            }

        } //METHOD END......

        public void insert_monthlyfees(string id,string fees,string month_id,string monthname,string year,string voucher)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("inserting_monthly_fees", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@f_s_id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@f_fees", SqlDbType.Int).Value = fees;
                cmd.Parameters.Add("@f_fees_status", SqlDbType.NVarChar, 50).Value = "PAID";
                cmd.Parameters.Add("@f_m_id", SqlDbType.Int).Value = month_id;
                cmd.Parameters.Add("@f_month_name", SqlDbType.NVarChar, 50).Value = monthname;
                cmd.Parameters.Add("@f_year", SqlDbType.NVarChar, 50).Value = year;
                cmd.Parameters.Add("@f_feesvoucher", SqlDbType.NVarChar, 50).Value = voucher;

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("FESS DATA record has been inserted successfully.....");

            }
            catch (Exception)
            {

                MessageBox.Show("FEES data is not inserted !!!");
            }

            finally
            {
                conn.Close();
            }


        }


    }
}
