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
    public partial class Form1 : Form
    {
        Menu select;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Menu m)
        {
            select = m;
            InitializeComponent();
        }


        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaPanel1.Visible = false;
            gunaPanel2.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            //select.name = "단품";
            int idx = select.rownum - 1;
            select.name = DataManager.menulist[idx].name;
            select.price = DataManager.menulist[idx].price;
            select.category = DataManager.menulist[idx].category;
            Close(); //더이상 추가할 거 없음
        }

        private void userControl11_Click(object sender, EventArgs e)
        {

        }
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (sin == null)
            {
                sin = "감자튀김";
                si = 0;
            }
            if (drn == null)
            {
                drn = "코카콜라";
                dr = 0;
            }
            int idx = select.rownum - 1;
            select.name = DataManager.menulist[idx].name + "(세트) 구성 : " + sin + ", " + drn;
            select.price = (int.Parse(DataManager.menulist[idx].price) + si + dr + 2000).ToString();
            select.category = DataManager.menulist[idx].category;
            Close();
        }
        public string sin;
        public int si;
        public void Set_Side_Add(object sender, EventArgs e)
        {
            if(gunaRadioButton6.Checked == true)
            {
                sin = "감자튀김";
                si = 0;
            }
            else if(gunaRadioButton1.Checked == true)
            {
                sin = "치즈스틱";
                si = 200;
            }
            else if(gunaRadioButton2.Checked == true)
            {
                sin = "너겟킹";
                si = 500;
            }
        }
        public string drn;
        public int dr;
        private void Set_Drink_Add(object sender, EventArgs e)
        {
            if(gunaRadioButton7.Checked == true)
            {
                drn = "코카콜라";
                dr = 0;
            }
            else if(gunaRadioButton3.Checked == true)
            {
                drn = "스프라이트";
                dr = 200;
            }
            else if(gunaRadioButton4.Checked == true)
            {
                drn = "제로톡톡";
                dr = 500;
            }
            else if(gunaRadioButton5.Checked == true)
            {
                drn = "아메리카노";
                dr = 100;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

            /*
            폼2코드
            Hide();
            new Form2(select).ShowDialog();
            Close();
             */