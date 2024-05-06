using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryMgmtTuto
{
    public partial class ManageProducts : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=60");
        public ManageProducts()
        {
            InitializeComponent();
            dataGridViewProduct.EnableHeadersVisualStyles = false;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridViewProduct.RowHeadersVisible = false;

            fillCategory();

            fillGrid();
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
                comboBoxSeach.ValueMember = "CatName";
                comboBoxSeach.DataSource = dt;
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
                txtProductId.Text = "";
                txtProductName.Text = "";
                txtProductQty.Text = "";
                txtProductPrice.Text = "";
                txtProductDescription.Text = "";
                Con.Open();
                string Myquery = "Select * from ProductTbl where ProdCat = '" + comboBoxSeach.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Con.Close();
                dataGridViewProduct.DataSource = ds.Tables[0];

            }
            catch { }

        }
        private void fillGrid()
        {
            try
            {
                txtProductId.Text = "";
                txtProductName.Text = "";
                txtProductQty.Text = "";
                txtProductPrice.Text = "";
                txtProductDescription.Text = "";
                Con.Open();
                string Myquery = "Select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Con.Close();
                dataGridViewProduct.DataSource = ds.Tables[0];

            }
            catch { }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + txtProductId.Text + "','" + txtProductName.Text + "','" + txtProductQty.Text + "','" + txtProductPrice.Text + "','" + txtProductDescription.Text + "','" + comboBoxCategory.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
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
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdId = '" + txtProductId.Text + "', ProdName ='" + txtProductName.Text + "', ProdQty = '" + txtProductQty.Text + "', ProdPrice = '" + txtProductPrice.Text + "', ProdDesc = '" + txtProductDescription.Text + "', ProdCat = '" + comboBoxCategory.SelectedValue.ToString() + "' where ProdId = '" + txtProductId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                fillGrid();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text == "")
            {
                MessageBox.Show("Enter the ProdutId");
            }
            else
            {
                Con.Open();
                string myquery = "Delete from ProductTbl where ProdId = '" + txtProductId.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                fillGrid();
            }
        }



        private void dataGridViewUser_Click(object sender, EventArgs e)
        {
            txtProductId.Text = dataGridViewProduct.SelectedCells[0].Value.ToString();
            txtProductName.Text = dataGridViewProduct.SelectedCells[1].Value.ToString();
            txtProductQty.Text = dataGridViewProduct.SelectedCells[2].Value.ToString();
            txtProductPrice.Text = dataGridViewProduct.SelectedCells[3].Value.ToString();
            txtProductDescription.Text = dataGridViewProduct.SelectedCells[4].Value.ToString();
            comboBoxCategory.SelectedValue = dataGridViewProduct.SelectedCells[5].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillGridbyFilter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillCategory();
        }

        private void ManageProducts_FormClosed(object sender, FormClosedEventArgs e)
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

