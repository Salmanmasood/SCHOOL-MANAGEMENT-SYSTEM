using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class experiment : Form
    {
      string s = System.DateTime.Now.ToString();
        
        public experiment()
        {
            InitializeComponent();
        }

        private void experiment_Load(object sender, EventArgs e)
        {
            algo o = new algo();
        string today  = o.month_id_method(s);
            sqlreturn sq = new sqlreturn();
       string  yesterday = sq.scalarReturn("select top 1 f_m_id from monthly_fess ");
            string montname=o.month_name_method(s);
            if (today!=yesterday)
       {
           DialogResult d = MessageBox.Show("you want to update it All", "imp msg", MessageBoxButtons.YesNo);

           if (d == DialogResult.Yes)
           {
               string initiallimit = sq.scalarReturn("select top 1 f_s_id from monthly_fess");
               string finallimit = sq.scalarReturn("select top 1 f_s_id from monthly_fess ORDER BY f_s_id  DESC");
               int s1 = Convert.ToInt32(initiallimit);
               int sl = Convert.ToInt32(finallimit);
               update_class up = new update_class();
               for (int i = s1; i <= sl; i++)
               {

                   up.update_monthchanges(i.ToString(), today, montname, System.DateTime.Now.Year.ToString());

               }
               MessageBox.Show("fees record has been UPDATED successfully.....");
           }
          


       }





        }
    }
}
