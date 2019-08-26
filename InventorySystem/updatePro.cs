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
    public partial class updatePro : Form
    {
        public updatePro()
        {
            InitializeComponent();
        }

        private void enter_TextChanged(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();
            if (sBy.Text == "Product_Name")
            {
                OracleDataAdapter thisAdapter = new OracleDataAdapter("Select product_name, product_id, production_date,unit_price,quantity from product where product_name like '" + enter.Text + "%'", CN.thisConnection);

                DataTable data = new DataTable();

                thisAdapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (sBy.Text == "Product_ID")
            {
                OracleDataAdapter thisAdapter = new OracleDataAdapter("Select product_name, product_id, production_date,unit_price,quantity from product where product_id like '" + enter.Text + "%'", CN.thisConnection);

                DataTable data = new DataTable();

                thisAdapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            CN.thisConnection.Close();


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            oldQtyBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            newPriceBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            int newItems = int.Parse(newQtyBox.Text);
            if (newQtyBox.Text == "")
                newItems = 0;
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText = "update product set quantity=quantity+" + newItems + ", unit_price='" + newPriceBox.Text + "'where product_id= '" + idBox.Text + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;
            try
            {
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Stock Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            sv.thisConnection.Close();

            


        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product back = new Product();
            back.Show();
            this.Hide();


        }
    }
}
