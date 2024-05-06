using System;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
namespace InventoryMgmtTuto
{
    public partial class ManageUsers : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=60");
        public ManageUsers()
        {
            InitializeComponent();
            dataGridViewUser.EnableHeadersVisualStyles = false;
            dataGridViewUser.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridViewUser.RowHeadersVisible = false;


            fillGrid();


        }
        private void ManageUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fillGrid()
        {
            try
            {
                txtUserName.Text = "";
                txtFullName.Text = "";
                txtPassword.Text = "";
                txtPhone.Text = "";
                Con.Open();
                string Myquery = "Select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Con.Close();
                dataGridViewUser.DataSource = ds.Tables[0];

            }
            catch { }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + txtUserName.Text + "','" + txtFullName.Text + "','" + txtPassword.Text + "','" + txtPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
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
                SqlCommand cmd = new SqlCommand("update UserTbl set UName = '" + txtUserName.Text + "', UFullName ='" + txtFullName.Text + "', UPassword = '" + txtPassword.Text + "', UPhone = '" + txtPhone.Text + "' where UPhone = '" + txtPhone.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                fillGrid();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Enter the Users Phone number");
            }
            else
            {
                Con.Open();
                string myquery = "Delete from UserTbl where UPhone = '" + txtPhone.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                fillGrid();
            }
        }



        private void dataGridViewUser_Click(object sender, EventArgs e)
        {
            txtUserName.Text = dataGridViewUser.SelectedCells[0].Value.ToString();
            txtFullName.Text = dataGridViewUser.SelectedCells[1].Value.ToString();
            txtPassword.Text = dataGridViewUser.SelectedCells[2].Value.ToString();
            txtPhone.Text = dataGridViewUser.SelectedCells[3].Value.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            HomeForm home = new HomeForm();
            home.Show();

            // Show the login form again after the admin or user form is closed
           
        }
    }
}
