using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hafala_Hub
{
    public partial class Sched_n__List : Form
    {
        public Sched_n__List()
        {
            InitializeComponent();
        }

        private void Sched_n__List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactList1DataSet1.ContactList' table. You can move, or remove it, as needed.
            this.contactListTableAdapter.Fill(this.contactList1DataSet1.ContactList);
            
            
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ContactList1.mdf;Integrated Security=True";
            string select = "SELECT * FROM ContactList;";
            SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
