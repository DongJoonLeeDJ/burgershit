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
    public partial class Form2 : Form
    {
        Menu select;
        public Form2(Menu m)
        {
            select = m;
            int idx = select.rownum - 1;
            select.name = DataManager.menulist[idx].name + "(세트)";
            select.price = (int.Parse(DataManager.menulist[idx].price) + 2000).ToString();
            select.category = DataManager.menulist[idx].category;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
