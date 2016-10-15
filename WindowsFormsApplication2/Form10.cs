using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form10 : Form
    {
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        String whereclause;
        int countreader = 0;
        public Form10()
        {
            InitializeComponent();
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "Aadhar ID", Value = "Aadhar ID" });
            comboBox1.Items.Add(new { Text = "Family Head", Value = "Family Head" });
            comboBox1.Items.Add(new { Text = "Family ID", Value = "Family ID" });
            comboBox1.Items.Add(new { Text = "Dependents", Value = "Dependents" });
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

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();
            
                if (comboBox1.Text == "Aadhar ID")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select isHead as 'Is a Family Head?',aadharid as 'aadhar ID',aadharidFamily as '(Family) aadhar ID',isDepend as 'Is a dependent?',relation as 'relation(to family head)',noofdep as 'No. of Dependents',totalmembers as 'total members' from family where aadharid='" + @whereclause + "' ", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Family Head")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select isHead as 'Is a Family Head?',aadharid as 'aadhar ID',aadharidFamily as '(Family) aadhar ID',isDepend as 'Is a dependent?',relation as 'relation(to family head)',noofdep as 'No. of Dependents',totalmembers as 'total members' from family where isHead='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Family ID")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select isHead as 'Is a Family Head?',aadharid as 'aadhar ID',aadharidFamily as '(Family) aadhar ID',isDepend as 'Is a dependent?',relation as 'relation(to family head)',noofdep as 'No. of Dependents',totalmembers as 'total members' from family where aadharidFamily='" + @whereclause + "' ", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Dependents")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select isHead as 'Is a Family Head?',aadharid as 'aadhar ID',aadharidFamily as '(Family) aadhar ID',isDepend as 'Is a dependent?',relation as 'relation(to family head)',noofdep as 'No. of Dependents',totalmembers as 'total members' from family where isDepend='" + @whereclause + "' ", conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select isHead as 'Is a Family Head?',aadharid as 'aadhar ID',aadharidFamily as '(Family) aadhar ID',isDepend as 'Is a dependent?',relation as 'relation(to family head)',noofdep as 'No. of Dependents',totalmembers as 'total members' from family", conn);
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

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
