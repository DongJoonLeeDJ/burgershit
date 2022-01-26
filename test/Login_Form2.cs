using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{

    public partial class Login_Form2 : Form
    {
        public static readonly Home_Form1 homeForm1 = new Home_Form1();
        bool id_Checking = false;
        bool pw_Checking = false;

        public Login_Form2()
        {
            InitializeComponent();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();
        }
        private void gunaPictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();
        }
        private void textBox_PWCheck_TextChanged(object sender, EventArgs e)
        {

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            id_Check();
        }
        private void gunaButton5_Click(object sender, EventArgs e)
        {
            string name = textBox_ID.Text;
            string ID = textBox_ID.Text;
            string PW = textBox_PW.Text;
            string phone = textBox_Phone.Text;
            string address = textBox_Address.Text;
            string email = textBox_Email.Text;
            string email2 = textBox_Email2.Text;

            signUp();
        }
        // 회원 가입 DB연동
        private void signUp()
        {
            var connectionString = "server=localhost;user=root;database=burgerking;password=1234";
            var connection = new MySqlConnection(connectionString);
            //string insertQuery = "INSERT INTO burgerkingmember(name,id,pw,address) values ('2','24','13df','134f')";
            //string insertQuery = $"INSERT INTO burgerkingmember(name,id,pw,address) values{name},{ID},{PW},{address}";
            string insertQuery = "insert into member(name,id,pw,phone_num,address,email,email2) values('" + this.textBox_Name.Text + "','" + this.textBox_ID.Text + "','"
                + this.textBox_PW.Text + "','" + this.textBox_Phone.Text + "','" + this.textBox_Address.Text + "','" + this.textBox_Email.Text + "','" + this.textBox_Email2.Text + "');";

            try
            {
                connection.Open();
                //label6.Text = "Connected";

                var command = new MySqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();
                //if (command.ExecuteNonQuery() == 1)
                //{
                //    Console.WriteLine("인서트성공");
                //}
                //else
                //{
                //    Console.WriteLine("인서트실패");
                //}

            }
            catch (Exception ex)
            {
                //label6.Text = "Disconnected";
            }
            connection.Close();
        }

        //아이디 확인 메서드
        private void id_Check()
        {
            string id = textBox_ID.Text;
            string dbid = "";

            var connectionString = "server=localhost;user=root;database=burgerking;password=1234";
            var connection = new MySqlConnection(connectionString);
            try
            {
                //label1.Text = "Connected";
                connection.Open();

                string insertQuery = $"SELECT count(*) as cnt FROM member where id='{id}'";
                var command = new MySqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbid = reader["cnt"].ToString();
                    }

                    int result = int.Parse(dbid);
                    if (result >= 1)
                    {
                        MessageBox.Show("아이디가 중복 됩니다.");
                    }
                    else
                    {
                        string text = textBox_ID.Text;
                        idRegex(text);
                        //MessageBox.Show("" + passwordRegex(text));

                        if (idRegex(text) == true)
                        {
                            MessageBox.Show("사용 가능한 ID 입니다.");
                            //최종 id 확인
                            id_Checking = true;
                            canYouSignin();
                        }
                        else
                        {
                            MessageBox.Show("제약 조건을 만족 시키세요");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("db접근이 안됐습니다.");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                //label1.Text = "Disconnected";
            }
            connection.Close();
        }

        //비밀번호 확인 메서드
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string PW = textBox_PW.Text;
            string PW2 = textBox_DuCheck.Text;
            if (pwRegex(PW) == true)
            {
                if (PW == PW2)
                {
                    MessageBox.Show("확인되었습니다.");
                    pw_Checking = true;
                    canYouSignin();
                }
                else
                {
                    MessageBox.Show("비밀번호를 다시 확인하세요");
                }
            }
            else
            {
                MessageBox.Show("제약조건을 준수해 주세요");
            }
        }

        //id,pw 확인 후 회원가입 가능하게 하는 메서드
        private void canYouSignin()
        {
            if (id_Checking == true && pw_Checking == true)
            {
                gunaButton5.Enabled = true;
            }
        }
        // id 제약조건 확인
        public static bool idRegex(string text)
        {
            //영문, 숫자, 특수문자 포함 8-16 자리
            //Regex regex = new Regex(@"^(?=.*?[A-Za-z])(?=.*?\d)(?=.*?[~!@#$%^&*()-+=.]).{8,16}$");
            //영소,대, 숫자 포함 8-16자리
            Regex regex = new Regex(@"^(?=.*?[A-Za-z])(?=.*?\d).{8,16}$");

            Match match = regex.Match(text);
            return match.Success;
        }
        // pw 제약조건 확인
        public static bool pwRegex(string text)
        {
            //영문, 숫자, 특수문자 포함 8-20 자리
            Regex regex = new Regex(@"^(?=.*?[A-Za-z])(?=.*?\d)(?=.*?[~!@#$%^&*()-+=.]).{8,20}$");

            Match match = regex.Match(text);
            return match.Success;
        }
    }
}
