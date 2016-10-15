using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form14 : Form
    {
        string tablename,aadharid,attriname,attrivalue;
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        public Form14()
        {
            InitializeComponent();
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "Basic Details", Value = "Basic Details" });
            comboBox1.Items.Add(new { Text = "Family Details", Value = "Family Details" });
            comboBox1.Items.Add(new { Text = "Healthcare Details", Value = "Healthcare Details" });
            comboBox1.Items.Add(new { Text = "Skill Details", Value = "Skill Details" });
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
            ConnectDB();
            if (comboBox1.Text == "Basic Details")
            {
                mySqlDataAdapter = new MySqlDataAdapter("select fname as 'first name',mname as 'middle name',lname as 'surname',aadharid as 'aadharID',bdate as 'date of birth',age as 'age',bloodgp as 'blood group',gender as 'gender',religion as 'religion',caste as 'caste' from person where aadharid='" + @aadharid + "'", conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (comboBox1.Text == "Family Details")
            {
                mySqlDataAdapter = new MySqlDataAdapter("select isHead as 'Family Head',aadharid as 'aadhar ID',aadharidFamily as '(Family) aadhar ID',noofchildren as 'children',noofseniormem as 'earning members',noofSC as 'senior citizens',relation as 'relation(to family head)',totalmembers as 'total members' from family where aadharid='" + @aadharid + "'", conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (comboBox1.Text == "Health Details")
            {
                mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',disabilitytype as 'type of disability',percent as 'disability (%)',medicalCondition as 'medical condition',otherCondition as 'other medical condition'  from health where aadharid='" + @aadharid + "'", conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (comboBox1.Text == "Skill Details")
            {
                mySqlDataAdapter = new MySqlDataAdapter("select aadharid as 'aadhar ID',degree as 'education',qualification as 'extra courses',workexp as 'work experience',department as 'working department',typeofwork as 'type of work',salary as 'salary' from qualifications where aadharid='" + @aadharid + "'", conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox2.DisplayMember = "Text";
            this.comboBox2.ValueMember = "Value";
            if (comboBox1.Text == "Basic Details")
            {
                comboBox2.Items.Add(new { Text = "First Name", Value = "fname" });
                comboBox2.Items.Add(new { Text = "Middle Name", Value = "mname" });
                comboBox2.Items.Add(new { Text = "Surname", Value = "lname" });
                comboBox2.Items.Add(new { Text = "Aadharid", Value = "aadharid" });
                comboBox2.Items.Add(new { Text = "Birth Date", Value = "bdate" });
                comboBox2.Items.Add(new { Text = "Age", Value = "age" });
                comboBox2.Items.Add(new { Text = "Blood Group", Value = "bloodgp" });
                comboBox2.Items.Add(new { Text = "Gender", Value = "gender" });
                comboBox2.Items.Add(new { Text = "Religion", Value = "religion" });
                comboBox2.Items.Add(new { Text = "Caste", Value = "caste" });
            }
            else if (comboBox1.Text == "Family Details")
            {
                comboBox2.Items.Add(new { Text = "Family Head (Yes/No)", Value = "isHead" });
                comboBox2.Items.Add(new { Text = "Family ID", Value = "aadharidFamily" });
                comboBox2.Items.Add(new { Text = "Aadharid", Value = "aadharid" });
                comboBox2.Items.Add(new { Text = "Children", Value = "noofchildren" });
                comboBox2.Items.Add(new { Text = "Senior Citizens", Value = "noofSC" });
                comboBox2.Items.Add(new { Text = "Earning Members", Value = "noofseniormem" });
                comboBox2.Items.Add(new { Text = "Total Members", Value = "totalmembers" });
                comboBox2.Items.Add(new { Text = "Relation", Value = "relation" });
            }
            else if (comboBox1.Text == "Healthcare Details")
            {
                comboBox2.Items.Add(new { Text = "Aadharid", Value = "aadharid" });
                comboBox1.Items.Add(new { Text = "Disability", Value = "disabilitytype" });
                comboBox1.Items.Add(new { Text = "Disability (%)", Value = "percent" });
                comboBox1.Items.Add(new { Text = "Medical Condition", Value = "medicalCondition" });
                comboBox1.Items.Add(new { Text = "Other Medical Condition", Value = "otherCondition" });
            }
            else if (comboBox1.Text == "Skill Details")
            {
                comboBox2.Items.Add(new { Text = "Aadharid", Value = "aadharid" });
                comboBox2.Items.Add(new { Text = "Educational Degree", Value = "degree" });
                comboBox2.Items.Add(new { Text = "Other Qualification", Value = "qualification" });
                comboBox2.Items.Add(new { Text = "Work Experience", Value = "workexp" });
                comboBox2.Items.Add(new { Text = "Department", Value = "department" });
                comboBox2.Items.Add(new { Text = "Work Type", Value = "typeofwork" });
                comboBox2.Items.Add(new { Text = "Salary", Value = "salary" });
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
            MySqlCommand cmdQuery = new MySqlCommand();
            aadharid = textBox1.Text;
            attrivalue = textBox2.Text;
            if (comboBox1.Text == "Basic Details")
            {
                tablename = "person";
            }
            else if (comboBox1.Text == "Family Details")
            {
                tablename = "family";
            }
            else if (comboBox1.Text == "Healthcare Details")
            {
                tablename = "health";
            }
            else if (comboBox1.Text == "Skill Details")
            {
                tablename = "qualifications";
            }
            if (comboBox2.Text == "First Name")
            {
                attriname = "fname";
            }
            if (comboBox2.Text == "Middle Name")
            {
                attriname = "mname";
            }
            if (comboBox2.Text == "Surname")
            {
                attriname = "lname";
            }
            if (comboBox2.Text == "Aadharid")
            {
                attriname = "aadharid";
            }
            if (comboBox2.Text == "Birth Date")
            {
                attriname = "bdate";
            }
            if (comboBox2.Text == "Age")
            {
                attriname = "age";
            }
            if (comboBox2.Text == "Blood Group")
            {
                attriname = "bloodgp";
            }
            if (comboBox2.Text == "Gender")
            {
                attriname = "gender";
            }
            if (comboBox2.Text == "Religion")
            {
                attriname = "religion";
            }
            if (comboBox2.Text == "Caste")
            {
                attriname = "caste";
            }
            if (comboBox2.Text == "Family Head (Yes/No)")
            {
                attriname = "isHead";
            }
            if (comboBox2.Text == "Family ID")
            {
                attriname = "aadharidFamily";
            }
            if (comboBox2.Text == "Children")
            {
                attriname = "noofchildren";
            }
            if (comboBox2.Text == "Senior Citizens")
            {
                attriname = "noofSC";
            }
            if (comboBox2.Text == "Earning Members")
            {
                attriname = "noofseniormem";
            }
            if (comboBox2.Text == "Total Members")
            {
                attriname = "totalmembers";
            }
            if (comboBox2.Text == "Relation")
            {
                attriname = "relation";
            }
            if (comboBox2.Text == "Disability")
            {
                attriname = "disabilitytype";
            }
            if (comboBox2.Text == "Disability (%)")
            {
                attriname = "percent";
            }
            if (comboBox2.Text == "Medical Condition")
            {
                attriname = "medicalCondition";
            }
            if (comboBox2.Text == "Other Medical Condition")
            {
                attriname = "otherCondition";
            }
            if (comboBox2.Text == "Educational Degree")
            {
                attriname = "degree";
            }
            if (comboBox2.Text == "Other Qualification")
            {
                attriname = "qualification";
            }
            if (comboBox2.Text == "Work Experience")
            {
                attriname = "workexp";
            }
            if (comboBox2.Text == "Department")
            {
                attriname = "department";
            }
            if (comboBox2.Text == "Work Type")
            {
                attriname = "typepfwork";
            }
            if (comboBox2.Text == "Salary")
            {
                attriname = "salary";
            }
            cmdQuery.CommandText = "UPDATE "+tablename+" SET "+attriname+"='"+attrivalue+"' WHERE aadharid='"+aadharid+"'";
            cmdQuery.Connection = conn;
            cmdQuery.ExecuteNonQuery();
            MessageBox.Show("Record Edited Successfully");
            conn.Close();
        }
    }
}
