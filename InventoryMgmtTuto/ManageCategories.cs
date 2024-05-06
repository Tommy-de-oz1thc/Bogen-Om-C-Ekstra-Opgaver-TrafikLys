using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace InventoryMgmtTuto
{
    public partial class ManageCategories : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=60");
        public ManageCategories()
        {
            InitializeComponent();

            dataGridViewCategories.EnableHeadersVisualStyles = false;
            dataGridViewCategories.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridViewCategories.RowHeadersVisible = false;

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
                txtCategoriesId.Text = "";
                txtCategoryName.Text = "";

                Con.Open();
                string Myquery = "Select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Con.Close();
                dataGridViewCategories.DataSource = ds.Tables[0];

            }
            catch { }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTbl values('" + txtCategoriesId.Text + "','" + txtCategoryName.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
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
                SqlCommand cmd = new SqlCommand("update CategoryTbl set CatId = '" + txtCategoriesId.Text + "', CatName ='" + txtCategoryName.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Updated");
                Con.Close();
                fillGrid();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCategoriesId.Text == "")
            {
                MessageBox.Show("Enter the Category Id");
            }
            else
            {
                Con.Open();
                string myquery = "Delete from CategoryTbl where CatId = '" + txtCategoriesId.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                fillGrid();
            }
        }



        private void dataGridViewUser_Click(object sender, EventArgs e)
        {
            txtCategoriesId.Text = dataGridViewCategories.SelectedCells[0].Value.ToString();
            txtCategoryName.Text = dataGridViewCategories.SelectedCells[1].Value.ToString();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}

