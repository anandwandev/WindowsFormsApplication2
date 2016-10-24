using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class HealthcareDetails : Form
    {
        String disability, medcondition, othercondition;
        int personalaadharid, percentage;
        private string connect;
        private MySqlConnection conn;
        int submitClickCount = 0;
        public HealthcareDetails(String qs)
        {
            InitializeComponent();
            textBox1.Text = qs;
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "NA", Value = "NA" });
            comboBox1.Items.Add(new { Text = "Orthopedically Handicapped", Value = "Orthopedically Handicapped" });
            comboBox1.Items.Add(new { Text = "Visually Impaired", Value = "Visually Impaired" });
            comboBox1.Items.Add(new { Text = "Oral and Hearing Impaired", Value = "Oral and Hearing Impaired" });
            this.comboBox2.DisplayMember = "Text";
            this.comboBox2.ValueMember = "Value";
            comboBox2.Items.Add(new { Text = "NA", Value = "NA" });
            comboBox2.Items.Add(new { Text = "10%", Value = "10" });
            comboBox2.Items.Add(new { Text = "15%", Value = "15" });
            comboBox2.Items.Add(new { Text = "20%", Value = "20" });
            comboBox2.Items.Add(new { Text = "25%", Value = "25" });
            comboBox2.Items.Add(new { Text = "30%", Value = "30" });
            comboBox2.Items.Add(new { Text = "35%", Value = "35" });
            comboBox2.Items.Add(new { Text = "40%", Value = "40" });
            comboBox2.Items.Add(new { Text = "45%", Value = "45" });
            comboBox2.Items.Add(new { Text = "50%", Value = "50" });
            comboBox2.Items.Add(new { Text = "55%", Value = "55" });
            comboBox2.Items.Add(new { Text = "60%", Value = "60" });
            comboBox2.Items.Add(new { Text = "65%", Value = "65" });
            comboBox2.Items.Add(new { Text = "70%", Value = "70" });
            comboBox2.Items.Add(new { Text = "75%", Value = "75" });
            comboBox2.Items.Add(new { Text = "80%", Value = "80" });
            comboBox2.Items.Add(new { Text = "85%", Value = "85" });
            comboBox2.Items.Add(new { Text = "90%", Value = "90" });
            comboBox2.Items.Add(new { Text = "95%", Value = "95" });
            comboBox2.Items.Add(new { Text = "100%", Value = "100" });
            this.comboBox3.DisplayMember = "Text";
            this.comboBox3.ValueMember = "Value";
            comboBox3.Items.Add(new { Text = "NA", Value = "NA" });
            comboBox3.Items.Add(new { Text = "Blood Pressure", Value = "Blood Pressure" });
            comboBox3.Items.Add(new { Text = "Diabetes", Value = "Diabetes" });
            comboBox3.Items.Add(new { Text = "Asthama", Value = "Asthama" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
            comboBox3.Items.Add(new { Text = "", Value = "" });
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
            string disabilitycertifilename;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                 disabilitycertifilename=openFileDialog1.FileName;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB();
                MySqlCommand cmdQuery = new MySqlCommand();
                int count = 0;
                personalaadharid = Convert.ToInt32(textBox1.Text);
                //string foldername = @"C:\Users\Admin\Documents\" + personalaadharid;
                string[] FilenameName;

                //foreach (string item in openFileDialog1.FileNames)
                //{
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
                disability = comboBox1.Text;
                //TODO: 0 value is inserted
                percentage = Convert.ToInt32(comboBox2.SelectedValue);
                medcondition = comboBox3.Text;
                othercondition = textBox3.Text;
                if (submitClickCount == 0)
                {
                    submitClickCount = 1;
                    cmdQuery.CommandText = "INSERT INTO PersonHealthDetails(Aadharid,OtherDisabilityType,DisabilityPercentage,MedicalConditions)" + "VALUES(" + personalaadharid + ",'" + disability + "'," + percentage + ",'" + medcondition + "," + othercondition + "')";
                    cmdQuery.Connection = conn;
                    cmdQuery.ExecuteNonQuery();
                    MessageBox.Show("Records saved successfully!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data Incorrect or File Upload Error!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            FamilyDetails form5 = new FamilyDetails(textBox1.Text);
            if (Application.OpenForms["Form5"] != null)
            {
                if ((Application.OpenForms["Form5"].Text).Equals("MSS Information Centre"))
                {
                    isOpen = true;
                }
                if (isOpen == true)
                {
                    form5.Focus();
                    this.Close();
                }
                else
                {
                    isOpen = true;
                    form5.Show();
                    form5.Focus();
                    //this.Close();
                }
            }
            //this.Close();
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

        private void button5_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            EducationalDetails form7 = new EducationalDetails(textBox1.Text);
            if (Application.OpenForms["Form7"] != null)
            {
                if ((Application.OpenForms["Form7"].Text).Equals("MSS Information Centre"))
                {
                    isOpen = true;
                }
                if (isOpen == true)
                {
                    form7.Focus();
                    this.Close();
                }
                else
                {
                    isOpen = true;
                    form7.Show();
                    form7.Focus();
                    //this.Close();
                }
            }//this.Close();
            else
            {
                form7.ShowDialog();
            }
        }
    }
}
