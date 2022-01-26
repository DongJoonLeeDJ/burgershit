using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            if(gunaGradientButton_valid.Visible==false)
            {
                gunaGradientButton_valid.Visible=true;
                gunaLinePanel1_velid.Visible = true;
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
                gunaLinePanel1_velid.Visible = false;
            }
        }

        private void gunaLinePanel1_velid_Click(object sender, EventArgs e)
        {
            if (gunaGradientButton_valid.Visible == false)
            {
                gunaGradientButton_valid.Visible = true;
                gunaLinePanel1_velid.Visible = true;
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
                gunaLinePanel1_velid.Visible = false;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel1_velid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
