using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            LoginForm form1 = new LoginForm();
            form1.Hide();
        }
        
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form1")
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            BasicInformation form3 = new BasicInformation();
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

        private void showDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool isOpen = false;
            //Form8 form8 = new Form8();
            //if (Application.OpenForms["Form8"] != null)
            //{
            //    if ((Application.OpenForms["Form8"].Text).Equals("MSS Information Centre"))
            //    {
            //        isOpen = true;
            //    }
            //    if (isOpen == true)
            //    {
            //        form8.Focus();
            //        this.Close();
            //    }
            //    else
            //    {
            //        isOpen = true;
            //        form8.ShowDialog();
            //        form8.Focus();
            //        //this.Close();
            //    }
            //}//this.Close();
            //else
            //{
            //    form8.ShowDialog();
            //}
        }

        private void editDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool isOpen = false;
            //Form13 form13 = new Form13();
            //if (Application.OpenForms["Form13"] != null)
            //{
            //    if ((Application.OpenForms["Form13"].Text).Equals("MSS Information Centre"))
            //    {
            //        isOpen = true;
            //    }
            //    if (isOpen == true)
            //    {
            //        form13.Focus();
            //        this.Close();
            //    }
            //    else
            //    {
            //        isOpen = true;
            //        form13.ShowDialog();
            //        form13.Focus();
            //        //this.Close();
            //    }
            //}//this.Close();
            //else
            //{
            //    form13.ShowDialog();
            //}
        }

        private void basicInfoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void familyInfoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void healthInfoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void skillInfoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void editRecordsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void deleteRecordsToolStripMenuItem_Click(object sender, EventArgs e)
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
}
