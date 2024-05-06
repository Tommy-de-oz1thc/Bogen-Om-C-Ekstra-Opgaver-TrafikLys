using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryMgmtTuto
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=60");

        public Login()
        {
            InitializeComponent();
            setLabel();
        }

        private void setLabel()
        {
            labelName.ForeColor = Color.DarkBlue;
            labelName.Font = new Font("Arial", 5);
            labelName.Size = new Size(3, 350);
            labelName.BackColor = Color.DarkBlue;

            labelPassword.ForeColor = Color.DarkBlue;
            labelPassword.Font = new Font("Arial", 5);
            labelPassword.Size = new Size(3, 350);
            labelPassword.BackColor = Color.DarkBlue;
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            labelName.BackColor = Color.BlueViolet;
            labelName.ForeColor = Color.BlueViolet;
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            labelName.BackColor = Color.DarkBlue;
            labelName.ForeColor = Color.DarkBlue;
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            labelPassword.BackColor = Color.BlueViolet;
            labelPassword.ForeColor = Color.BlueViolet;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            labelPassword.BackColor = Color.DarkBlue;
            labelPassword.ForeColor = Color.DarkBlue;
        }

        private void checkBoxShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                // Show the password
                txtPassword.PasswordChar = '\0'; // Use null character to show the password
            }
            else
            {
                // Hide the password
                txtPassword.PasswordChar = '*'; // Or any other character you want to use as mask
            }
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
            btnLogin.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTbl where Uname = '" + txtName.Text + "' and Upassword = '" + txtPassword.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            { 
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UseName or Password");
            }
            Con.Close();
        }
    }
}
