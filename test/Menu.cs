using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Menu
    {
        //private string _id;
        //public string id { get { return _id; } set { _id = value; } }
        public string name { get; set; }
        public string price { get; set; }
        public string category { get; set; }
        public int rownum { get; set; }
        public Menu()
        {

        }
        public Menu(string name, string price, string category, int rownum)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.rownum = rownum;
        }
    }
}
