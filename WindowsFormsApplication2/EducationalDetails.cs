using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class EducationalDetails : Form
    {
        private string connect;
        private MySqlConnection conn;
        int submitClickCount = 0;
        String degree,course,department,worktype;
        int personalaadharid, workexp, salary;

        private void button3_Click(object sender, EventArgs e)
        {
            string certificatefilename;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                certificatefilename = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            HealthcareDetails form6 = new HealthcareDetails(textBox1.Text);
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
            }
            //this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public EducationalDetails(String qs)
        {
            InitializeComponent();
            textBox1.Text = qs;
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "SSC Appeared", Value = "SSC Appeared" });
            comboBox1.Items.Add(new { Text = "SSC Completed", Value = "SSC Completed" });
            comboBox1.Items.Add(new { Text = "HSC Appeared", Value = "HSC Appeared" });
            comboBox1.Items.Add(new { Text = "HSC Completed", Value = "HSC Completed" });
            comboBox1.Items.Add(new { Text = "Science UG", Value = "Science UG" });
            comboBox1.Items.Add(new { Text = "Science PG", Value = "Science PG" });
            comboBox1.Items.Add(new { Text = "Arts UG", Value = "Arts UG" });
            comboBox1.Items.Add(new { Text = "Arts PG", Value = "Arts PG" });
            comboBox1.Items.Add(new { Text = "Commerce UG", Value = "Commerce UG" });
            comboBox1.Items.Add(new { Text = "Commerce PG", Value = "Commerce PG" });
            comboBox1.Items.Add(new { Text = "Medical Science UG", Value = "Medical Science UG" });
            comboBox1.Items.Add(new { Text = "Medical Science PG", Value = "Medical Science PG" });
            comboBox1.Items.Add(new { Text = "Engineering UG", Value = "Engineering UG" });
            comboBox1.Items.Add(new { Text = "Engineering PG", Value = "Engineering PG" });
            comboBox1.Items.Add(new { Text = "Science UG", Value = "Science UG Appeared" });
            comboBox1.Items.Add(new { Text = "Science PG", Value = "Science PG Appeared" });
            comboBox1.Items.Add(new { Text = "Arts UG", Value = "Arts UG Appeared" });
            comboBox1.Items.Add(new { Text = "Arts PG", Value = "Arts PG Appeared" });
            comboBox1.Items.Add(new { Text = "Commerce UG", Value = "Commerce UG Appeared" });
            comboBox1.Items.Add(new { Text = "Commerce PG", Value = "Commerce PG Appeared" });
            comboBox1.Items.Add(new { Text = "Medical Science UG", Value = "Medical Science UG Appeared" });
            comboBox1.Items.Add(new { Text = "Medical Science PG", Value = "Medical Science PG Appeared" });
            comboBox1.Items.Add(new { Text = "Engineering UG", Value = "Engineering UG Appeared" });
            comboBox1.Items.Add(new { Text = "Engineering PG", Value = "Engineering PG Appeared" });
            comboBox1.Items.Add(new { Text = "NA", Value = "NA" });
            this.comboBox2.DisplayMember = "Text";
            this.comboBox2.ValueMember = "Value";
            comboBox2.Items.Add(new { Text = "Metal Fabrication", Value = "Metal Fabrication" });
            comboBox2.Items.Add(new { Text = "Powerloom ", Value = "Powerloom " });
            comboBox2.Items.Add(new { Text = "Handloom", Value = "Handloom" });
            comboBox2.Items.Add(new { Text = "Handicrafts (Posters)", Value = "Handicrafts (Posters)" });
            comboBox2.Items.Add(new { Text = "Wood-Art", Value = "Wood-Art" });
            comboBox2.Items.Add(new { Text = "Printing Press", Value = "Printing Press" });
            comboBox2.Items.Add(new { Text = "Electric Department", Value = "Electrical Department" });
            comboBox2.Items.Add(new { Text = "Carpet Manufacturing", Value = "Carpet Manufacturing" });
            comboBox2.Items.Add(new { Text = "Bag and Cushion Manufacturing ", Value = "Bag and Cushion Manufacturing " });
            comboBox2.Items.Add(new { Text = "Leather Footwear", Value = "Leather Footwear" });
            comboBox2.Items.Add(new { Text = "Cloth Processing", Value = "Cloth Processing" });
            comboBox2.Items.Add(new { Text = "Carpentry", Value = "Carpentry" });
            comboBox2.Items.Add(new { Text = "Handicrafts (Greetings)", Value = "Handicrafts (Greetings)" });
            comboBox2.Items.Add(new { Text = "Mega Kitchen", Value = "Mega Kitchen" });
            comboBox2.Items.Add(new { Text = "Goonj Department", Value = "Goonj Department" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });
            comboBox2.Items.Add(new { Text = "", Value = "" });

            this.comboBox5.DisplayMember = "Text";
            this.comboBox5.ValueMember = "Value";
            comboBox5.Items.Add(new { Text = "0", Value = "0" });
            comboBox5.Items.Add(new { Text = "1", Value = "1" });
            comboBox5.Items.Add(new { Text = "2", Value = "2" });
            comboBox5.Items.Add(new { Text = "3", Value = "3" });
            comboBox5.Items.Add(new { Text = "4", Value = "4" });
            comboBox5.Items.Add(new { Text = "5", Value = "5" });
            comboBox5.Items.Add(new { Text = "6", Value = "6" });
            comboBox5.Items.Add(new { Text = "7", Value = "7" });
            comboBox5.Items.Add(new { Text = "8", Value = "8" });
            comboBox5.Items.Add(new { Text = "9", Value = "9" });
            comboBox5.Items.Add(new { Text = "10", Value = "10" });
            comboBox5.Items.Add(new { Text = "11", Value = "11" });
            comboBox5.Items.Add(new { Text = "12", Value = "12" });
            comboBox5.Items.Add(new { Text = "13", Value = "13" });
            comboBox5.Items.Add(new { Text = "14", Value = "14" });
            comboBox5.Items.Add(new { Text = "15", Value = "15" });
            comboBox5.Items.Add(new { Text = "16", Value = "16" });
            comboBox5.Items.Add(new { Text = "17", Value = "17" });
            comboBox5.Items.Add(new { Text = "18", Value = "18" });
            comboBox5.Items.Add(new { Text = "19", Value = "19" });
            comboBox5.Items.Add(new { Text = "20", Value = "20" });
            comboBox5.Items.Add(new { Text = "21", Value = "21" });
            comboBox5.Items.Add(new { Text = "22", Value = "22" });
            comboBox5.Items.Add(new { Text = "23", Value = "23" });
            comboBox5.Items.Add(new { Text = "24", Value = "24" });
            comboBox5.Items.Add(new { Text = "25", Value = "25" });
            comboBox5.Items.Add(new { Text = "26", Value = "26" });
            comboBox5.Items.Add(new { Text = "27", Value = "27" });
            comboBox5.Items.Add(new { Text = "28", Value = "28" });
            comboBox5.Items.Add(new { Text = "29", Value = "29" });
            comboBox5.Items.Add(new { Text = "30", Value = "30" });
            comboBox5.Items.Add(new { Text = "31", Value = "31" });
            comboBox5.Items.Add(new { Text = "32", Value = "32" });
            comboBox5.Items.Add(new { Text = "33", Value = "33" });
            comboBox5.Items.Add(new { Text = "34", Value = "34" });
            comboBox5.Items.Add(new { Text = "35", Value = "35" });
            comboBox5.Items.Add(new { Text = "36", Value = "36" });
            comboBox5.Items.Add(new { Text = "37", Value = "37" });
            comboBox5.Items.Add(new { Text = "38", Value = "38" });
            comboBox5.Items.Add(new { Text = "39", Value = "39" });
            comboBox5.Items.Add(new { Text = "40", Value = "40" });
            comboBox5.Items.Add(new { Text = "41", Value = "41" });
            comboBox5.Items.Add(new { Text = "42", Value = "42" });
            comboBox5.Items.Add(new { Text = "43", Value = "43" });
            comboBox5.Items.Add(new { Text = "44", Value = "44" });
            comboBox5.Items.Add(new { Text = "45", Value = "45" });
            comboBox5.Items.Add(new { Text = "46", Value = "46" });
            comboBox5.Items.Add(new { Text = "47", Value = "47" });
            comboBox5.Items.Add(new { Text = "48", Value = "48" });
            comboBox5.Items.Add(new { Text = "49", Value = "49" });
            comboBox5.Items.Add(new { Text = "50", Value = "50" });
            this.comboBox6.DisplayMember = "Text";
            this.comboBox6.ValueMember = "Value";
            comboBox6.Items.Add(new { Text = "0", Value = "0" });
            comboBox6.Items.Add(new { Text = "1", Value = "1" });
            comboBox6.Items.Add(new { Text = "2", Value = "2" });
            comboBox6.Items.Add(new { Text = "3", Value = "3" });
            comboBox6.Items.Add(new { Text = "4", Value = "4" });
            comboBox6.Items.Add(new { Text = "5", Value = "5" });
            comboBox6.Items.Add(new { Text = "6", Value = "6" });
            comboBox6.Items.Add(new { Text = "7", Value = "7" });
            comboBox6.Items.Add(new { Text = "8", Value = "8" });
            comboBox6.Items.Add(new { Text = "9", Value = "9" });
            comboBox6.Items.Add(new { Text = "10", Value = "10" });
            comboBox6.Items.Add(new { Text = "11", Value = "11" });
            comboBox6.Items.Add(new { Text = "12", Value = "12" });
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                ConnectDB();
                MySqlCommand cmdQuery = new MySqlCommand();
                int count = 0;
                personalaadharid = Convert.ToInt32(textBox1.Text);
                string foldername = @"C:\Users\Admin\Documents\" + personalaadharid;
                string[] FilenameName;
                degree = comboBox1.Text;
                course = textBox2.Text;
                workexp = Convert.ToInt32(comboBox5.Text)*12 + Convert.ToInt32(comboBox6.Text);
                department = comboBox2.Text;
                worktype = textBox3.Text;
                salary = Convert.ToInt32(textBox4.Text);
                if (submitClickCount == 0)
                {
                    submitClickCount = 1;
                    cmdQuery.CommandText = "INSERT INTO Qualification(Aadharid,HighestQualification,ProfessionalCourses,MSSWorkExperience,Department,TypeOfWork,Salary)" + "VALUES(" + personalaadharid + ",'" + degree + "','" + course + "'," + workexp + ",'" + department + "','" + worktype + "'," + salary + ")";
                    cmdQuery.Connection = conn;
                    cmdQuery.ExecuteNonQuery();
                    MessageBox.Show("Records saved successfully!");
                }
            //    foreach (string item in openFileDialog1.FileNames)
            //    {
            //    FilenameName = item.Split('\\');
            //    if (File.Exists(foldername + "\\" + FilenameName[FilenameName.Length - 1]))
            //    {
            //        MessageBox.Show("File Already Exists!");
            //    }
            //    else
            //    {
            //        File.Copy(item, foldername + "\\" + FilenameName[FilenameName.Length - 1]);
            //        count++;
            //    }
            //}
        }
    }
}
