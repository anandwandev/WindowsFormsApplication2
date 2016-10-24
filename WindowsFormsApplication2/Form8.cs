using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
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
                SearchBasicInfo form9 = new SearchBasicInfo();
                if (Application.OpenForms["Form9"] != null)
                {
                    if ((Application.OpenForms["Form9"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form9.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form9.ShowDialog();
                        form9.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form9.ShowDialog();
                }
            }
            else if (radioButton2.Checked == true)
            {
                bool isOpen = false;
                SearchFamilyInfo form10 = new SearchFamilyInfo();
                if (Application.OpenForms["Form10"] != null)
                {
                    if ((Application.OpenForms["Form10"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form10.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form10.ShowDialog();
                        form10.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form10.ShowDialog();
                }
            }
            else if (radioButton3.Checked == true)
            {
                bool isOpen = false;
                SearchHealthInfo form11 = new SearchHealthInfo();
                if (Application.OpenForms["Form11"] != null)
                {
                    if ((Application.OpenForms["Form11"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form11.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form11.ShowDialog();
                        form11.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form11.ShowDialog();
                }
            }
            else if (radioButton4.Checked == true)
            {
                bool isOpen = false;
                SearchSkillInfo form12 = new SearchSkillInfo();
                if (Application.OpenForms["Form12"] != null)
                {
                    if ((Application.OpenForms["Form12"].Text).Equals("MSS Information Centre"))
                    {
                        isOpen = true;
                    }
                    if (isOpen == true)
                    {
                        form12.Focus();
                        this.Close();
                    }
                    else
                    {
                        isOpen = true;
                        form12.ShowDialog();
                        form12.Focus();
                        //this.Close();
                    }
                }//this.Close();
                else
                {
                    form12.ShowDialog();
                }
            }
        }
    }
}
