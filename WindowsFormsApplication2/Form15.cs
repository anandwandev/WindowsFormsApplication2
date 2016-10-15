using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form15 : Form
    {
        string aadharid;
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        public Form15()
        {
            InitializeComponent();
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "Basic Details", Value = "Basic Details" });
            comboBox1.Items.Add(new { Text = "Family Details", Value = "Family Details" });
            comboBox1.Items.Add(new { Text = "Healthcare Details", Value = "Healthcare Details" });
            comboBox1.Items.Add(new { Text = "Skill Details", Value = "Skill Details" });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            Form13 form13 = new Form13();
            if (Application.OpenForms["Form13"] != null)
            {
                if ((Application.OpenForms["Form13"].Text).Equals("MSS Information Centre"))
                {
                    isOpen = true;
                }
                if (isOpen == true)
                {
                    form13.Focus();
                    this.Close();
                }
                else
                {
                    isOpen = true;
                    form13.ShowDialog();
                    form13.Focus();
                    //this.Close();
                }
            }//this.Close();
            else
            {
                form13.ShowDialog();
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
            try
            {
                if (comboBox1.Text == "Basic Details")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
                else if (comboBox1.Text == "Family Details")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select isHead as 'Family Head',aadharid as 'aadhar ID',aadharidFamily as '(Family) aadhar ID',noofchildren as 'children',noofseniormem as 'earning members',noofSC as 'senior citizens',relation as 'relation(to family head)',totalmembers as 'total members' from family", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
                else if (comboBox1.Text == "Health Details")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',disabilitytype as 'type of disability',percent as 'disability (%)',medicalCondition as 'medical condition',otherCondition as 'other medical condition' from health", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
                else if (comboBox1.Text == "Skill Details")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',degree as 'education',profdegree as 'extra courses',workexp as 'work experience',department as 'working department',typeofwork as 'type of work',salary as 'salary' from qualifications", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred!");
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
        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();
            try
            {
                MySqlCommand cmdQuery1 = new MySqlCommand();
                MySqlCommand cmdQuery2 = new MySqlCommand();
                MySqlCommand cmdQuery3 = new MySqlCommand();
                MySqlCommand cmdQuery4 = new MySqlCommand();
                aadharid = textBox1.Text;
                cmdQuery1.CommandText = "DELETE FROM qualifications WHERE aadharid='" + aadharid + "'";
                cmdQuery1.Connection = conn;
                cmdQuery1.ExecuteNonQuery();
                cmdQuery2.CommandText = "DELETE FROM health WHERE aadharid='" + aadharid + "'";
                cmdQuery2.Connection = conn;
                cmdQuery2.ExecuteNonQuery();
                cmdQuery3.CommandText = "DELETE FROM family WHERE aadharid='" + aadharid + "'";
                cmdQuery3.Connection = conn;
                cmdQuery3.ExecuteNonQuery();
                cmdQuery4.CommandText = "DELETE FROM person WHERE aadharid='" + aadharid + "'";
                cmdQuery4.Connection = conn;
                cmdQuery4.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully !!!");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
