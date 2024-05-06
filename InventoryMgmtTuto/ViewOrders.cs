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
    public partial class ViewOrders : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=60");

        public ViewOrders()
        {
            InitializeComponent();
            fillGridOrders();
            dataGridViewOrder.EnableHeadersVisualStyles = false;
            dataGridViewOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridViewOrder.RowHeadersVisible = false;
        }

        private void fillGridOrders()
        {
            try
            {

                Con.Open();
                string Myquery = "Select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Con.Close();
                dataGridViewOrder.DataSource = ds.Tables[0];

            }
            catch { }

        }

        private void dataGridViewOrder_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summery", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new PointF(230, 1));

            e.Graphics.DrawString("Order Id:" + dataGridViewOrder.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 100));
            e.Graphics.DrawString("Customer Id:" + dataGridViewOrder.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 133));
            e.Graphics.DrawString("Customer Name:" + dataGridViewOrder.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 166));
            e.Graphics.DrawString("Oder Date:" + dataGridViewOrder.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 199));
            e.Graphics.DrawString("Customer Id:" + dataGridViewOrder.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 236));

            e.Graphics.DrawString("PoweredByCodeSpace", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new PointF(230, 350));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ManageOrders orders = new ManageOrders();
            orders.Show();
            this.Hide();
        }
    }
}
