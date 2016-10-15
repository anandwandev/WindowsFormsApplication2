using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form9 : Form
    {
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        String whereclause;
        public Form9()
        {
            InitializeComponent();
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "Aadharid", Value = "Aadharid" });
            comboBox1.Items.Add(new { Text = "Age", Value = "Age" });
            comboBox1.Items.Add(new { Text = "Blood Group", Value = "Blood Group" });
            comboBox1.Items.Add(new { Text = "Gender", Value = "Gender" });
            comboBox1.Items.Add(new { Text = "Religion", Value = "Religion" });
            comboBox1.Items.Add(new { Text = "Caste", Value = "Caste" });
            comboBox1.Items.Add(new { Text = "All", Value = "All" });
        }
        private void button7_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            Form8 form8 = new Form8();
            if (Application.OpenForms["Form8"] != null)
            {
                if ((Application.OpenForms["Form8"].Text).Equals("MSS Information Centre"))
                {
                    isOpen = true;
                }
                if (isOpen == true)
                {
                    form8.Focus();
                    this.Close();
                }
                else
                {
                    isOpen = true;
                    form8.ShowDialog();
                    form8.Focus();
                    //this.Close();
                }
            }//this.Close();
            else
            {
                form8.ShowDialog();
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
        private void button1_Click(object sender, EventArgs e)
        {
           
            ConnectDB();
            int countreader=0;
            try
            {
                if (comboBox1.Text == "Aadharid")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person where aadharid='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label3.Text = countreader.ToString();        
                    }
                }
                else if (comboBox1.Text == "Age")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person where age='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label3.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Blood Group")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person where bloodgp='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label3.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Gender")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person where gender='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label3.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Religion")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person where religion='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label3.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Caste")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person where caste='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label3.Text = countreader.ToString();
                    }
                }
                else if(comboBox1.Text=="All")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label3.Text = countreader.ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
