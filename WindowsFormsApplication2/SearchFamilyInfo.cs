using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SearchFamilyInfo : Form
    {
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        String whereclause;
        int countreader = 0;
        public SearchFamilyInfo()
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
                    mySqlDataAdapter = new MySqlDataAdapter("select (oqt.AadharId=oqt.FamilyHeadId) as 'Is a Family Head?',oqt.AadharId as 'Aadhar ID',oqt.FamilyHeadId as '(Family Head) Aadhar ID',oqt.IsFinanciallyDependent as 'Is a financially dependent?',oqt.RelationToFamilyHead as 'Relation to family head',(SELECT COUNT(*) FROM FamilyDetails iqt where iqt.FamilyHeadId=oqt.FamilyHeadId AND iqt.AadharId!=iqt.FamilyHeadId AND iqt.IsFinanciallyDependent=1) as 'Number of Dependents',(SELECT COUNT(*) FROM FamilyDetails iqt2 where iqt2.FamilyHeadId=oqt.FamilyHeadId) as 'Total members' from FamilyDetails oqt where oqt.Aadharid=" + @whereclause, conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select (oqt.AadharId=oqt.FamilyHeadId) as 'Is a Family Head?',oqt.AadharId as 'Aadhar ID',oqt.FamilyHeadId as '(Family Head) Aadhar ID',oqt.IsFinanciallyDependent as 'Is a financially dependent?',oqt.RelationToFamilyHead as 'Relation to family head',(SELECT COUNT(*) FROM FamilyDetails iqt where iqt.FamilyHeadId=oqt.FamilyHeadId AND iqt.AadharId!=iqt.FamilyHeadId AND iqt.IsFinanciallyDependent=1) as 'Number of Dependents',(SELECT COUNT(*) FROM FamilyDetails iqt2 where iqt2.FamilyHeadId=oqt.FamilyHeadId) as 'Total members' from FamilyDetails oqt where oqt.Aadharid=oqt.FamilyHeadId" , conn);
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
                //Family head assumed to be financially independent.
                    mySqlDataAdapter = new MySqlDataAdapter("select (oqt.AadharId=oqt.FamilyHeadId) as 'Is a Family Head?',oqt.AadharId as 'Aadhar ID',oqt.FamilyHeadId as '(Family Head) Aadhar ID',oqt.IsFinanciallyDependent as 'Is a financially dependent?',oqt.RelationToFamilyHead as 'Relation to family head',(SELECT COUNT(*) FROM FamilyDetails iqt where iqt.FamilyHeadId=oqt.FamilyHeadId AND iqt.AadharId!=iqt.FamilyHeadId AND iqt.IsFinanciallyDependent=1) as 'Number of Dependents',(SELECT COUNT(*) FROM FamilyDetails iqt2 where iqt2.FamilyHeadId=oqt.FamilyHeadId) as 'Total members' from FamilyDetails oqt where oqt.FamilyHeadId=" + @whereclause , conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select (oqt.AadharId=oqt.FamilyHeadId) as 'Is a Family Head?',oqt.AadharId as 'Aadhar ID',oqt.FamilyHeadId as '(Family Head) Aadhar ID',oqt.IsFinanciallyDependent as 'Is a financially dependent?',oqt.RelationToFamilyHead as 'Relation to family head',(SELECT COUNT(*) FROM FamilyDetails iqt where iqt.FamilyHeadId=oqt.FamilyHeadId AND iqt.AadharId!=iqt.FamilyHeadId AND iqt.IsFinanciallyDependent=1) as 'Number of Dependents',(SELECT COUNT(*) FROM FamilyDetails iqt2 where iqt2.FamilyHeadId=oqt.FamilyHeadId) as 'Total members' from FamilyDetails oqt where iqt.IsFinanciallyDependent=" + @whereclause , conn);
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
                    mySqlDataAdapter = new MySqlDataAdapter("select (oqt.AadharId=oqt.FamilyHeadId) as 'Is a Family Head?',oqt.AadharId as 'Aadhar ID',oqt.FamilyHeadId as '(Family Head) Aadhar ID',oqt.IsFinanciallyDependent as 'Is a financially dependent?',oqt.RelationToFamilyHead as 'Relation to family head',(SELECT COUNT(*) FROM FamilyDetails iqt where iqt.FamilyHeadId=oqt.FamilyHeadId AND iqt.AadharId!=iqt.FamilyHeadId AND iqt.IsFinanciallyDependent=1) as 'Number of Dependents',(SELECT COUNT(*) FROM FamilyDetails iqt2 where iqt2.FamilyHeadId=oqt.FamilyHeadId) as 'Total members' from FamilyDetails oqt", conn);
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
