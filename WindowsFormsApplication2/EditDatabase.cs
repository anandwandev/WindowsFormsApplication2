using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class EditDatabase : Form
    {
        string tablename,aadharid,attriname,attrivalue;
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        public EditDatabase()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            @aadharid = textBox1.Text;
            if (comboBox1.Text == "Basic Details")
            {
                mySqlDataAdapter = new MySqlDataAdapter("select FirstName as 'First name',MiddleName as 'Middle name',LastName as 'Surname',Aadharid as 'Aadhar ID',DateOfBirth as 'Date of birth',ROUND(DATEDIFF(DateOfBirth,CURDATE())/365) as 'Age (in years)',BloodGroup as 'Blood group',Gender as 'Gender',Religion as 'Religion',Caste as 'Caste' from Person where Aadharid=" + @aadharid , conn);
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
FROM FamilyDetails oqt where oqt.Aadharid=" + @aadharid;
                                mySqlDataAdapter = new MySqlDataAdapter(familydetailsquery, conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (comboBox1.Text == "Healthcare Details")
            {
                mySqlDataAdapter = new MySqlDataAdapter("select AadharId as 'Aadhar ID',OtherDisabilityType as 'Type of disability', DisabilityPercentage as 'Disability (%)',MedicalConditions as 'Medical conditions' from PersonHealthDetails where AadharId=" + @aadharid , conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if (comboBox1.Text == "Skill Details")
            {
                mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification where Aadharid=" + @aadharid , conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox2.DisplayMember = "Text";
            this.comboBox2.ValueMember = "Value";
            if (comboBox1.Text == "Basic Details")
            {
                comboBox2.Items.Add(new { Text = "First Name", Value = "FirstName" });
                comboBox2.Items.Add(new { Text = "Middle Name", Value = "MiddleName" });
                comboBox2.Items.Add(new { Text = "Surname", Value = "LastName" });
                comboBox2.Items.Add(new { Text = "Aadharid", Value = "AadharId" });
                comboBox2.Items.Add(new { Text = "Birth Date", Value = "DateOfBirth" });
                comboBox2.Items.Add(new { Text = "Blood Group", Value = "BloodGroup" });
                comboBox2.Items.Add(new { Text = "Gender", Value = "Gender" });
                comboBox2.Items.Add(new { Text = "Religion", Value = "Religion" });
                comboBox2.Items.Add(new { Text = "Caste", Value = "Caste" });
            }
            else if (comboBox1.Text == "Family Details")
            {
                comboBox2.Items.Add(new { Text = "Family ID", Value = "FamilyHeadId" });
                comboBox2.Items.Add(new { Text = "Aadharid", Value = "AadharId" });
                comboBox2.Items.Add(new { Text = "Relation", Value = "RelationToFamilyHead" });
            }
            else if (comboBox1.Text == "Healthcare Details")
            {
                comboBox2.Items.Add(new { Text = "Aadharid", Value = "AadharId" });
                comboBox1.Items.Add(new { Text = "Disability", Value = "OtherDisabilityType" });
                comboBox1.Items.Add(new { Text = "Disability (%)", Value = "DisabilityPercentage" });
                comboBox1.Items.Add(new { Text = "Medical Condition", Value = "MedicalConditions" });
            }
            else if (comboBox1.Text == "Skill Details")
            {
                comboBox2.Items.Add(new { Text = "Aadharid", Value = "AadharId" });
                comboBox2.Items.Add(new { Text = "Educational Degree", Value = "HighestQualification" });
                comboBox2.Items.Add(new { Text = "Other Qualification", Value = "ProfessionalCourses" });
                comboBox2.Items.Add(new { Text = "Work Experience", Value = "MSSWorkExperience" });
                comboBox2.Items.Add(new { Text = "Department", Value = "Department" });
                comboBox2.Items.Add(new { Text = "Work Type", Value = "TypeOfWork" });
                comboBox2.Items.Add(new { Text = "Salary", Value = "Salary" });
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
                tablename = "Person";
            }
            else if (comboBox1.Text == "Family Details")
            {
                tablename = "FamilyDetails";
            }
            else if (comboBox1.Text == "Healthcare Details")
            {
                tablename = "PersonHealthDetails";
            }
            else if (comboBox1.Text == "Skill Details")
            {
                tablename = "Qualification";
            }
            if (comboBox2.Text == "First Name")
            {
                attriname = "FirstName";
            }
            if (comboBox2.Text == "Middle Name")
            {
                attriname = "MiddleName";
            }
            if (comboBox2.Text == "Surname")
            {
                attriname = "LastName";
            }
            if (comboBox2.Text == "Aadharid")
            {
                attriname = "AadharId";
            }
            if (comboBox2.Text == "Birth Date")
            {
                attriname = "DateOfBirth";
            }
            if (comboBox2.Text == "Blood Group")
            {
                attriname = "BloodGroup";
            }
            if (comboBox2.Text == "Gender")
            {
                attriname = "Gender";
            }
            if (comboBox2.Text == "Religion")
            {
                attriname = "Religion";
            }
            if (comboBox2.Text == "Caste")
            {
                attriname = "Caste";
            }
            if (comboBox2.Text == "Family Head ID")
            {
                attriname = "FamilyHeadId";
            }
            if (comboBox2.Text == "Relation")
            {
                attriname = "RelationToFamilyHead";
            }
            if (comboBox2.Text == "Disability")
            {
                attriname = "OtherDisabilityType";
            }
            if (comboBox2.Text == "Disability (%)")
            {
                attriname = "DisabilityPercentage";
            }
            if (comboBox2.Text == "Medical Condition")
            {
                attriname = "MedicalConditions";
            }
            if (comboBox2.Text == "Educational Degree")
            {
                attriname = "HighestQualification";
            }
            if (comboBox2.Text == "Other Qualification")
            {
                attriname = "ProfessionalCourses";
            }
            if (comboBox2.Text == "Work Experience")
            {
                attriname = "MSSWorkExperience";
            }
            if (comboBox2.Text == "Department")
            {
                attriname = "Department";
            }
            if (comboBox2.Text == "Work Type")
            {
                attriname = "TypeOfWork";
            }
            if (comboBox2.Text == "Salary")
            {
                attriname = "Salary";
            }
            cmdQuery.CommandText = "UPDATE "+tablename+" SET "+attriname+"='"+attrivalue+"' WHERE AadharId="+aadharid;
            cmdQuery.Connection = conn;
            cmdQuery.ExecuteNonQuery();
            MessageBox.Show("Record Edited Successfully");
            conn.Close();
        }
    }
}
