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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryMgmtTuto
{
    public partial class ManageOrders : Form
    {
        string[] months = new string[] { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        int num = 0;
        int flag = 0;
        int stock = 0;
        int uprice, totprice, qty;
        string product;
        DataTable table = new DataTable();
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=60");
        int sum = 0;
        public ManageOrders()
        {
            InitializeComponent();
            fillGridCustomer();
            fillGridProduct();
            fillCategory();
            dataGridViewCustomer.EnableHeadersVisualStyles = false;
            dataGridViewCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridViewCustomer.RowHeadersVisible = false;
            dataGridViewProduct.EnableHeadersVisualStyles = false;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridViewProduct.RowHeadersVisible = false;
            dataGridViewOrder.EnableHeadersVisualStyles = false;
            dataGridViewOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridViewOrder.RowHeadersVisible = false;
            string date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string[] new_date = date.Split('-');
            int num = int.Parse(new_date[1]);
            textBoxOrderDate.Text = $"{new_date[0]} - {months[num]} - {new_date[2]}";
            textBoxOrderDate.Click += TextBoxOrderDate_Click;

            // Definer kolonnene i DataTable
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Unit Price", typeof(int));
            table.Columns.Add("Total Price", typeof(int));
        }

        private void TextBoxOrderDate_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            textBoxOrderDate.Visible = false;
            // Åpne DateTimePicker-kontrollen
            dateTimePicker1.Focus();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Kopier teksten fra DateTimePicker til TextBox
            string date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string[] new_date = date.Split('-');
            int num = int.Parse(new_date[1]);
            textBoxOrderDate.Text = $"{new_date[0]} - {months[num]} - {new_date[2]}";
            dateTimePicker1.Visible = false;
            textBoxOrderDate.Visible = true;
        }
        private void fillGridCustomer()
        {
            try
            {

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

        private void fillCategory()
        {
            string query = "Select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBoxCategory.ValueMember = "CatName";
                comboBoxCategory.DataSource = dt;
                comboBoxCategory.ValueMember = "CatName";
                comboBoxCategory.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }
        private void fillGridbyFilter()
        {
            try
            {

                Con.Open();
                string Myquery = "Select * from ProductTbl where ProdCat = '" + comboBoxCategory.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Con.Close();
                dataGridViewProduct.DataSource = ds.Tables[0];

            }
            catch { }

        }
        private void fillGridProduct()
        {
            try
            {

                Con.Open();
                string Myquery = "Select * fromOrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Con.Close();
                dataGridViewProduct.DataSource = ds.Tables[0];

            }
            catch { }

        }

        private void dataGridViewCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = dataGridViewCustomer.SelectedRows[0].Cells[0].Value.ToString();
            txtCustomerName.Text = dataGridViewCustomer.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridViewProduct_Click(object sender, EventArgs e)
        {
            product = dataGridViewProduct.SelectedRows[0].Cells[1].Value.ToString();
            stock = Convert.ToInt32(dataGridViewProduct.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(dataGridViewProduct.SelectedRows[0].Cells[3].Value.ToString());

            totprice = qty * uprice;

            flag = 1;
        }
        private void updateStock()
        {

            int id = Convert.ToInt32(dataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString());
            int new_Qty = stock - Convert.ToInt32(txtQty.Text);
            if (new_Qty < 0)
            { MessageBox.Show("Operation Failed"); }
            else
            {

                Con.Open();
                string query = "update ProductTbl set ProdQty = " + new_Qty + " where ProdId = " + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                fillGridProduct();
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGridbyFilter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                MessageBox.Show("Enter The Quantity of Products");
            }
            else if (flag == 0)
            { MessageBox.Show("Select The Product"); }
            if (Convert.ToInt32(txtQty.Text) > stock)
            { MessageBox.Show("Not Enought Stock Avarible"); }
            else
            {
                num += 1;
                qty = Convert.ToInt32(txtQty.Text);
                totprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totprice);
                dataGridViewOrder.DataSource = table;
                flag = 0;
            }
            sum = sum + totprice;
            labelTotAmount.Text = sum.ToString();
            updateStock();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderId.Text == "" || txtCustomerId.Text == "" || txtCustomerName.Text == "" || labelTotAmount.Text == "")
            {
                MessageBox.Show("Fill The data Correctly");
            }
            else
            {
                try
                {
                    Con.Open();
                    DateTime date = DateTime.Now;
                    string formattedDate = date.ToString("dd-MM-yyyy");

                    SqlCommand cmd = new SqlCommand("insert into OrderTbl values('" + txtOrderId.Text + "','" + txtCustomerId.Text + "','" + txtCustomerName.Text + "','" + formattedDate + "','" + labelTotAmount.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Successfully Added");
                    Con.Close();
                    fillGridProduct();
                }
                catch
                {

                }
            }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void ManageOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}


