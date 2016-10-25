using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class DeleteDBRecords : Form
    {
        string aadharid;
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        public DeleteDBRecords()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            try
            {
                if (comboBox1.Text == "Basic Details")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
                else if (comboBox1.Text == "Family Details")
                {
                    //TODO: move these values to config
                    var maleSeniorCitizenAgeLimit = 65;
                    var femaleSeniorCitizenAgeLimit = 60;
                    //mySqlDataAdapter = new MySqlDataAdapter("select ,noofchildren as 'children',noofseniormem as 'earning members',noofSC as 'senior citizens',relation as 'relation(to family head)',totalmembers as 'total members' from family where aadharid='" + @aadharid + "'", conn);
                    string familydetailsquery = @"select (oqt.AadharId=oqt.FamilyHeadId) as 'Is a Family Head?', oqt.AadharId as 'Aadhar ID',oqt.FamilyHeadId as '(Family Head) Aadhar ID',
(Select COUNT(*) FROM FamilyDetails iqfdt Inner Join Person iqpt ON iqfdt.AadharId = iqpt.AadharId where iqfdt.FamilyHeadId = oqt.FamilyHeadId AND(ROUND(DATEDIFF(iqpt.DateOfBirth, CURDATE()) / 365) < 18) ) as 'No. of Childern in Family',
(Select COUNT(*) FROM FamilyDetails iqfdt
Inner Join Person iqpt ON iqfdt.AadharId = iqpt.AadharId
where iqfdt.FamilyHeadId = oqt.FamilyHeadId
AND((
(ROUND(DATEDIFF(iqpt.DateOfBirth, CURDATE()) / 365) > " + femaleSeniorCitizenAgeLimit + @")
AND iqpt.Gender = 'female') ||
(
(ROUND(DATEDIFF(iqpt.DateOfBirth, CURDATE()) / 365) > " + maleSeniorCitizenAgeLimit + @")
 AND iqpt.Gender = 'Male') )) as 'No. of Senior citizens in Family',
(SELECT COUNT(*) FROM FamilyDetails iqt where iqt.FamilyHeadId = oqt.FamilyHeadId AND iqt.IsFinanciallyDependent = 0) as 'Number of Earning Members',
oqt.IsFinanciallyDependent as 'Is a financially dependent?',oqt.RelationToFamilyHead as 'Relation to family head',
(SELECT COUNT(*) FROM FamilyDetails iqt where iqt.FamilyHeadId = oqt.FamilyHeadId AND iqt.AadharId != iqt.FamilyHeadId AND iqt.IsFinanciallyDependent = 1) as 'Number of Dependents',
(SELECT COUNT(*) FROM FamilyDetails iqt2 where iqt2.FamilyHeadId = oqt.FamilyHeadId) as 'Total members'
FROM FamilyDetails oqt";
                    mySqlDataAdapter = new MySqlDataAdapter(familydetailsquery, conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
                else if (comboBox1.Text == "Health Details")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select AadharId as 'Aadhar ID',OtherDisabilityType as 'Type of disability', DisabilityPercentage as 'Disability (%)',MedicalConditions as 'Medical conditions' from PersonHealthDetails", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
                else if (comboBox1.Text == "Skill Details")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification", conn);
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
                connect = "Server=localhost;Port=3306;Database=anandwantest;Uid=root;Pwd=root123";
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
                cmdQuery1.CommandText = "DELETE FROM Qualification WHERE Aadharid='" + aadharid + "'";
                cmdQuery1.Connection = conn;
                cmdQuery1.ExecuteNonQuery();
                cmdQuery2.CommandText = "DELETE FROM PersonHealthDetails WHERE Aadharid='" + aadharid + "'";
                cmdQuery2.Connection = conn;
                cmdQuery2.ExecuteNonQuery();
                cmdQuery3.CommandText = "DELETE FROM FamilyDetails WHERE Aadharid='" + aadharid + "'";
                cmdQuery3.Connection = conn;
                cmdQuery3.ExecuteNonQuery();
                cmdQuery4.CommandText = "DELETE FROM Person WHERE Aadharid='" + aadharid + "'";
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
