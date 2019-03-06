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
using static Example_GUI.LEVEL;

namespace Example_GUI
{
    public partial class StudentInformation : Form
    {
        public StudentInformation(string StudentID)
        {
            InitializeComponent();

            string id = StudentID;

            FileStream fs = new FileStream("..\\..\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = "";
            while ((line = sr.ReadLine()) != null)//if text in the line is not null / 
                //reads line by line (due to Readline)
            {
                //Split- method which separates elements of array - here with ',':
                string[] input = line.Split(',');// array of strings - each array - a separate line-
                                                 //each element is an element of info (in it's place)

                if (id==input[0])
                {
                    txtID.Text = input[0];
                    txtFirstName.Text = input[1];
                    txtMidInit.Text = input[2];
                    txtLastName.Text = input[3];
                    txtAge.Text = input[5];
                    txtGPA.Text = input[6];

                    string level = input[4];
                    // level -is enumeration and toString turns it's value "1" - to the word under it..
                    if (level == FRESHMAN.ToString()) { radFreshman.Checked = true; }
                    else if (level == SOPHOMORE.ToString()) { radSophomore.Checked = true; }
                    else if (level == JUNIOR.ToString()) { radJunior.Checked = true; }
                    else if (level == SENIOR.ToString()) { radSenior.Checked = true; }
                    else if (level == NON_DEGREE.ToString()) { radNonDeg.Checked = true; }
                    else if (level == GRADUATE.ToString()) { radGrad.Checked = true; }
                    else { radFreshman.Checked = true; }
                }
            }

            sr.Close();
            fs.Close();
        }

        private void ClearFields()
        {
            if (MessageBox.Show("Are you sure you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtErrors.Text = "";
                txtFirstName.Text = "";
                txtMidInit.Text = "";
                txtLastName.Text = "";
                txtAge.Text = "";
                txtGPA.Text = "";
                radFreshman.Checked = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            txtErrors.Text = "";
            bool goodForm = true;
            string id, firstName, midInit, lastName;
            LEVEL level;
            int age = 0;
            double gpa = 0.0D;
            StringBuilder sb = new StringBuilder();

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

            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lastName = "";
                sb.Append("Last name cannot be blank.\n");
                goodForm = false;
            }
            else
            {
                lastName = txtLastName.Text;
            }

            if (String.IsNullOrWhiteSpace(txtAge.Text))
            {
                sb.Append("Age cannot be blank.\n");
                goodForm = false;
            }
            else
            {
                if (!(Int32.TryParse(txtAge.Text, out age)))
                {
                    sb.Append("Age must be numeric.\n");
                    goodForm = false;
                }
            }

            if (String.IsNullOrWhiteSpace(txtGPA.Text))
            {
                sb.Append("GPA cannot be blank.\n");
                goodForm = false;
            }
            else
            {
                if (!(Double.TryParse(txtGPA.Text, out gpa)))
                {
                    sb.Append("GPA must be numeric.\n");
                    goodForm = false;
                }
            }

            if (radFreshman.Checked) { level = FRESHMAN; }// equal to "1" - from enumeration
            else if (radSophomore.Checked) { level = SOPHOMORE; }
            else if (radJunior.Checked) { level = JUNIOR; }
            else if (radSenior.Checked) { level = SENIOR; }
            else if (radNonDeg.Checked) { level = NON_DEGREE; }
            else if (radGrad.Checked) { level = GRADUATE; }
            else { level = FRESHMAN; }

            if (goodForm)
            {
                try
                {
                    Student s = new Student(id, firstName, midInit, lastName, age);
                    s.Level = level;
                    s.GPA = gpa;

                   MessageBox.Show(s.DisplayInformation());
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
    }
}
