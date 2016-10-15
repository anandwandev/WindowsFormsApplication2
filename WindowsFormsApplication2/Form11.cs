using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form11 : Form
    {
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        String whereclause;
        int countreader = 0;
        public Form11()
        {
            InitializeComponent();
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "Aadhar ID", Value = "Aadhar ID" });
            comboBox1.Items.Add(new { Text = "Disability", Value = "Disability" });
            comboBox1.Items.Add(new { Text = "Disability (%)", Value = "Disability (%)" });
            comboBox1.Items.Add(new { Text = "Medical Condition", Value = "Medical Condition" });
            comboBox1.Items.Add(new { Text = "Other Medical Condition", Value = "Other Medical Condition" });
            comboBox1.Items.Add(new { Text = "All", Value = "All" });
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

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();
            whereclause = textBox1.Text;
           
                if(comboBox1.Text == "Aadhar ID")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',disabilitytype as 'type of disability',percent as 'disability (%)',medicalCondition as 'medical condition',otherCondition as 'other medical condition' from health where aadharid='" + @whereclause + "' ", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Disability")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',disabilitytype as 'type of disability',percent as 'disability (%)',medicalCondition as 'medical condition',otherCondition as 'other medical condition' from health where disabilitytype='"+@whereclause+"'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Disability (%)")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',disabilitytype as 'type of disability',percent as 'disability (%)',medicalCondition as 'medical condition',otherCondition as 'other medical condition' from health where percent='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text=="Medical Condition")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',disabilitytype as 'type of disability',percent as 'disability (%)',medicalCondition as 'medical condition',otherCondition as 'other medical condition' from health where medicalCondition='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text=="Other Medical Condition")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',disabilitytype as 'type of disability',percent as 'disability (%)',medicalCondition as 'medical condition',otherCondition as 'other medical condition' from health where otherCondition='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text=="All")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',disabilitytype as 'type of disability',percent as 'disability (%)',medicalCondition as 'medical condition',otherCondition as 'other medical condition'  from health", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
           
        }
    }
}
