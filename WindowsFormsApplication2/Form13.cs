using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
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
            if (radioButton1.Checked == true)
            {
                bool isOpen = false;
                EditDatabase form14 = new EditDatabase();
                if (Application.OpenForms["Form14"] != null)
                {
                    if ((Application.OpenForms["Form14"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form14.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form14.ShowDialog();
                        form14.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form14.ShowDialog();
                }
            }
            else if (radioButton4.Checked==true)
            {
                bool isOpen = false;
                DeleteDBRecords form15 = new DeleteDBRecords();
                if (Application.OpenForms["Form15"] != null)
                {
                    if ((Application.OpenForms["Form15"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form15.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form15.ShowDialog();
                        form15.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form15.ShowDialog();
                }
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
                    form4.ShowDialog();
                    form4.Focus();
                    //this.Close();
                }
            }//this.Close();
            else
            {
                form4.ShowDialog();
            }
        }
    }
}
