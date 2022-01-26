using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class DataManager
    {

        public static MySqlConnection Myconn = new MySqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        const string TABLE = "menu";

        public static List<Menu> menulist = new List<Menu>(); //전체 햄버거 리스트(모든 값)
        public static List<Menu> myList = new List<Menu>(); //내가 선택한 것들 값

        const string TABLE2 = "ORDER_MENU";
        public static List<ORDER_MENU> ORDERList = new List<ORDER_MENU>();

        public static void ConnectDB()
        {
            try
            {
                string pwd = "1234";
                string strConn = "Server=localhost;Database=burgerking;Uid=root;Pwd=" + pwd + ";Charset=utf8";
                Myconn = new MySqlConnection(strConn);
                Myconn.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //select문으로 테이블 조회하기
        public static void selectQuery(string condition = null)
        {
            ConnectDB();

            string sql;
            // sql = "select * from " + TABLE + " where bnum="+ (int)BURGER.Gines +" order by rownum";
            sql = "select * from " + TABLE + " order by rownum";
            //if (condition != null)
            //{
            //    sql = "select * from " + TABLE + $" where category={condition} order by rownum";
            //}

            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = Myconn.CreateCommand();
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds, TABLE);

            menulist.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                string name = (item["name"].ToString());
                string price = (item["price"].ToString());
                string category = (item["category"].ToString());
                int.TryParse(item["rownum"].ToString(), out int rownum);

                Menu ml = new Menu(name, price, category, rownum);
                menulist.Add(ml);
            }

            Myconn.Close();
        }
        public static void ordermenu(string condition = null)
        {
            ConnectDB();

            string sql;
            // sql = "select * from " + TABLE + " where bnum="+ (int)BURGER.Gines +" order by rownum";
            sql = "select * from " + TABLE2 + " order by menu";
            //if (condition != null)
            //{
            //    sql = "select * from " + TABLE + $" where category={condition} order by rownum";
            //}

            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = Myconn.CreateCommand();
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds, TABLE2);

            menulist.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                string MENU = (item["MENU"].ToString());
                string USER_NAME = (item["USER_NAME"].ToString());
                string HP = (item["HP"].ToString());
                int.TryParse(item["SEQ"].ToString(), out int SEQ);

                ORDER_MENU om = new ORDER_MENU(MENU, USER_NAME, HP, SEQ);
                ORDERList.Add(om);
            }

            Myconn.Close();
        }

        ////특정한 공간에 이미 주차되어 있거나 출차되어 있는 걸
        ////체크 하기 위해서 한 군데의 상태를 조회하는 함수
        ////위의 selectQuery랑 이름은 똑같으나 매개변수가 다르므로 다른 함수로 취급(=오버로딩)
        //public static ParkingCar selectQuery(int spot)
        //{
        //    ConnectDB();

        //    string sql;
        //    sql = "select * from " + TABLE + " where parkingSpot=" + spot + " order by to_number(parkingspot)"; //테이블을 조회하되, 주차공간번호를 기준으로 조회

        //    OracleDataAdapter oda = new OracleDataAdapter();
        //    oda.SelectCommand = new OracleCommand();
        //    oda.SelectCommand.Connection = OraConn;
        //    oda.SelectCommand.CommandText = sql; //select문을 날린 거

        //    DataSet ds = new DataSet();
        //    oda.Fill(ds, TABLE);

        //    DataRow item = ds.Tables[0].Rows[0];
        //    ParkingCar car = new ParkingCar();
        //    car.ParkingSpot = int.Parse(item["parkingSpot"].ToString());
        //    car.CarNumber = item["CarNumber"].ToString();
        //    car.DriverName = item["DriverName"].ToString();
        //    car.PhoneNumber = item["PhoneNumber"].ToString();
        //    //ParkingTime 컬럼에 아무것도 없다면 ParkingTime 속성에 new DateTime()//(현재시간) 삽입
        //    //아니면 테이블에서 읽어온 값 그대로 삽입
        //    car.ParkingTime = item["ParkingTime"].ToString()
        //        == "" ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());

        //    OraConn.Close();
        //    return car;
        //}

        //static string Query(string menu, string parkingSpot, string carNumber, string driverName, string phoneNumber)
        //{
        //    string query = "";
        //    switch (menu)
        //    {
        //        case "update":
        //            query = $"update {TABLE} set CarNumber='{carNumber}', DriverName='{driverName}', " +
        //                $"phoneNumber='{phoneNumber}', parkingTime=sysdate where parkingspot={parkingSpot}";
        //            break;
        //        case "insert":
        //            query = $"insert into {TABLE} (parkingspot) values({parkingSpot})";
        //            break;
        //        case "delete":
        //            query = $"delete from {TABLE} where parkingSpot={parkingSpot}";
        //            break;
        //        default:

        //            break;
        //    }
        //    return query;
        //}



    }
}
