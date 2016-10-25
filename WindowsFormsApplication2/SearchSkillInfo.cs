﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SearchSkillInfo : Form
    {
        private string connect;
        private MySqlConnection conn;
        private MySqlDataAdapter mySqlDataAdapter;
        int countreader = 0;
        String whereclause;
        public SearchSkillInfo()
        {
            InitializeComponent();
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "Aadhar ID", Value = "Aadhar ID" });
            comboBox1.Items.Add(new { Text = "Educational Degree", Value = "Educational Degree" });
            comboBox1.Items.Add(new { Text = "Other Qualification", Value = "Other Qualification" });
            comboBox1.Items.Add(new { Text = "Work Experience", Value = "Work Experience" });
            comboBox1.Items.Add(new { Text = "Department", Value = "Department" });
            comboBox1.Items.Add(new { Text = "Work Type", Value = "Work Type" });
            comboBox1.Items.Add(new { Text = "Salary", Value = "Salary" });
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
            whereclause = textBox1.Text;
            try
            {
                if (comboBox1.Text == "Aadhar ID")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification where Aadharid=" + @whereclause , conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Educational Degree")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification where HighestQualification like '%" + @whereclause + "%'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Other Qualification")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification where ProfessionalCourses like '%" + @whereclause + "%'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Work Experience")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification where MSSWorkExperience=" + @whereclause , conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Department")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification where Department='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Work Type")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification where TypeOfWork='" + @whereclause + "'", conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "Salary")
                {
                    whereclause = textBox1.Text;
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification where Salary=" + @whereclause, conn);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (radioButton1.Checked == true)
                    {
                        countreader = ds.Tables[0].Rows.Count;
                        label2.Text = countreader.ToString();
                    }
                }
                else if (comboBox1.Text == "All")
                {
                    mySqlDataAdapter = new MySqlDataAdapter("select Aadharid as 'Aadhar ID',HighestQualification as 'Highest Qualification',ProfessionalCourses as 'Extra courses',MSSWorkExperience as 'MSS Work Experience (in months)',Department as 'Working Department',TypeOfWork as 'Type of work',Salary as 'Salary' from Qualification", conn);
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
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }
    }
}
