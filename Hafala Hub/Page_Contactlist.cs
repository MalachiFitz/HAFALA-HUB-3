using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafala_Hub
{
    public partial class Page_Contactlist : UserControl
    {
        public Page_Contactlist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sched_n__List sched = new Sched_n__List();
            sched.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
