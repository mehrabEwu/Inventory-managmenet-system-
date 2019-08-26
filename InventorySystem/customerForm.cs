using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace InventorySystem
{
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }

   

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterPage main = new MasterPage();
            main.Show();
        }

        

        private void view_Click(object sender, EventArgs e)
        {
            

            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText =
                "SELECT * FROM customer order by customer_name ";

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = thisReader["customer_name"].ToString();
                lsvItem.SubItems.Add(thisReader["customer_id"].ToString());
                lsvItem.SubItems.Add(thisReader["mail_id"].ToString());
                lsvItem.SubItems.Add(thisReader["mobile_no"].ToString());
                lsvItem.SubItems.Add(thisReader["address"].ToString());


            

                listView1.Items.Add(lsvItem);
            }


            CN.thisConnection.Close();
            
            
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerExist ex = new customerExist();
            ex.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            customerEntry entry = new customerEntry();
            entry.Show();
            this.Hide();
        }

        private void clear_dClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        
 
        
    }
}
