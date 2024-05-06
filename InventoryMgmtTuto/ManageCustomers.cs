using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMgmtTuto
{
    public partial class ManageCustomers : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=60");
        public ManageCustomers()
        {
            InitializeComponent();
            dataGridViewCustomer.EnableHeadersVisualStyles = false;
            dataGridViewCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridViewCustomer.RowHeadersVisible = false;

            fillGrid();
        }

        private void ManageCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fillGrid()
        {
            try
            {
                txtCustomerId.Text = "";
                txtCustomerName.Text = "";
                txtCustomerPhone.Text = "";

                Con.Open();
                string Myquery = "Select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Con.Close();
                dataGridViewCustomer.DataSource = ds.Tables[0];

            }
            catch { }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + txtCustomerId.Text + "','" + txtCustomerName.Text + "','" + txtCustomerPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                fillGrid();
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustId = '" + txtCustomerId.Text + "', CustName ='" + txtCustomerName.Text + "', CustPhone = '" + txtCustomerPhone.Text + "' where CustId = '" + txtCustomerId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                fillGrid();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "")
            {
                MessageBox.Show("Enter the Customers Id");
            }
            else
            {
                Con.Open();
                string myquery = "Delete from CustomerTbl where CustId = '" + txtCustomerId.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                fillGrid();
            }
        }



        private void dataGridViewUser_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = dataGridViewCustomer.SelectedCells[0].Value.ToString();
            txtCustomerName.Text = dataGridViewCustomer.SelectedCells[1].Value.ToString();
            txtCustomerPhone.Text = dataGridViewCustomer.SelectedCells[2].Value.ToString();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM OrderTbl WHERE CustId = " + txtCustomerId.Text + "", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            labelOrdersCount.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Sum(TotalAmt) FROM OrderTbl WHERE CustId = " + txtCustomerId.Text + "", Con);

            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            labelOrdersAmount.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Max(OderDate) FROM OrderTbl WHERE CustId = " + txtCustomerId.Text + "", Con);

            DataTable dt2 = new DataTable();
            sda1.Fill(dt2);
            labelLastOrderDate.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}

