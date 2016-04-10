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
    class Deletion_CLASS
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;




        public void DELETE_DATA(string S_ID,string q,string de_id)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(de_id, SqlDbType.Int).Value = S_ID;
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA record has been Deleted successfully.....");
            
            }

            catch(Exception)
            {
                MessageBox.Show("DATA record has not Deleted.....");
            
            }
            finally
            {

                conn.Close();
            }

        }

        public void insertinto_history(string []history)
        {
             SqlConnection conn = new SqlConnection(connstring);
             try
             {
                 SqlCommand cmd = new SqlCommand("insertingint_HISTORY", conn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@D_id", SqlDbType.Int).Value = history[0];
                 cmd.Parameters.Add("@D_name", SqlDbType.NVarChar, 50).Value = history[1];
                 cmd.Parameters.Add("@D_fname", SqlDbType.NVarChar, 50).Value = history[2];
                 cmd.Parameters.Add("@D_address", SqlDbType.NVarChar, 50).Value = history[3];
                 cmd.Parameters.Add("@D_date_of_birth", SqlDbType.NVarChar, 50).Value = history[4];
                 cmd.Parameters.Add("@D_class", SqlDbType.NVarChar, 50).Value = history[5];
                 cmd.Parameters.Add("@D_contact", SqlDbType.NVarChar, 50).Value = history[6];
                 cmd.Parameters.Add("@D_admission_date", SqlDbType.NVarChar, 50).Value = history[7];
                 cmd.Parameters.Add("@D_LEAving_date", SqlDbType.NVarChar, 50).Value = history[8];
                 conn.Open();
                 cmd.ExecuteNonQuery();

                 MessageBox.Show("DATA record has been inserted successfully.....");


             }

            catch(Exception)
             {

                 MessageBox.Show("DATA record has not inserted .....");


            }
             finally
             {
                 conn.Close();
             }

        }



    }
}
