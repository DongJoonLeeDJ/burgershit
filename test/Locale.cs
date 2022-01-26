using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Locale
    {
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; private set; } // 수정안되고 get만 가능
        public double Distance { get; set; }

        public Locale(string name, double lat, double lng, int dis)
        {
            Name = name;
            Lat = lat;
            Lng = lng;
            Distance = dis;
        }

        public override string ToString()
        {
            //return string.Format("{0} 그리고 {1}", Name, Distance);
            //return Name + " 그리고 " + Distance;
            Distance = Math.Round((Distance / 1000), 2);
            return $"{Name}(거리 : {Distance}km)";
            //return base.ToString();
        }
    }
}
