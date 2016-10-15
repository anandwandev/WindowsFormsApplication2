using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            form1.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                bool isOpen = false;
                Form3 form3 = new Form3();
                if (Application.OpenForms["Form3"] != null)
                {
                    if ((Application.OpenForms["Form3"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form3.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form3.ShowDialog();
                        form3.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form3.ShowDialog();
                }
            }
            else if (radioButton2.Checked)
            {
                bool isOpen = false;
                Form8 form8 = new Form8();
                if (Application.OpenForms["Form8"] != null)
                {
                    if ((Application.OpenForms["Form8"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form8.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form8.ShowDialog();
                        form8.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form8.ShowDialog();
                }
            }
            else if (radioButton3.Checked)
            {
                bool isOpen = false;
                Form13 form13 = new Form13();
                if (Application.OpenForms["Form13"] != null)
                {
                    if ((Application.OpenForms["Form13"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form13.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form13.ShowDialog();
                        form13.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form13.ShowDialog();
                }
            }
            else if (radioButton4.Checked)
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for(int i=Application.OpenForms.Count-1;i>=0;i--)
            {
                if (Application.OpenForms[i].Name != "Form1")
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
