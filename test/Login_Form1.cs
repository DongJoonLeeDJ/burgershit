using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace test
{
    public partial class Login_Form1 : Form
    {
        public static readonly Login_Form1 loginForm1 = new Login_Form1();
        public static readonly Home_Form1 homeForm1 = new Home_Form1();
        public static readonly Login_Form2 loginForm2 = new Login_Form2();

        public Login_Form1()
        {
            InitializeComponent();
        }


        private void gunaTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gunaTextBox1.Text = string.Empty;
        }

        private void gunaTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            gunaTextBox2.Text = string.Empty;
        }

        private void gunaButton4_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();

        }

        private void gunaCirclePictureBox1_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();
        }

        private void gunaButton2_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            loginForm2.Show();

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            string id = gunaTextBox1.Text;
            string pw = gunaTextBox2.Text;
            string dbpw = "";
            var connectionString = "server=localhost;user=root;database=burgerking;password=1234";
            var connection = new MySqlConnection(connectionString);
            string insertQuery = $"SELECT pw FROM member where id='{id}'";

            if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("아이디를 입력하세요");
                gunaTextBox1.Focus();
                return;
            }
            else if (gunaTextBox2.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요");
                gunaTextBox2.Focus();
                return;
            }
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
                        dbpw = reader["pw"].ToString();
                    }
                    if (dbpw == pw)
                    {
                        MessageBox.Show("로그인 성공!");

                        //세션값 전달
                        Order_Form3 oder3 = new Order_Form3();
                        //화면 이동
                        Home_Form1 home = new Home_Form1();
                        home.Show();
                        home.SetText(id);

                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 틀렸습니다.");
                    }
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
