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
    public partial class customerEntry : Form
    {
        public customerEntry()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            customerForm cus = new customerForm();
            cus.Show();
            this.Hide();
        }
       

        private void submit_Click(object sender, EventArgs e)
        {
     
            if (custName.Text =="" || mNo.Text == "")
            {
                MessageBox.Show("Required fill up all the fields for entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            
                connection sv = new connection();
                 sv.thisConnection.Open();

                OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM customer", sv.thisConnection);

                OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "customer");



            

                 DataRow thisRow = thisDataSet.Tables["customer"].NewRow();
                try
                {
                string cusid, dn;
                string ex = "C";
                dn= DateTime.Now.ToString("HHmmss-MM-dd-yy");
                cusid = String.Concat(dn,ex);
                thisRow["CUSTOMER_NAME"] = custName.Text;
                thisRow["CUSTOMER_ID"] = cusid;
                    thisRow["MAIL_ID"] = mailID.Text;
                    thisRow["MOBILE_NO"] = mNo.Text;
                    thisRow["ADDRESS"] = address.Text;



                    thisDataSet.Tables["customer"].Rows.Add(thisRow);



                    thisAdapter.Update(thisDataSet, "customer");
                    MessageBox.Show("New customer added","Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    custName.Text = "";
                   
                    mailID.Clear();
                    mNo.Clear();
                    address.Clear();
                    custName.Focus();




                }
                catch
                {
                    MessageBox.Show("Insert error in database");
                }
                sv.thisConnection.Close();
               
  
        }



    }
}
