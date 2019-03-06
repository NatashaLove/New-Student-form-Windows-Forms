using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Example_GUI
{
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            if(MessageBox.Show("Are you sure you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtID.Text = "";
                txtErrors.Text = "";
                txtFirstName.Text = "";
                txtMidInit.Text = "";
                txtLastName.Text = "";
                txtAge.Text = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this form?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtErrors.Text = "";
            bool goodForm = true;
            string id, firstName, midInit, lastName;
            int age = 0;
            StringBuilder sb = new StringBuilder();

            Person p;

            id = txtID.Text;

            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                firstName = "";
                sb.Append("First name cannot be blank.\n");
                goodForm = false;
            }
            else
            {
                firstName = txtFirstName.Text;
            }

            midInit = (String.IsNullOrWhiteSpace(txtMidInit.Text)) ? " " : txtMidInit.Text;

            if(String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lastName = "";
                sb.Append("Last name cannot be blank.\n");
                goodForm = false;
            }
            else
            {
                lastName = txtLastName.Text;
            }

            if(String.IsNullOrWhiteSpace(txtAge.Text))
            {
                sb.Append("Age cannot be blank.\n");
                goodForm = false;
            }
            else
            {
                if(!(Int32.TryParse(txtAge.Text, out age)))
                {
                    sb.Append("Age must be numeric.\n");
                    goodForm = false;
                }
            }

            if(goodForm)
            {
                try
                {
                    string fileName = "";

                    if (radStudent.Checked)
                    {
                        p = new Student(id, firstName, midInit, lastName, age);

                        // go up 2 levels - it's a path to the file - it's a referential link 
                        //(there's also direct link - type out exact folder names etc)
                        // the code looks for file or creates it- if it doesn't exist in that path:
                        fileName = "..\\..\\Student.txt";
                    }
                    else
                    {
                        p = new Employee(id, firstName, midInit, lastName, age);
                        
                        // better to use referential links - so others when installed will be able to use the code-
                        //the file will be alway saved in the same place and not lost in other folders (if renamed)
                        fileName = "..\\..\\Employee.txt";// 2 levels up
                    }

                    MessageBox.Show(p.DisplayInformation());
                    //filestream allows to use files
                    FileStream fs;
                    //transfers data into file
                    StreamWriter sw;
                    //can't deal with files without FileStream (helps to deal with files - has methds and exceptions)
                    //and StreamWriter (writes data in a line to file) -- not to mess up

                    try
                    {
                        fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                        sw = new StreamWriter(fs);

                        sw.WriteLine(p.ToString());// toString - takes all info and puts it in line separated by commas in txt
                        
                        sw.Close();
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        txtErrors.Text = ex.Message + "\n";
                    }

                }
                catch (AgeBelowZeroException ex)
                {
                    txtErrors.Text = ex.Message + "\n";
                }
                catch (Exception ex)
                {
                    txtErrors.Text = ex.Message + "\n";
                }
            }
            else
            {
                txtErrors.Text = sb.ToString();
            }
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
