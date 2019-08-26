using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();
            if (sby.Text == "Product_Name")
            {
                OracleDataAdapter thisAdapter = new OracleDataAdapter("Select product_name, product_id, production_date,unit_price,quantity from product where product_name like '" + textBox1.Text + "%'", CN.thisConnection);

                DataTable data = new DataTable();

                thisAdapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (sby.Text == "Product_ID")
            {
                OracleDataAdapter thisAdapter = new OracleDataAdapter("Select product_name, product_id, production_date,unit_price,quantity from product where product_id like '" + textBox1.Text + "%'", CN.thisConnection);

                DataTable data = new DataTable();

                thisAdapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            CN.thisConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.thisConnection.Open();
            OracleDataAdapter thisAdapter = new OracleDataAdapter("delete from product where product_id ='" + textBox2.Text + "'", con.thisConnection);
            thisAdapter.SelectCommand.ExecuteNonQuery();
            con.thisConnection.Close();
            MessageBox.Show("Product deleted successfully", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Clear();
            dataGridView1.ClearSelection();
            OracleDataAdapter mehrab = new OracleDataAdapter("Select product_name, product_id, production_date,unit_price,quantity from product", con.thisConnection);

            DataTable data = new DataTable();

            mehrab.Fill(data);
            dataGridView1.DataSource = data;


        }
       

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
