using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        String fname,username, password,dbusername,dbpassword;
        private string connect;
        private MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            ConnectDB();
            MySqlDataReader reader1,reader2,reader3;
            username = uname.Text;
            password = passw.Text;
            MySqlCommand cmdQuery1 = new MySqlCommand();
            MySqlCommand cmdQuery2 = new MySqlCommand();
            MySqlCommand cmdQuery3 = new MySqlCommand();
       
            cmdQuery1.CommandText = "select uname from anandwanregistration where uname='"+username+"'";
            cmdQuery1.Connection = conn;
            reader1 = cmdQuery1.ExecuteReader();
            while (reader1.Read())
            {
                dbusername = reader1.GetString(0);
            }
            reader1.Close();
            cmdQuery2.CommandText = "select pass from anandwanregistration where uname='"+username+"'";
            cmdQuery2.Connection = conn;
            reader2 = cmdQuery2.ExecuteReader();
            while (reader2.Read())
            {
                dbpassword = reader2.GetString(0);
            }
            reader2.Close();
            cmdQuery3.CommandText = "select fname from anandwanregistration where uname='" + username + "'";
            cmdQuery3.Connection = conn;
            reader3 = cmdQuery3.ExecuteReader();
            while (reader3.Read())
            {
                fname = reader3.GetString(0);
            }
            reader3.Close();
            if (username.Equals(dbusername) && password.Equals(dbpassword))
            {
                MessageBox.Show("Welcome " + fname +"!");
                Form4 form4 = new Form4();
                form4.ShowDialog();            
            }
            else 
            {
                MessageBox.Show("Authentication Failed!");
            }   
        }
    }
}
