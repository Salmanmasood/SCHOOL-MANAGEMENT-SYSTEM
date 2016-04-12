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
    public partial class fees_sub_form : Form
    {
        string[] clas = new string[] { "Montessori", "Nursery", "PREP-I", "PREP-II", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

        public fees_sub_form()
        {
            InitializeComponent();
        }

        private void fees_sub_form_Load(object sender, EventArgs e)
        {
            //CLASS ITEMS ADDED IN COMBOBOX...
            for (int i = 0; i < clas.Length; i++)
            {
                cmbclass.Items.Add(clas[i]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string id = textBox8.Text;
            string classs=cmbclass.SelectedItem.ToString();






        }
    }
}
