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
    public partial class Sell : Form
    {
        public float amount;
        public Sell()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterPage main = new MasterPage();
            main.Show();
            this.Hide();
        }



        private void custIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * FROM customer where customer_id= '" + custIDCombo.Text + "'";

            OracleDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                custNmCombo.Text = thisReader["Customer_name"].ToString();
            }
            CN.thisConnection.Close();
        }

        private void custNmCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * FROM customer where customer_name= '" + custNmCombo.Text + "'";

            OracleDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                custIDCombo.Text = thisReader["Customer_id"].ToString();
            }
            CN.thisConnection.Close();

        }

        private void pIDComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * FROM product where product_id= '" + pIDComb.Text + "'";

            OracleDataReader thisReader1 = thisCommand.ExecuteReader();
            while (thisReader1.Read())
            {
                pNmCombo.Text = thisReader1["product_name"].ToString();
                unitP.Text = thisReader1["unit_price"].ToString();
                vat.Text = thisReader1["vat"].ToString();
                avlQty.Text = thisReader1["quantity"].ToString();
            }
            CN.thisConnection.Close();
        }

        private void pNmCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * FROM product where product_name= '" + pNmCombo.Text + "'";

            OracleDataReader thisReader2 = thisCommand.ExecuteReader();
            while (thisReader2.Read())
            {
                pIDComb.Text = thisReader2["product_id"].ToString();
                unitP.Text = thisReader2["unit_price"].ToString();
                vat.Text = thisReader2["vat"].ToString();
                avlQty.Text = thisReader2["quantity"].ToString();

            }
            CN.thisConnection.Close();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = new OracleCommand("select customer_id from customer");

            thisCommand.Connection = CN.thisConnection;
            thisCommand.CommandType = CommandType.Text;

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {
                custIDCombo.Items.Add(thisReader["customer_id"].ToString());
            }


            OracleCommand thisCommand1 = new OracleCommand("select customer_name from customer");

            thisCommand1.Connection = CN.thisConnection;
            thisCommand1.CommandType = CommandType.Text;

            OracleDataReader thisReader1 = thisCommand1.ExecuteReader();


            while (thisReader1.Read())
            {
                custNmCombo.Items.Add(thisReader1["customer_name"].ToString());
            }

            OracleCommand thisCommand2 = new OracleCommand("select product_id from product");

            thisCommand2.Connection = CN.thisConnection;
            thisCommand2.CommandType = CommandType.Text;

            OracleDataReader thisReader2 = thisCommand2.ExecuteReader();


            while (thisReader2.Read())
            {
                pIDComb.Items.Add(thisReader2["product_id"].ToString());
            }

            OracleCommand thisCommand3 = new OracleCommand("select product_name from product");

            thisCommand3.Connection = CN.thisConnection;
            thisCommand3.CommandType = CommandType.Text;

            OracleDataReader thisReader3 = thisCommand3.ExecuteReader();


            while (thisReader3.Read())
            {
                pNmCombo.Items.Add(thisReader3["product_name"].ToString());
            }

            CN.thisConnection.Close();
        }

        private void addCart_Click(object sender, EventArgs e)
        {
           // if()
            //{ }
            float pr = float.Parse(unitP.Text);
            int vt = int.Parse(vat.Text);
            if (qty.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(qty.Text, "[^0-9]"))
            {
                qty.BackColor = Color.Red;
                MessageBox.Show("Invalid Input(Enter the quantity as valid)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
        

            int avlq = int.Parse(avlQty.Text);
            int qt = int.Parse(qty.Text);
            if (avlq >= qt && avlq!=0)
            {
                amount = (pr * qt) + (((pr * qt) * vt) / 100);
                int row = 0;
                try
                {

                    dataGridView1.Rows.Add();
                    row = dataGridView1.Rows.Count - 2;
                    dataGridView1["pID", row].Value = pIDComb.SelectedItem.ToString();
                    dataGridView1["pName", row].Value = pNmCombo.SelectedItem.ToString();


                    dataGridView1["quant", row].Value = qty.Text;
                    dataGridView1["UnitPrice", row].Value = unitP.Text;
                    dataGridView1["vta", row].Value = vat.Text;
                    dataGridView1["ammnt", row].Value = amount;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Out of Stock ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(custNmCombo.Text=="")
            {
                MessageBox.Show("Customer Information Needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double sum = 0.0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);



            }
            billAmnt.Text = sum.ToString();
        }

        private void bill_Click(object sender, EventArgs e)
        {


            if (discount.Text == "")
            {
                try
                {
                    float finalAm = float.Parse(billAmnt.Text);

                    totalAm.Text = finalAm.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
            else
            {
                try
                {
                    float dis = float.Parse(discount.Text);
                    float finalAm = float.Parse(billAmnt.Text);

                    float value = finalAm - ((finalAm * dis) / 100);
                    totalAm.Text = value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ///////////////////////////////////////////Product stock UpDATE after selling//////////////////////////////////////////////////////////////
            if (totalAm.Text != "")
            {
                int saleItem=0;
                string pid;
                connection sv = new connection();
                sv.thisConnection.Open();
                OracleCommand thisCommand = sv.thisConnection.CreateCommand();

                for (int i=0; i<dataGridView1.Rows.Count-1;i++)
                {
                    saleItem = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    pid = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    thisCommand.Connection = sv.thisConnection;
                    thisCommand.CommandType = CommandType.Text;

                    thisCommand.CommandText = "update product set quantity=quantity-" + saleItem + "where product_id= '" + pid + "'";
                    try
                    {
                        thisCommand.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }

                }
                

                
                
                sv.thisConnection.Close();
            }
            //////////////////////////end/////////////////////////////////////////////////////////
            string inv, rif,meh;
            rif = DateTime.Now.ToString("yy-MM-dd-HHmmss");
            meh = "IN";
            inv = String.Concat(rif, meh);
            invNO.Text = inv;

            ///////////////////////sales entry//////////////////////

            connection db = new connection();
            db.thisConnection.Open();

            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM sell", db.thisConnection);

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "sell");

            for(int i=0; i<dataGridView1.Rows.Count-1; i++)
            {
                DataRow thisRow = thisDataSet.Tables["sell"].NewRow();
                try
                {;


                    thisRow["invoice_no"] = inv;
                    thisRow["CUSTOMER_ID"] = custIDCombo.Text;
                    thisRow["amount"] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    thisRow["product_id"] = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    thisRow["product_name"] = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    thisRow["quantity"] = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    thisRow["sales_date"] = invDTPicker.Value.Date.ToString();


           
                   


                    thisDataSet.Tables["sell"].Rows.Add(thisRow);



                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            thisAdapter.Update(thisDataSet, "sell");
            db.thisConnection.Close();

            ////////////////////////////////invoice_entry/////////////////////////////
            connection db1 = new connection();
            db1.thisConnection.Open();

            OracleDataAdapter thisAdapter1 = new OracleDataAdapter("SELECT * FROM invoice", db1.thisConnection);

            OracleCommandBuilder thisBuilder1 = new OracleCommandBuilder(thisAdapter1);
            DataSet thisDataSet1 = new DataSet();
            thisAdapter1.Fill(thisDataSet1, "invoice");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataRow thisRow1 = thisDataSet1.Tables["invoice"].NewRow();
                try
                {
                    


                    thisRow1["invoice_no"] = inv;
                    thisRow1["CUSTOMER_ID"] = custIDCombo.Text;
                    thisRow1["Customer_name"] = custNmCombo.Text;
                    thisRow1["amount"] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    thisRow1["product_id"] = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    thisRow1["product_name"] = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    thisRow1["quantity"] = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    thisRow1["unit_price"] = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    thisRow1["vat"] = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                    thisRow1["sales_date"] = invDTPicker.Value.Date.ToString();



                    thisDataSet1.Tables["invoice"].Rows.Add(thisRow1);

                    thisAdapter1.Update(thisDataSet1, "invoice");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
           
            db1.thisConnection.Close();

            /////////////////////balance table entry////////////////////////
            connection db2 = new connection();
            db2.thisConnection.Open();
            if (discount.Text == "")
            {
                int val = 0;
                discount.Text = val.ToString();
            }


            OracleDataAdapter thisAdapter2 = new OracleDataAdapter("SELECT * FROM balance", db2.thisConnection);

            OracleCommandBuilder thisBuilder2 = new OracleCommandBuilder(thisAdapter2);
            DataSet thisDataSet2 = new DataSet();
            thisAdapter2.Fill(thisDataSet2, "balance");

           
                DataRow thisRow2 = thisDataSet2.Tables["balance"].NewRow();
                try
                {

                   double bill= Convert.ToDouble(billAmnt.Text);
                // MessageBox.Show(bill.ToString());

                   thisRow2["INVOICE_NO"] = inv;
                   thisRow2["BILL_AMOUNT"] = bill;
                   thisRow2["discount"] = Convert.ToDouble(discount.Text);
                   thisRow2["sub_total"] = Convert.ToDouble(totalAm.Text);





                    thisDataSet2.Tables["balance"].Rows.Add(thisRow2);


                thisAdapter2.Update(thisDataSet2, "balance");
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

           
            
            db2.thisConnection.Close();




            MessageBox.Show("Items are Sold\nThank You", "$SOLD$", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void label13_Click(object sender, EventArgs e)
        {
            custIDCombo.ResetText();
            custNmCombo.ResetText();
            pIDComb.ResetText();
            pNmCombo.ResetText();
            unitP.Clear();
            qty.Clear();
            avlQty.Clear();
            vat.Clear();
            billAmnt.Clear();
            invNO.Clear();
            totalAm.Clear();
            discount.Clear();
            dataGridView1.Rows.Clear();




        }

        private void printPreview_Click(object sender, EventArgs e)
        {
            DVprintPreviewDialog1.Document = DVprintDocument1;
            DVprintPreviewDialog1.ShowDialog();


        }

        private void DVprintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("INVOICE #" + invNO.Text, new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(230, 45));

            e.Graphics.DrawString("Invoice Date : " + invDTPicker.Value.Date.ToString(), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(10, 110));

            e.Graphics.DrawString("Customer Name : " + custNmCombo.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 150));

            e.Graphics.DrawString("Customer ID : " + custIDCombo.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            //e.Graphics.DrawString("Customer ID : " + custIDCombo.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 180));


            ////////////////////De4sign//////////////////
            e.Graphics.DrawString("Product ID", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 285));
            e.Graphics.DrawString("Product Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(168, 285));
            e.Graphics.DrawString("Qty", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(345, 285));
            e.Graphics.DrawString("Unit Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 285));
            e.Graphics.DrawString("Vat", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(505, 285));
            e.Graphics.DrawString("Amount", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 285));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(0, 300));

            int ypos = 330, xpos = 25;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(xpos, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(168, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(345, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(400, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(505, ypos));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(555, ypos));
                ypos = ypos + 40;

            }
            if (ypos>=700&&ypos<=730 )
            {
                e.Graphics.DrawString("Bill Amount : " + billAmnt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(505, 860));
                e.Graphics.DrawString("Discount : " + discount.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(505, 890));
                e.Graphics.DrawString("TOTAL : " + totalAm.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(505, 920));
                e.Graphics.DrawString("---------------------------", new Font("Arial", 13, FontStyle.Italic), Brushes.Black, new Point(25, 1015));
                e.Graphics.DrawString("Customer Signature", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 1035));
                e.Graphics.DrawString("---------------------------", new Font("Arial", 13, FontStyle.Italic), Brushes.Black, new Point(540, 1017));
                e.Graphics.DrawString("Seller Signature", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 1035));
            }
            else
            {
                e.Graphics.DrawString("Bill Amount : " + billAmnt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(505, 675));
                e.Graphics.DrawString("Discount : " + discount.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(505, 705));
                e.Graphics.DrawString("TOTAL : " + totalAm.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(505, 735));
                e.Graphics.DrawString("---------------------------", new Font("Arial", 13, FontStyle.Italic), Brushes.Black, new Point(25, 830));
                e.Graphics.DrawString("Customer Signature", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 850));
                e.Graphics.DrawString("---------------------------", new Font("Arial", 13, FontStyle.Italic), Brushes.Black, new Point(540, 830));
                e.Graphics.DrawString("Seller Signature", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 850));
            }
        }


        private void PrintDoc_Click(object sender, EventArgs e)
        {
            DVprintDocument1.Print();
        }
    }
    }
    
