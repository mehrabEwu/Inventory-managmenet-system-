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
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterPage back = new MasterPage();
            back.Show();
            this.Hide();




        }

        

        private void invoice_Load(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = new OracleCommand("select distinct invoice_no from invoice");

            thisCommand.Connection = CN.thisConnection;
            thisCommand.CommandType = CommandType.Text;

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {
                invCombo.Items.Add(thisReader["invoice_no"].ToString());
            }
        }

        private void invCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT distinct * FROM invoice where invoice_no= '" + invCombo.Text + "'";

            OracleDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                invCombo.Text = thisReader["invoice_no"].ToString();
            }
            CN.thisConnection.Close();
        }

        public void fill_listbox()
        {
            listBox1.Items.Clear();


            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            thisCommand.CommandType = CommandType.Text;

            thisCommand.CommandText = "select  distinct customer.customer_name, mail_id, mobile_no, address from customer, invoice  where customer.customer_id=invoice.customer_id and invoice_no= '" + invCombo.Text + "'";

            thisCommand.ExecuteReader();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(thisCommand);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["customer_name"]).ToString();
                listBox1.Items.Add(dr["mail_id"]).ToString();
                listBox1.Items.Add(dr["mobile_no"]).ToString();
                listBox1.Items.Add(dr["address"]).ToString();
            }

            CN.thisConnection.Close();


        }

        private void view_Click(object sender, EventArgs e)
        {

            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * FROM invoice where invoice_no= '" + invCombo.Text + "'";

            OracleDataReader thisReader = thisCommand.ExecuteReader();
           if(!thisReader.Read())
            {
                MessageBox.Show("Invoive number not found..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CN.thisConnection.Close();
                return;
            }

            try
            {
                connection con = new connection();
                con.thisConnection.Open();

                OracleCommand thisCommand1 = con.thisConnection.CreateCommand();
                OracleCommand thisCommand2 = con.thisConnection.CreateCommand();

                thisCommand2.CommandText = "SELECT distinct sales_date from invoice where invoice_no= '" + invCombo.Text + "'";

                thisCommand1.CommandText = "SELECT distinct customer_id from invoice where invoice_no= '" + invCombo.Text + "'";

                OracleDataReader thisReader1 = thisCommand1.ExecuteReader();
                OracleDataReader thisReader2 = thisCommand2.ExecuteReader();

                if (thisReader1.Read())
                {
                    custID.Text = thisReader1["customer_id"].ToString();
               
                }
                if (thisReader2.Read())
                {
                    invDate.Text = thisReader2["sales_date"].ToString();
                }
                con.thisConnection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }

            fill_listbox();


            connection DB = new connection();
            DB.thisConnection.Open();

            OracleCommand thisCommand3 = DB.thisConnection.CreateCommand();

            thisCommand3.CommandText = "SELECT bill_amount,discount,sub_total from balance where invoice_no= '" + invCombo.Text + "'";

            OracleDataReader thisReader3 = thisCommand3.ExecuteReader();
            if(thisReader3.Read())
            {
                billAmnt.Text = thisReader3["bill_amount"].ToString();
                discount.Text = thisReader3["discount"].ToString();
                totalAmnt.Text = thisReader3["sub_total"].ToString();

            }
            DB.thisConnection.Close();

            ////////////////////////datagridview/////////////////////////////

            connection DB2 = new connection();
            DB2.thisConnection.Open();

            OracleDataAdapter thisAdapter5 = new OracleDataAdapter("select product_name, product_id, unit_price, quantity, vat, amount from invoice where invoice_no ='" + invCombo.Text + "'", DB2.thisConnection);

            DataTable data = new DataTable();

            thisAdapter5.Fill(data);
            dataGridView1.DataSource = data;
            DB2.thisConnection.Close();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;


        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }
    }
}
