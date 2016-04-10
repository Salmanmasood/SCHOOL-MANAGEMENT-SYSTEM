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
    class sqlreturn
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;

        string q;
        public sqlreturn(string q )
        {
            this.q = q;
        }
        public sqlreturn()
        {

        }

        public string scalarReturn()
        {
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);
            string s = cmd.ExecuteScalar().ToString();
            return s;

        }

        public string scalarReturn(string q)
        {
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);
            string s = cmd.ExecuteScalar().ToString();
            return s;

        }





    }
}
