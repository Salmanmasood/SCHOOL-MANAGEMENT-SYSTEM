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
    public partial class view_form : Form
    {
        public view_form()
        {
            InitializeComponent();
        }

        private void view_form_Load(object sender, EventArgs e)
        {
            string q = "select * from student_record";
            view_class v = new view_class(q);
           dataGridView1.DataSource= v.showrecord();
        }
    }
}
