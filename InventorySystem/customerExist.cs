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
    public partial class customerExist : Form
    {
        public customerExist()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerForm cus = new customerForm();
            cus.Show();
            this.Hide();
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            connection CN = new connection();
            CN.thisConnection.Open();
            if (sBy.Text == "CUSTOMER_ID")
            {
                OracleDataAdapter thisAdapter = new OracleDataAdapter("Select customer_id, customer_name,mail_id, mobile_no,address from customer where CUSTOMER_ID like '"+textBox1.Text + "%'", CN.thisConnection);

                DataTable data = new DataTable();

                thisAdapter.Fill(data);
                dataGridView1.DataSource = data;
            }
           else if (sBy.Text == "CUSTOMER_NAME")
            {
                OracleDataAdapter thisAdapter = new OracleDataAdapter("Select customer_id, customer_name, mail_id, mobile_no,address from customer where CUSTOMER_NAME like '" + textBox1.Text + "%'", CN.thisConnection);

                DataTable data = new DataTable();

                thisAdapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (sBy.Text == "MOBILE_NO")
            {
                OracleDataAdapter thisAdapter = new OracleDataAdapter("Select customer_id, customer_name, mail_id, mobile_no,address from customer where mobile_no like '" + textBox1.Text + "%'", CN.thisConnection);

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
            OracleDataAdapter thisAdapter = new OracleDataAdapter("delete from customer where customer_id ='" + textBox2.Text + "'", con.thisConnection);
            thisAdapter.SelectCommand.ExecuteNonQuery();
            con.thisConnection.Close();
            MessageBox.Show("Customer deleted successfully", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Clear();
            dataGridView1.ClearSelection();
            connection con1 = new connection();
            OracleDataAdapter mehrab = new OracleDataAdapter("Select * from customer", con1.thisConnection);

            DataTable data = new DataTable();

            mehrab.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

        }

       
    }
}
