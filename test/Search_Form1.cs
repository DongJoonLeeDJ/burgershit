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
    public partial class Search_Form1 : Form
    {
        Locale myselect;



        public static readonly Order_Form3 orderForm3 = new Order_Form3();
        public static readonly Home_Form1 homeForm1 = new Home_Form1();
        public static readonly Menu_Form1 menuForm1 = new Menu_Form1();
        //세션
        static public string session;

        public Search_Form1()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            menuForm1.Show();
            menuForm1.SetText(session);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            List<Locale> locales = KakaoAPI.Search(); // "대구" 입력시 그에 대한 응답
            listBox1.Items.Clear();

            foreach (Locale item in locales)
            {
                listBox1.Items.Add(item); // Locale 객체인 item은 내부적으로 ToString 호출해서 Name 값 리턴
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            myselect = listBox1.SelectedItem as Locale;
            object[] position = new object[] { myselect.Lat, myselect.Lng };
            HtmlDocument hdoc = webBrowser1.Document;
            hdoc.InvokeScript("setCenter", position);
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();
        }

        internal void SetText(string text)
        {
            session = text;
            MessageBox.Show("서치" + session);
        }
    }
}
