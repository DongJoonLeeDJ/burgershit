using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace test
{
    public class KakaoAPI
    {
        public static List<Locale> Search(string qstr = null)
        {
            List<Locale> mls = new List<Locale>();
            String distance = "10000";//qstr;
            string query = $"https://dapi.kakao.com/v2/local/search/keyword.json?page=1&query=%EB%B2%84%EA%B1%B0%ED%82%B9&y=35.877015&x=128.626125&sort=distance&radius={distance}&size=5";
            WebRequest request = WebRequest.Create(query);

            string rKey = "7923627f3aaa3f9e15cd3cb9ee172289"; // REST API KEY
            string header = "KakaoAK " + rKey;
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;

            for (int i = 0; i < length; i++)
            {
                string lname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                int dis = int.Parse(docs[i]["distance"]);
                mls.Add(new Locale(lname, y, x, dis));
            }
            return mls;
        }
    }
}
