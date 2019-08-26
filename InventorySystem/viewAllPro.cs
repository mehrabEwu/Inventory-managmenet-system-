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
    public partial class viewAllPro : Form
    {
        public viewAllPro()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product main = new Product();
            main.Show();
            this.Hide();

        }

        private void viewAllPro_Load(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * FROM product order by product_name";

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = thisReader["product_name"].ToString();
                lsvItem.SubItems.Add(thisReader["Product_id"].ToString());
                lsvItem.SubItems.Add(thisReader["production_date"].ToString());
                lsvItem.SubItems.Add(thisReader["category"].ToString());
                lsvItem.SubItems.Add(thisReader["unit_price"].ToString());
                lsvItem.SubItems.Add(thisReader["QUANTITY"].ToString());
                lsvItem.SubItems.Add(thisReader["sale_product"].ToString());
                lsvItem.SubItems.Add(thisReader["vat"].ToString());
                lsvItem.SubItems.Add(thisReader["description"].ToString());




                listView1.Items.Add(lsvItem);
            }


            CN.thisConnection.Close();
        }
    }
}
