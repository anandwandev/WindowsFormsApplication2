using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class LoginForm : Form
    {
        String fname,username, password,dbusername,dbpassword;
        private string connect;
        private MySqlConnection conn;
        public LoginForm()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterAdmin form2 = new RegisterAdmin();
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
       
            cmdQuery1.CommandText = "select Username from Admin where Username='"+username+"'";
            cmdQuery1.Connection = conn;
            reader1 = cmdQuery1.ExecuteReader();
            while (reader1.Read())
            {
                dbusername = reader1.GetString(0);
            }
            reader1.Close();
            cmdQuery2.CommandText = "select Password from Admin where Username='"+username+"'";
            cmdQuery2.Connection = conn;
            reader2 = cmdQuery2.ExecuteReader();
            while (reader2.Read())
            {
                dbpassword = reader2.GetString(0);
            }
            reader2.Close();
            cmdQuery3.CommandText = "select FirstName from admin where Username='" + username + "'";
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
                AdminHome form4 = new AdminHome();
                form4.ShowDialog();            
            }
            else 
            {
                MessageBox.Show("Authentication Failed!");
            }   
        }
    }
}
