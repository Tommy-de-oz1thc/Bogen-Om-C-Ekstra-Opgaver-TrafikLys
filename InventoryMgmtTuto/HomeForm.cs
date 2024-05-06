using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMgmtTuto
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Hide the login form
            this.Hide();

            ManageProducts pro = new ManageProducts();
            pro.ShowDialog();

            // Show the login form again after the admin or user form is closed

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            ManageCustomers cust = new ManageCustomers();
            cust.ShowDialog();

            // Show the login form again after the admin or user form is closed

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            ManageCategories cat = new ManageCategories();
            cat.ShowDialog();

            // Show the login form again after the admin or user form is closed

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            ManageUsers user = new ManageUsers();
            user.ShowDialog();

            // Show the login form again after the admin or user form is closed

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            ManageOrders orders = new ManageOrders();
            orders.ShowDialog();

            // Show the login form again after the admin or user form is closed

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
