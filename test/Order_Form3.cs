using MySql.Data.MySqlClient;
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
    public partial class Order_Form3 : Form
    {
        public static Menu_Form1 menuForm1 = new Menu_Form1();
        public static Order_Form2 orderForm2 = new Order_Form2();
        //세션 아이디
        static public string session;
        
        public Order_Form3()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menuForm1.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menuForm1.Show();
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            this.Visible=false;
            orderForm2.Show();  
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            orderForm2.Show();
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }
        public void SetText(string data)
        {
            session = data;
            callInfo();
        }

        private void callInfo()
        {
            string id = session;
            string dbname = "";
            string dbphone_num = "";
            string dbaddress = "";
            var connectionString = "server=localhost;user=root;database=burgerking;password=1234";
            var connection = new MySqlConnection(connectionString);
            string insertQuery = $"SELECT * FROM member where id='{id}'";

            
            try
            {
                connection.Open();
                //label3.Text = "Connected";

                var command = new MySqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbname = reader["name"].ToString();
                        dbphone_num = reader["phone_num"].ToString();
                        dbaddress = reader["address"].ToString();
                    }
                    gunaLabel8.Text = dbname;
                    gunaLabel9.Text = dbphone_num;
                    gunaLabel10.Text = dbaddress;

                }
                else
                {
                    MessageBox.Show("잘못된 ID 입니다.");
                }


            }
            catch (Exception ex)
            {
                //label3.Text = "Disconnected";
            }
            connection.Close();
        }
    }
}
