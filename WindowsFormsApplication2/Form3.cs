using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        String fname, mname, lname, aadharid, day, mon, year, gender, religion, caste,bdate,date,bloodgp;
        bool isOpen = false;
        private string connect;
        private MySqlConnection conn;
        int submitClickCount = 0;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
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
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aadharfilename;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                aadharfilename = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string birthfilename;
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                birthfilename = openFileDialog2.FileName;
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

        private void button5_Click(object sender, EventArgs e)
        {
            string castefilename;
            DialogResult result = openFileDialog3.ShowDialog();
            if (result == DialogResult.OK)
            {
                castefilename = openFileDialog3.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            Form5 form5 = new Form5(textBox4.Text);
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
            }//this.Close();
            else
            {
                form5.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        int age;
        public Form3()
        {
            InitializeComponent();
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
            comboBox1.Items.Add(new { Text = "1", Value = "1" });
            comboBox1.Items.Add(new { Text = "2", Value = "2" });
            comboBox1.Items.Add(new { Text = "3", Value = "3" });
            comboBox1.Items.Add(new { Text = "4", Value = "4" });
            comboBox1.Items.Add(new { Text = "5", Value = "5" });
            comboBox1.Items.Add(new { Text = "6", Value = "6" });
            comboBox1.Items.Add(new { Text = "7", Value = "7" });
            comboBox1.Items.Add(new { Text = "8", Value = "8" });
            comboBox1.Items.Add(new { Text = "9", Value = "9" });
            comboBox1.Items.Add(new { Text = "10", Value = "10" });
            comboBox1.Items.Add(new { Text = "11", Value = "11" });
            comboBox1.Items.Add(new { Text = "12", Value = "12" });
            comboBox1.Items.Add(new { Text = "13", Value = "13" });
            comboBox1.Items.Add(new { Text = "14", Value = "14" });
            comboBox1.Items.Add(new { Text = "15", Value = "15" });
            comboBox1.Items.Add(new { Text = "16", Value = "16" });
            comboBox1.Items.Add(new { Text = "17", Value = "17" });
            comboBox1.Items.Add(new { Text = "18", Value = "18" });
            comboBox1.Items.Add(new { Text = "19", Value = "19" });
            comboBox1.Items.Add(new { Text = "20", Value = "20" });
            comboBox1.Items.Add(new { Text = "21", Value = "21" });
            comboBox1.Items.Add(new { Text = "22", Value = "22" });
            comboBox1.Items.Add(new { Text = "23", Value = "23" });
            comboBox1.Items.Add(new { Text = "24", Value = "24" });
            comboBox1.Items.Add(new { Text = "25", Value = "25" });
            comboBox1.Items.Add(new { Text = "26", Value = "26" });
            comboBox1.Items.Add(new { Text = "27", Value = "27" });
            comboBox1.Items.Add(new { Text = "28", Value = "28" });
            comboBox1.Items.Add(new { Text = "29", Value = "29" });
            comboBox1.Items.Add(new { Text = "30", Value = "30" });
            comboBox1.Items.Add(new { Text = "31", Value = "31" });
            comboBox1.Items.Add(new { Text = "NA", Value = "NA" });
            this.comboBox2.DisplayMember = "Text";
            this.comboBox2.ValueMember = "Value";
            comboBox2.Items.Add(new { Text = "1", Value = "1" });
            comboBox2.Items.Add(new { Text = "2", Value = "2" });
            comboBox2.Items.Add(new { Text = "3", Value = "3" });
            comboBox2.Items.Add(new { Text = "4", Value = "4" });
            comboBox2.Items.Add(new { Text = "5", Value = "5" });
            comboBox2.Items.Add(new { Text = "6", Value = "6" });
            comboBox2.Items.Add(new { Text = "7", Value = "7" });
            comboBox2.Items.Add(new { Text = "8", Value = "8" });
            comboBox2.Items.Add(new { Text = "9", Value = "9" });
            comboBox2.Items.Add(new { Text = "10", Value = "10" });
            comboBox2.Items.Add(new { Text = "11", Value = "11" });
            comboBox2.Items.Add(new { Text = "12", Value = "12" });
            comboBox2.Items.Add(new { Text = "NA", Value = "NA" });
            this.comboBox3.DisplayMember = "Text";
            this.comboBox3.ValueMember = "Value";
            comboBox3.Items.Add(new { Text = "1927", Value = "1927" });
            comboBox3.Items.Add(new { Text = "1928", Value = "1928" });
            comboBox3.Items.Add(new { Text = "1929", Value = "1929" });
            comboBox3.Items.Add(new { Text = "1930", Value = "1930" });
            comboBox3.Items.Add(new { Text = "1931", Value = "1931" });
            comboBox3.Items.Add(new { Text = "1932", Value = "1932" });
            comboBox3.Items.Add(new { Text = "1933", Value = "1933" });
            comboBox3.Items.Add(new { Text = "1934", Value = "1934" });
            comboBox3.Items.Add(new { Text = "1935", Value = "1935" });
            comboBox3.Items.Add(new { Text = "1936", Value = "1936" });
            comboBox3.Items.Add(new { Text = "1937", Value = "1937" });
            comboBox3.Items.Add(new { Text = "1938", Value = "1938" });
            comboBox3.Items.Add(new { Text = "1939", Value = "1939" });
            comboBox3.Items.Add(new { Text = "1940", Value = "1940" });
            comboBox3.Items.Add(new { Text = "1940", Value = "1940" });
            comboBox3.Items.Add(new { Text = "1941", Value = "1941" });
            comboBox3.Items.Add(new { Text = "1942", Value = "1942" });
            comboBox3.Items.Add(new { Text = "1943", Value = "1943" });
            comboBox3.Items.Add(new { Text = "1944", Value = "1944" });
            comboBox3.Items.Add(new { Text = "1945", Value = "1945" });
            comboBox3.Items.Add(new { Text = "1946", Value = "1946" });
            comboBox3.Items.Add(new { Text = "1947", Value = "1947" });
            comboBox3.Items.Add(new { Text = "1948", Value = "1948" });
            comboBox3.Items.Add(new { Text = "1949", Value = "1949" });
            comboBox3.Items.Add(new { Text = "1950", Value = "1950" });
            comboBox3.Items.Add(new { Text = "1951", Value = "1951" });
            comboBox3.Items.Add(new { Text = "1952", Value = "1952" });
            comboBox3.Items.Add(new { Text = "1953", Value = "1953" });
            comboBox3.Items.Add(new { Text = "1954", Value = "1954" });
            comboBox3.Items.Add(new { Text = "1955", Value = "1955" });
            comboBox3.Items.Add(new { Text = "1956", Value = "1956" });
            comboBox3.Items.Add(new { Text = "1957", Value = "1957" });
            comboBox3.Items.Add(new { Text = "1958", Value = "1958" });
            comboBox3.Items.Add(new { Text = "1959", Value = "1959" });
            comboBox3.Items.Add(new { Text = "1960", Value = "1960" });
            comboBox3.Items.Add(new { Text = "1961", Value = "1961" });
            comboBox3.Items.Add(new { Text = "1962", Value = "1962" });
            comboBox3.Items.Add(new { Text = "1963", Value = "1963" });
            comboBox3.Items.Add(new { Text = "1964", Value = "1964" });
            comboBox3.Items.Add(new { Text = "1965", Value = "1965" });
            comboBox3.Items.Add(new { Text = "1966", Value = "1966" });
            comboBox3.Items.Add(new { Text = "1967", Value = "1967" });
            comboBox3.Items.Add(new { Text = "1968", Value = "1968" });
            comboBox3.Items.Add(new { Text = "1969", Value = "1969" });
            comboBox3.Items.Add(new { Text = "1970", Value = "1970" });
            comboBox3.Items.Add(new { Text = "1971", Value = "1971" });
            comboBox3.Items.Add(new { Text = "1972", Value = "1972" });
            comboBox3.Items.Add(new { Text = "1973", Value = "1973" });
            comboBox3.Items.Add(new { Text = "1974", Value = "1974" });
            comboBox3.Items.Add(new { Text = "1975", Value = "1975" });
            comboBox3.Items.Add(new { Text = "1976", Value = "1976" });
            comboBox3.Items.Add(new { Text = "1977", Value = "1977" });
            comboBox3.Items.Add(new { Text = "1978", Value = "1978" });
            comboBox3.Items.Add(new { Text = "1979", Value = "1979" });
            comboBox3.Items.Add(new { Text = "1980", Value = "1980" });
            comboBox3.Items.Add(new { Text = "1981", Value = "1981" });
            comboBox3.Items.Add(new { Text = "1982", Value = "1982" });
            comboBox3.Items.Add(new { Text = "1983", Value = "1983" });
            comboBox3.Items.Add(new { Text = "1984", Value = "1984" });
            comboBox3.Items.Add(new { Text = "1985", Value = "1985" });
            comboBox3.Items.Add(new { Text = "1986", Value = "1986" });
            comboBox3.Items.Add(new { Text = "1987", Value = "1987" });
            comboBox3.Items.Add(new { Text = "1988", Value = "1988" });
            comboBox3.Items.Add(new { Text = "1989", Value = "1989" });
            comboBox3.Items.Add(new { Text = "1990", Value = "1990" });
            comboBox3.Items.Add(new { Text = "1991", Value = "1991" });
            comboBox3.Items.Add(new { Text = "1992", Value = "1992" });
            comboBox3.Items.Add(new { Text = "1993", Value = "1993" });
            comboBox3.Items.Add(new { Text = "1994", Value = "1994" });
            comboBox3.Items.Add(new { Text = "1995", Value = "1995" });
            comboBox3.Items.Add(new { Text = "1996", Value = "1996" });
            comboBox3.Items.Add(new { Text = "1997", Value = "1997" });
            comboBox3.Items.Add(new { Text = "1998", Value = "1998" });
            comboBox3.Items.Add(new { Text = "1999", Value = "1999" });
            comboBox3.Items.Add(new { Text = "2000", Value = "2000" });
            comboBox3.Items.Add(new { Text = "2001", Value = "2001" });
            comboBox3.Items.Add(new { Text = "2002", Value = "2002" });
            comboBox3.Items.Add(new { Text = "2003", Value = "2003" });
            comboBox3.Items.Add(new { Text = "2004", Value = "2004" });
            comboBox3.Items.Add(new { Text = "2005", Value = "2005" });
            comboBox3.Items.Add(new { Text = "2006", Value = "2006" });
            comboBox3.Items.Add(new { Text = "2007", Value = "2007" });
            comboBox3.Items.Add(new { Text = "2008", Value = "2008" });
            comboBox3.Items.Add(new { Text = "2009", Value = "2009" });
            comboBox3.Items.Add(new { Text = "2010", Value = "2010" });
            comboBox3.Items.Add(new { Text = "2011", Value = "2011" });
            comboBox3.Items.Add(new { Text = "2012", Value = "2012" });
            comboBox3.Items.Add(new { Text = "2013", Value = "2013" });
            comboBox3.Items.Add(new { Text = "2014", Value = "2014" });
            comboBox3.Items.Add(new { Text = "2015", Value = "2015" });
            comboBox3.Items.Add(new { Text = "2016", Value = "2016" });
            comboBox3.Items.Add(new { Text = "2017", Value = "2017" });
            comboBox3.Items.Add(new { Text = "2018", Value = "2018" });
            comboBox3.Items.Add(new { Text = "2019", Value = "2019" });
            comboBox3.Items.Add(new { Text = "2020", Value = "2020" });
            comboBox3.Items.Add(new { Text = "2021", Value = "2021" });
            comboBox3.Items.Add(new { Text = "2022", Value = "2022" });
            comboBox3.Items.Add(new { Text = "NA", Value = "NA" });
            this.comboBox4.DisplayMember = "Text";
            this.comboBox4.ValueMember = "Value";
            comboBox4.Items.Add(new { Text = "A+", Value = "A+" });
            comboBox4.Items.Add(new { Text = "A-", Value = "A-" });
            comboBox4.Items.Add(new { Text = "B+", Value = "B+" });
            comboBox4.Items.Add(new { Text = "B-", Value = "B-" });
            comboBox4.Items.Add(new { Text = "AB+", Value = "AB+" });
            comboBox4.Items.Add(new { Text = "AB-", Value = "AB-" });
            comboBox4.Items.Add(new { Text = "O+", Value = "O+" });
            comboBox4.Items.Add(new { Text = "O-", Value = "O-" });
            comboBox4.Items.Add(new { Text = "NA", Value = "NA" });
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
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
            try
            {
                fname = textBox1.Text;
                mname = textBox2.Text;
                lname = textBox3.Text;
                aadharid = textBox4.Text;
                day = comboBox1.Text;
                mon = comboBox2.Text;
                year = comboBox3.Text;
                bloodgp = comboBox4.Text;
                bdate = day + "/" + mon + "/" + year;
                date = DateTime.Now.ToString("yyyy");
                if (radioButton1.Checked == true)
                {
                    gender = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    gender = radioButton2.Text;
                }
                religion = textBox5.Text;
                caste = textBox6.Text;
                if (submitClickCount == 0)
                {
                    if (fname == "" || mname == "" || lname == "" || aadharid == "" || day == "" || mon == "" || year == "" || bloodgp == "" || gender == "" || religion == "" || caste == "")
                    {
                        MessageBox.Show("Please enter all fields!");
                    }
                    else
                    {
                        age = Convert.ToInt32(date) - Convert.ToInt32(year);
                        ConnectDB();
                        MySqlCommand cmdQuery = new MySqlCommand();
                        try
                        {
                            cmdQuery.CommandText = "INSERT INTO person(fname,mname,lname,aadharid,bdate,age,bloodgp,gender,religion,caste)" + "VALUES('" + fname + "','" + mname + "','" + lname + "','" + aadharid + "','" + bdate + "','" + age + "','" + bloodgp + "','" + gender + "','" + religion + "','" + caste + "')";
                            cmdQuery.Connection = conn;
                            cmdQuery.ExecuteNonQuery();
                            MessageBox.Show("Records saved successfully!");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Duplicate Entry !!!");
                        }
                        submitClickCount = 1;
                        conn.Close();
                        string foldername = @"C:\Users\Admin\Documents\" + aadharid;
                        if (Directory.Exists(foldername))
                        {
                            return;
                        }
                        else
                        {
                            System.IO.Directory.CreateDirectory(foldername);
                        }
                        int acount = 0, bcount = 0, ccount = 0;
                        string[] FilenameName;
                        foreach (string item in openFileDialog1.FileNames)
                        {
                            FilenameName = item.Split('\\');
                            if (File.Exists(foldername + "\\" + FilenameName[FilenameName.Length - 1]))
                            {
                                MessageBox.Show("File Already Exists!");
                            }
                            else
                            {
                                File.Copy(item, foldername + "\\" + FilenameName[FilenameName.Length - 1]);
                                acount++;
                            }

                        }
                        foreach (string item in openFileDialog2.FileNames)
                        {
                            FilenameName = item.Split('\\');
                            if (File.Exists(foldername + "\\" + FilenameName[FilenameName.Length - 1]))
                            {
                                MessageBox.Show("File Already Exists!");
                            }
                            else
                            {
                                File.Copy(item, foldername + "\\" + FilenameName[FilenameName.Length - 1]);
                                bcount++;
                            }
                        }
                        foreach (string item in openFileDialog3.FileNames)
                        {
                            FilenameName = item.Split('\\');
                            if (File.Exists(foldername + "\\" + FilenameName[FilenameName.Length - 1]))
                            {
                                MessageBox.Show("File Already Exists!");
                            }
                            else
                            {
                                File.Copy(item, foldername + "\\" + FilenameName[FilenameName.Length - 1]);
                                ccount++;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
