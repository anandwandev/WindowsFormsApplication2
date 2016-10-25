using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SearchBasicInfo : Form
    {
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        String whereclause;
        public SearchBasicInfo()
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
            AdminHome form4 = new AdminHome();
            if (Application.OpenForms["Form4"] != null)
            {
                if ((Application.OpenForms["Form4"].Text).Equals("MSS Information Centre"))
                {
                    isOpen = true;
                }
                if (isOpen == true)
                {
                    form4.Focus();
                    this.Close();
                }
                else
                {
                    isOpen = true;
                    form4.Show();
                    form4.Focus();
                    //this.Close();
                }
            }
        }
        private void ConnectDB()
        {
            try
            {
                connect = ConfigurationManager.AppSettings.Get("MySQLDBConnectionString");
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
                    mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person where Aadharid=" + @whereclause , conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person where ROUND(DATEDIFF(DateOfBirth,CURDATE())/365)=" + @whereclause , conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person where BloodGroup='" + @whereclause + "'", conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person where Gender='" + @whereclause + "'", conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person where Religion='" + @whereclause + "'", conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person where Caste='" + @whereclause + "'", conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person", conn);
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
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }
    }
}
