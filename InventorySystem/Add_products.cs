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
    public partial class Add_products : Form
    {
        public Add_products()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Show();
            this.Hide();
        }
        private string generateID()
        {
            long i = 1;

            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }

            string number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);

            return number;
        }

        private void submit2_Click(object sender, EventArgs e)
        {
            if (productName.Text == "" || qty.Text == "")
            {

                MessageBox.Show("Required fill up the fields for entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            connection CN = new connection();
            CN.thisConnection.Open();

            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM product", CN.thisConnection);

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "product");

            DataRow thisRow = thisDataSet.Tables["product"].NewRow();

            int a;
           
            try
            {


                thisRow["product_name"] = productName.Text;
                thisRow["product_id"] = generateID();
                thisRow["production_date"] = dateTimePicker1.Value.Date.ToString();
                thisRow["category"] = catCombBox.Text;
                thisRow["unit_price"] = unitPrice.Text;
                thisRow["quantity"] = qty.Text;
                thisRow["vat"] = vat.Text;
                thisRow["description"] = descrp.Text;



                thisDataSet.Tables["product"].Rows.Add(thisRow);

                a=thisAdapter.Update(thisDataSet, "product"); 

                if(a==1)
                MessageBox.Show("New product added", "INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                productName.Text = "";
                unitPrice.Clear();
                qty.Clear();
                vat.Clear();
                descrp.Clear();
                productName.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            CN.thisConnection.Close();
        }


    }
}
