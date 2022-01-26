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


    public partial class Home_Form1 : Form
    {
        public static readonly Login_Form1 loginForm1 = new Login_Form1();
        public static readonly Home_Form1 homeForm1 = new Home_Form1();
        public static readonly Login_Form2 loginForm2 = new Login_Form2();
    
        public static readonly Search_Form1 searchForm1 = new Search_Form1();
        static public string session;

        public Home_Form1()

        {
            InitializeComponent();
            DataManager.selectQuery();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            loginForm1.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginForm2.Show();
            
        }

        private void Home_Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            
        
        }

        private void gunaPictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            searchForm1.Show();
            searchForm1.SetText(session);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void SetText(string data)
        {
            session = data;
            MessageBox.Show("" + session);
        }

    }
}
