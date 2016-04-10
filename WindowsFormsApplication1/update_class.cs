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
    class update_class
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;
        public update_class()
        {

        }

        public void update_record(string[] biodata)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("updating_RECORD", conn);
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
                cmd.Parameters.Add("@s_id", SqlDbType.Int).Value = biodata[10];
                conn.Open();
                cmd.ExecuteNonQuery();


                MessageBox.Show("DATA record has been UPDATED successfully.....");

            }
            catch (Exception)
            {
                MessageBox.Show("data is not UPDATED !!!");

            }

            finally
            {
                conn.Close();
            }



        } //method end......

        public void update_medicalreord(string[] medical)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("updating_medical2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@m_s_id", SqlDbType.Int).Value = medical[4];
                cmd.Parameters.Add("@m_height", SqlDbType.Int).Value = medical[0];
                cmd.Parameters.Add("@m_weight", SqlDbType.Int).Value = medical[1];
                cmd.Parameters.Add("@m_eyesight", SqlDbType.NVarChar, 50).Value = medical[2];
                cmd.Parameters.Add("@m_bloodgroup", SqlDbType.NVarChar, 50).Value = medical[3];
                
                conn.Open();
                cmd.ExecuteNonQuery();


                MessageBox.Show("MEDICAL DATA record has been UPDATED successfully.....");

            }

            catch (Exception)
            {

                MessageBox.Show("MEDICAL data is not UPDATED !!!");
            }

            finally
            {
                conn.Close();
            }

        } //METHOD END......










    }
}
