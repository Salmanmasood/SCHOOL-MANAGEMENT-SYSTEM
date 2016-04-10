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
    public partial class Form1 : Form
    {
        string[] clas = new string[] { "Montessori", "Nursery", "PREP-I", "PREP-II", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
        int[] admissionfees = new int[5];//FEES ARRAY
        string[] months = new string[] { "Januray", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string []biodata= new string[11];
        string[] MEDICALdata = new string[5];
        string fees;
        string month_id,month_name,voucher;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            txt_id.Enabled = false;


            textBox6.Enabled = false;
            textBox5.Text = System.DateTime.Now.ToString();
            
            admissionfees[0] = 10000; //class ix,x admission fees
            admissionfees[1] = 12000; //class vi -viii admission fees
           admissionfees[2] = 14000; //class i-v admission fees
           admissionfees[3] = 15000;//montessori to prep ii admission fees
           //for MONTHS IN COMBOBOX.....
            for (int i = 0; i < months.Length; i++)
           {
               cmbmonth.Items.Add(months[i]);
           }
            //for YEARS IN COMBOBOX....
            for (int i = 1990; i < DateTime.Now.Year; i++)
           {
               cmbyear.Items.Add(i.ToString());
           }
            //CLASS ITEMS ADDED IN COMBOBOX...
            for (int i = 0; i < clas.Length; i++)
            {
                cmbclass.Items.Add(clas[i]);

            }



        }

        private void cmbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmonth.SelectedItem.ToString() == "February")
            {
                cmbdate.Items.Clear();
                for (int i = 1; i <= 28; i++)
                {
                    cmbdate.Items.Add(i.ToString());  //setting feburary days
                }
            }

            else if (cmbmonth.SelectedItem.ToString() == "April" || cmbmonth.SelectedItem.ToString() == "June" || cmbmonth.SelectedItem.ToString() == "September" || cmbmonth.SelectedItem.ToString() == "November")
            {
                cmbdate.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    cmbdate.Items.Add(i.ToString()); //setting 30 days months
                }

            }

            else
            {
                cmbdate.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    cmbdate.Items.Add(i.ToString()); //setting 31 days months
                }

            }
        }
        //EVENT EDNING.....
        private void cmbyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(cmbyear.SelectedItem.ToString());
                if (year % 4 == 0)
                {
                    if (cmbmonth.SelectedItem.ToString() == "February")
                    {
                        cmbdate.Items.Clear();
                        for (int i = 1; i <= 29; i++)
                        {

                            cmbdate.Items.Add(i.ToString());
                        }
                    }
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Select the month 1st!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbmonth.Text = "";
            cmbdate.Text = "";
            cmbyear.Text = "";
            cmbclass.Text = "";
            txtname.Clear();
            txtfname.Clear();
            txtreligion.Clear();
            txtaddress.Clear();
            txtcontct.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox6.Clear();
            
        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //admissionfees[0] = 10000; //class ix,x admission fees
            //admissionfees[1] = 12000; //class vi -viii admission fees
            //admissionfees[2] = 14000; //class i-v admission fees
            //admissionfees[3] = 15000;//montessori to prep ii admission fees
            if (cmbclass.SelectedItem.ToString() == "Montessori" || cmbclass.SelectedItem.ToString() == "Nursery" || cmbclass.SelectedItem.ToString() == "PREP-I" || cmbclass.SelectedItem.ToString() == "PREP-II")
            {
                textBox6.Text = admissionfees[3].ToString();
               fees = "4000";
            }

            if (cmbclass.SelectedItem.ToString() == "I" || cmbclass.SelectedItem.ToString() == "II" || cmbclass.SelectedItem.ToString() == "III" || cmbclass.SelectedItem.ToString() == "IV" || cmbclass.SelectedItem.ToString() == "V")
            {
                textBox6.Text = admissionfees[2].ToString();
                fees = "4500";
            }
            if (cmbclass.SelectedItem.ToString() == "VI" || cmbclass.SelectedItem.ToString() == "VII" || cmbclass.SelectedItem.ToString() == "VIII")
            {
                textBox6.Text = admissionfees[1].ToString();
                fees = "5000";
            }

            if (cmbclass.SelectedItem.ToString() == "IX" || cmbclass.SelectedItem.ToString() == "X")
            {
                textBox6.Text = admissionfees[0].ToString();
                fees = "6000";
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            {//MY CODE HANDLING

                biodata[0] = txtname.Text;
                biodata[1] = txtfname.Text;
                biodata[2] = txtreligion.Text;
                biodata[3] = cmbmonth.SelectedItem.ToString() + "-" + cmbyear.SelectedItem.ToString() + "-" + cmbdate.SelectedItem.ToString();
                biodata[4] = cmbclass.SelectedItem.ToString();
                biodata[5] = txtaddress.Text;
                biodata[6] = txtcontct.Text;
                biodata[7] = textBox5.Text; //date
                biodata[8] = textBox6.Text; //fess
                if (checkBox3.Checked == true)
                {
                    biodata[9] = "self";
                }
                else if (checkBox4.Checked == true)
                {
                    biodata[9] = "Transport";
                }
                else if (checkBox4.Checked == true && checkBox3.Checked == true)
                {
                    biodata[9] = "Both";
                }
                else
                {
                    biodata[9] = "NONE";
                }
                MEDICALdata[0] = textBox1.Text; //HEIGHT
                MEDICALdata[1] = textBox2.Text; //WEIGHT
                MEDICALdata[2] = textBox3.Text;//EYESIGHT
                MEDICALdata[3] = textBox4.Text;//BLOODGROUP..

                string s = System.DateTime.Now.ToString();
                algo a = new algo();
                month_id = a.month_id_method(s);
                month_name = a.month_name_method(s);

                sqlreturn s1 = new sqlreturn("select MAX(voucher) from voucher_record");
               string voucher_s= s1.scalarReturn();
               algo ab = new algo();
               
                voucher ="P-"+ab.voucher_return(voucher_s);
                insert_class v1 = new insert_class();
                v1.insert_voucher(voucher);
            } //MY CODE HANDLING

















            insert_class C1 = new insert_class();
            C1.insert_record(biodata);

            string querry = "select s_id from student_record where s_name='" + biodata[0] + "'";            
            sqlreturn ob = new sqlreturn(querry);
            MEDICALdata[4] = ob.scalarReturn(); //THIS IS ID FOR MEDICAL RECORD......
            
            insert_class M1 = new insert_class();
            M1.insert_medicalreord(MEDICALdata);
            sqlreturn ob2 = new sqlreturn(querry);
            string M_D = ob2.scalarReturn();
            insert_class F1 = new insert_class();

            F1.insert_monthlyfees(M_D, fees, month_id, month_name, cmbyear.SelectedItem.ToString(),voucher);

        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                button3.Enabled = true;
                txt_id.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;

            }
            if (checkBox1.Checked==false)
            {
                button1.Enabled = true;
                button3.Enabled =false;
                txt_id.Enabled = false;
                button1.Enabled = true;

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            {//MY CODE HANDLING

                biodata[0] = txtname.Text;
                biodata[1] = txtfname.Text;
                biodata[2] = txtreligion.Text;
                biodata[3] = cmbmonth.SelectedItem.ToString() + "-" + cmbyear.SelectedItem.ToString() + "-" + cmbdate.SelectedItem.ToString();
                biodata[4] = cmbclass.SelectedItem.ToString();
                biodata[5] = txtaddress.Text;
                biodata[6] = txtcontct.Text;
                biodata[7] = textBox5.Text; //date
                biodata[8] = textBox6.Text; //fess

                if (checkBox3.Checked == true)
                {
                    biodata[9] = "self";
                }
                else if (checkBox4.Checked == true)
                {
                    biodata[9] = "Transport";
                }
                else if (checkBox4.Checked == true && checkBox3.Checked == true)
                {
                    biodata[9] = "Both";
                }
                else
                {
                    biodata[9] = "NONE";
                }
                biodata[10] = txt_id.Text; //fess

                MEDICALdata[0] = textBox1.Text; //HEIGHT
                MEDICALdata[1] = textBox2.Text; //WEIGHT
                MEDICALdata[2] = textBox3.Text;//EYESIGHT
                MEDICALdata[3] = textBox4.Text;//BLOODGROUP..
                MEDICALdata[4] = biodata[10];
            }
            //code handling....
            update_class up = new update_class();
            up.update_record(biodata);
            up.update_medicalreord(MEDICALdata);

        }

        private void button4_Click(object sender, EventArgs e)
        {
       
            string[] history = new string[10];
            string id=textBox7.Text;
            sqlreturn s1 = new sqlreturn();
            history[0] = textBox7.Text;
           history[1] =s1.scalarReturn("select s_name from student_record where s_id="+id);
           history[2] = s1.scalarReturn("select s_fname from student_record where s_id=" + id);
           history[3] = s1.scalarReturn("select s_address from student_record where s_id=" + id);
           history[4] = s1.scalarReturn("select s_date_of_birth from student_record where s_id=" + id);
           history[5] = s1.scalarReturn("select s_class from student_record where s_id=" + id);
           history[6] = s1.scalarReturn("select s_contact from student_record where s_id=" + id);
           history[7] = s1.scalarReturn("select s_admission_date from student_record where s_id=" + id);
           history[8] = System.DateTime.Now.ToString();
           Deletion_CLASS d = new Deletion_CLASS();
           d.insertinto_history(history);
           Deletion_CLASS d1 = new Deletion_CLASS();
           d1.DELETE_DATA(id, "deleting_medical", "@m_s_id");
           d1.DELETE_DATA(id, "deleting_fees", "@f_s_id");
           Deletion_CLASS d2 = new Deletion_CLASS();
          
           d2.DELETE_DATA(id, "deleting_records", "@s_id");


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = true;

            }

            if (checkBox2.Checked == false)
            {
                button1.Enabled = true;
                button3.Enabled = true;
                button2.Enabled = false;

            }

        } //EVENT ENDING......




    }
}
