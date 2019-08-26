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
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void customer_Click(object sender, EventArgs e)
        {
           
            customerForm mas = new customerForm();
            mas.Show();
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
             pro.Show();
             this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sell se = new Sell();
            se.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            invoice op = new invoice();
            op.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
            this.Hide();
        }
    }
}
