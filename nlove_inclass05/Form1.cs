using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//use the namespace of the added fies (Look what's their namespace - maybe not the same as folder name!)
using Example_GUI;

namespace nlove_inclass05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // click on the button - creates object/ opens a new form (downloaded before)
        private void btnNew_Click(object sender, EventArgs e)
        {
            PersonalInformation pi = new PersonalInformation();
            pi.ShowDialog();
        }

        //event handler
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // creates a new object/ opens Search form (downloaded before - added- existing obj)
            SearchForm sf = new SearchForm();
            //forms /objects/ only will show with this method
            sf.ShowDialog();
        }
    }
}
