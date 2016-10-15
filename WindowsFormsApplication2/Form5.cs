using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        private string connect;
        private MySqlConnection conn;
        String personalaadharid, familyaadharid,relation,dependents,totalmembers;
        int submitClickCount =0,headFlag=0,depFlag=0;
        public Form5(String qs)
        {
            InitializeComponent();
            textBox1.Text = qs;
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "0", Value = "0" });
            comboBox1.Items.Add(new { Text = "1", Value = "1" });
            comboBox1.Items.Add(new { Text = "2", Value = "2" });
            comboBox1.Items.Add(new { Text = "3", Value = "3" });
            comboBox1.Items.Add(new { Text = "4", Value = "4" });
            comboBox1.Items.Add(new { Text = "5", Value = "5" });
            this.comboBox2.DisplayMember = "Text";
            this.comboBox2.ValueMember = "Value";
            comboBox2.Items.Add(new { Text = "Yes", Value = "Yes" });
            comboBox2.Items.Add(new { Text = "No", Value = "No" });
            this.comboBox4.DisplayMember = "Text";
            this.comboBox4.ValueMember = "Value";
            comboBox4.Items.Add(new { Text = "son", Value = "son" });
            comboBox4.Items.Add(new { Text = "daughter", Value = "daughter" });
            comboBox4.Items.Add(new { Text = "wife", Value = "wife" });
            comboBox4.Items.Add(new { Text = "mother", Value = "mother" });
            comboBox4.Items.Add(new { Text = "father", Value = "father" });
            comboBox4.Items.Add(new { Text = "brother", Value = "brother" });
            comboBox4.Items.Add(new { Text = "sister", Value = "sister" });
            comboBox4.Items.Add(new { Text = "son in-law", Value = "son in-law" });
            comboBox4.Items.Add(new { Text = "daughter in-law", Value = "daughter in-law" });
            comboBox4.Items.Add(new { Text = "mother in-law", Value = "mother in-law" });
            comboBox4.Items.Add(new { Text = "father in-law", Value = "father in-law" });
            comboBox4.Items.Add(new { Text = "brother in-law", Value = "brother in-law" });
            comboBox4.Items.Add(new { Text = "sister in-law", Value = "sister in-law" });
            this.comboBox5.DisplayMember = "Text";
            this.comboBox5.ValueMember = "Value";
            comboBox5.Items.Add(new { Text = "1", Value = "1" });
            comboBox5.Items.Add(new { Text = "2", Value = "2" });
            comboBox5.Items.Add(new { Text = "3", Value = "3" });
            comboBox5.Items.Add(new { Text = "4", Value = "4" });
            comboBox5.Items.Add(new { Text = "5", Value = "5" });
            comboBox5.Items.Add(new { Text = "6", Value = "6" });
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            Form3 form3 = new Form3();
            if (Application.OpenForms["Form3"] != null)
            {
                if ((Application.OpenForms["Form3"].Text).Equals("MSS Information Centre"))
                {
                    isOpen = true;
                }
                if (isOpen == true)
                {
                    form3.Focus();
                    this.Close();
                }
                else
                {
                    isOpen = true;
                    form3.Show();
                    form3.Focus();
                    //this.Close();
                }
            }//this.Close();
            else
            {
                form3.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            Form6 form6 = new Form6(textBox1.Text);
            if (Application.OpenForms["Form6"] != null)
            {
                if ((Application.OpenForms["Form6"].Text).Equals("MSS Information Centre"))
                {
                    isOpen = true;
                }
                if (isOpen == true)
                {
                    form6.Focus();
                    this.Close();
                }
                else
                {
                    isOpen = true;
                    form6.Show();
                    form6.Focus();
                    //this.Close();
                }
            }//this.Close();
            else
            {
                form6.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form1")
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                comboBox1.Enabled = true;
                comboBox4.Enabled = false;
                comboBox5.Enabled = true;
                comboBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox1.Enabled = false;
                comboBox4.Enabled = true;
                comboBox5.Enabled = false;
                comboBox2.Enabled = true;
            }
        }
        private void ConnectDB()
        {
            try
            {
                connect = "Server=rds-mysql-anandwan.ceyfcyxuedom.ap-south-1.rds.amazonaws.com;Port=3306;Database=anandwan;Uid=root;Pwd=anandwan";
                conn = new MySqlConnection(connect);
                conn.Open();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (submitClickCount == 0)
                {
                    submitClickCount = 1;
                    ConnectDB();
                    MySqlCommand cmdQuery = new MySqlCommand();
                    if (radioButton1.Checked == true)
                    {
                        headFlag = 1;
                        personalaadharid = textBox1.Text;
                        dependents = comboBox1.Text;
                        totalmembers = comboBox5.Text;
                        relation = "Self";
                        depFlag = 0;
                        cmdQuery.CommandText = "INSERT INTO family(aadharid,isHead,aadharidFamily,isDepend,relation,noofdep,totalmembers)" + "VALUES('" + personalaadharid + "','" + headFlag + "','" + personalaadharid + "','" + depFlag + "','" + relation + "','" + dependents + "','" + totalmembers + "')";
                        cmdQuery.Connection = conn;
                        cmdQuery.ExecuteNonQuery();
                        MessageBox.Show("Records saved successfully!");
                    }
                    else
                    {
                        headFlag = 0;
                        if (comboBox2.Text == "Yes")
                        {
                            depFlag = 1;
                        }
                        else
                        {
                            depFlag = 0;
                        }
                        personalaadharid = textBox1.Text;
                        familyaadharid = textBox2.Text;
                        relation = comboBox4.Text;
                        cmdQuery.CommandText = "INSERT INTO family(aadharid,isHead,aadharidFamily,isDepend,relation,noofdep,totalmembers)" + "VALUES('" + personalaadharid + "','" + headFlag + "','" + familyaadharid + "','" + depFlag + "','" + relation + "','" + dependents + "','" + totalmembers + "')";
                        cmdQuery.Connection = conn;
                        cmdQuery.ExecuteNonQuery();
                        MessageBox.Show("Records saved successfully!");
                    }

                }
            }
            catch (Exception)
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            
            comboBox1.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
        }
    }
}
