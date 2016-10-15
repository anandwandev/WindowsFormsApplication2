using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        String fname, lname, uname, pass, pass1,phone;
        private string connect;
        private MySqlConnection conn;
        int submitClickCount = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            Form1 form1 = new Form1();
            if (Application.OpenForms["Form1"] != null)
            {
                if ((Application.OpenForms["Form1"].Text).Equals("MSS Information Centre"))
                {
                    isOpen = true;
                }
                if (isOpen == true)
                {
                    form1.Focus();
                    this.Close();
                }
                else
                {
                    isOpen = true;
                    form1.Show();
                    form1.Focus();
                    //this.Close();
                }
            }
            //this.Close();
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
            fname = textBox1.Text;
            lname = textBox2.Text;
            phone = textBox3.Text;
            uname = textBox4.Text;
            pass = textBox5.Text;
            pass1 = textBox6.Text;
            if (submitClickCount == 0)
            {
                if (fname == "" || lname == "" || phone == "" || uname == "" || pass == "" || pass1 == "")
                {
                    MessageBox.Show("Please enter all fields!");
                }
                else if (!(pass.Equals(pass1)))
                {
                    MessageBox.Show("Passwords do not match.Please Re-Enter!");
                }
                else if (!(phone.Equals("6666666666")))
                {
                    MessageBox.Show("Unauthorised User!");
                }
                else
                {
                    ConnectDB();
                    MySqlCommand cmdQuery = new MySqlCommand();
                    cmdQuery.CommandText = "INSERT INTO anandwanregistration(fname,lname,phone,uname,pass,pass1)" + "VALUES('" + fname + "','" + lname + "','" + phone + "','" + uname + "','" + pass + "','" + pass1 + "')";
                    cmdQuery.Connection = conn;
                    cmdQuery.ExecuteNonQuery();
                    submitClickCount = 1;
                    MessageBox.Show("Registration Successful");

                    conn.Close();
                     this.Hide();
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
