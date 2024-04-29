using Library_s_Lending_Administration.Lending;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_s_Lending_Administration.User
{
    public partial class UserDVDMoviesForm : Form
    {

        private List<DVDMovies> listDVDMovies = new List<DVDMovies>();
        private DVDMovies dvdMovies = new DVDMovies();
        private Person user { set; get; }
        private Lendings lendings = new Lendings();
        public UserDVDMoviesForm(Person user)
        {

            this.user = user;
            InitializeComponent();
            fillComboBox();
        }
        private void fillComboBox()
        {
            listDVDMovies = dvdMovies.readDVDMoviesCSV();
            comboBoxReadPost.Items.Clear();
            comboBoxIdValue.Items.Clear();
            foreach (DVDMovies post in listDVDMovies)
            {
                if (post.Status_for_Lending.ToString() == "Home")
                {
                    comboBoxIdValue.Items.Add(post.Id);
                    comboBoxReadPost.Items.Add(post.Title);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            // Clear input fields and update UI elements

            txtTitle.Text = "";
            txtText.Text = "";
            txtAuthor.Text = "";

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length > 0)
            {
                btnWrite.Visible = true;
                txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
            else
            {
                btnWrite.Visible = false;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            // Get the selected post's ID
            Guid selectedId = Guid.Parse(comboBoxIdValue.SelectedItem.ToString());

            // Find the post with the selected ID in the list
            DVDMovies postToDelete = listDVDMovies.Find(post => post.Id == selectedId);

            // Remove the post from the list and CSV
            if (postToDelete != null)
            {
                dvdMovies.removeListDVDMovies(postToDelete);
             

                // Remove the post from ComboBoxes
                comboBoxReadPost.Items.Remove(postToDelete.Title);
                comboBoxIdValue.Items.Remove(postToDelete.Id);

                // Add the deleted post to the lending.csv file
                string lendingCsvPath = StartForm.filePathLendings;
                using (StreamWriter sw = File.AppendText(lendingCsvPath))
                {
                    sw.WriteLine($"{Guid.NewGuid()},{user.UserId},{user.Username},{PaymentType.AdultBooks},{postToDelete.Id},{postToDelete.Title},{postToDelete.Description},{postToDelete.Author},{DateTime.Now}");

                }


                // Display the deleted post in the listBoxLentBooks
                listBoxLentBooks.Items.Add($"Title: {postToDelete.Title}, \tAuthor: {postToDelete.Author}");

                // Clear input fields and show confirmation message
                txtTitle.Text = "";
                txtText.Text = "";
                txtAuthor.Text = "";
                txtDate.Text = "";
                comboBoxReadPost.Text = "Select a item";
                MessageBox.Show(postToDelete.Title + " has been deleted from the ComboBox");
            }
            else
            {
                MessageBox.Show("No post selected for deletion");
            }
            fillComboBox();
        }
        private void comboBoxReadPost_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox changedComboBox = sender as ComboBox;

            // Sørg for, at både comboBoxReadPost og comboBoxIdValue er opdateret
            if (changedComboBox == comboBoxReadPost || changedComboBox == comboBoxIdValue)
            {
                int selectedIndex = changedComboBox.SelectedIndex;

                // Opdater den anden ComboBox for at matche den valgte indeks
                if (changedComboBox == comboBoxReadPost && selectedIndex >= 0 && selectedIndex < comboBoxIdValue.Items.Count)
                {
                    comboBoxIdValue.SelectedIndex = selectedIndex;
                }
                else if (changedComboBox == comboBoxIdValue && selectedIndex >= 0 && selectedIndex < comboBoxReadPost.Items.Count)
                {
                    comboBoxReadPost.SelectedIndex = selectedIndex;
                }
            }

            // Vis valgt tekst fra comboBoxIdValue i en MessageBox
            Guid Id = Guid.Parse(comboBoxIdValue.SelectedItem.ToString());
            foreach (DVDMovies post in listDVDMovies)
            {
                if (post.Id == Id)
                {
                    txtTitle.Text = post.Title;
                    txtText.Text = post.Description;
                    txtAuthor.Text = post.Author;
                    txtDate.Text = post.RendingDate.ToString("dd-MM-yyyy");


                }
            }

        }

    }
}
