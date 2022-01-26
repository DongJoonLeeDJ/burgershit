using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ORDER_MENU
    {

        public string MENU { get; set; }
        public string USER_NAME { get; set; }
        public string HP { get; set; }
        public int SEQ { get; set; }
        public ORDER_MENU()
        {

        }
        public ORDER_MENU(string MENU, string USER_NAME, string HP, int SEQ)
        {
            this.MENU = MENU;
            this.USER_NAME = USER_NAME;
            this.HP = HP;
            this.SEQ = SEQ;
        }
    }
}
