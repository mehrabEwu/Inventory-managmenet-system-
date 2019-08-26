using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add_products add = new Add_products();
            add.Show();
            this.Hide();

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterPage M = new MasterPage();
            M.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewAllPro view = new viewAllPro();
            view.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatePro upd = new updatePro();
            upd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteProduct delp = new DeleteProduct();
            delp.Show();
            this.Hide();
        }
    }
}
