using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_s_Lending_Administration.Lending;

namespace Library_s_Lending_Administration.Shared
{
    public partial class ForumForm : Form
    {
        private Person user;
        private Forum forum = new Forum();
        private List<Forum> listForum = new List<Forum>();
      
        public ForumForm(Person user)
        {
            
            this.user = user;

            InitializeComponent();
            if (user.Type_Of_User.ToString() == "Admin")
            {
                checkBoxDelete.Enabled = true;
                checkBoxDelete.Visible = true;
            }
                txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtAuthor.Text = user.Username;

            fillcomboBox();
        }
        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked)
            {
                btnDelete.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
            }
        }
        private void checkBoxReadPost_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReadPost.Checked)
            {
                comboBoxReadPost.Visible = true;
                btnWrite.Visible = false;
               
            }
            else 
            {
                comboBoxReadPost.Visible = false;
                btnWrite.Visible = true;
             
                txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                txtAuthor.Text = user.Username;
                
            }
        }

        private void fillcomboBox()
        {
            comboBoxReadPost.Items.Clear();
            comboBoxIdValue.Items.Clear();
         
            listForum = forum.getListForum();
            
            comboBoxReadPost.Items.Clear();
            foreach (Forum post in listForum)
            {
                comboBoxIdValue.Items.Add(post.Userid);
                comboBoxReadPost.Items.Add(post.Title);

            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
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
            foreach (Forum post in listForum) 
            {
                if(post.Userid == Id)
                {
                    txtTitle.Text = post.Title;
                    txtText.Text = post.Description;
                    txtAuthor.Text = post.Author;
                    txtDate.Text = post.WritingDate.ToString("dd-MM-yyyy");

                    
                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtText.Text = "";
            txtAuthor.Text = "";
            txtDate.Text = "";
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

        private void btnForumCreate_Click(object sender, EventArgs e)
        {
            // Generate a new unique GUID for the user
            Guid Id = Guid.NewGuid();

            // Define variables to hold user input
            string Title = txtTitle.Text;
            string Description = txtText.Text;
            string Author = user.Username;
           
            DateTime WritingDate;

            // Get the current date formatted as "dd-MM-yyyy"
            WritingDate = DateTime.Now;



            Forum newPost = new Forum();

            newPost.Userid = Id;
            newPost.Title = Title;
            newPost.Description = Description;
            newPost.Author = Author;

            newPost.WritingDate = WritingDate;
               
            

            // Add the new book to the list or database
            listForum.Add(newPost);
            forum.AddForumToCSV(newPost);

            // Clear input fields and update UI elements
            
            txtTitle.Text = "";
            txtText.Text = "";
            txtAuthor.Text = "";
            comboBoxReadPost.Items.Add(newPost.Title);
            comboBoxIdValue.Items.Add(newPost.Userid);
            MessageBox.Show(newPost.Title + " has been Added to the ComboBox");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected post's ID
            Guid selectedId = Guid.Parse(comboBoxIdValue.SelectedItem.ToString());

            // Find the post with the selected ID in the list
            Forum postToDelete = listForum.Find(post => post.Userid == selectedId);

            // Remove the post from the list and CSV
            if (postToDelete != null)
            {
                forum.removeListForumPost(postToDelete);
                forum.DeleteForumFromCSV(postToDelete, forum.getListForum());

                // Remove the post from ComboBoxes
                comboBoxReadPost.Items.Remove(postToDelete.Title);
                comboBoxIdValue.Items.Remove(postToDelete.Userid);

                // Clear input fields and show confirmation message
                txtTitle.Text = "";
                txtText.Text = "";
                txtAuthor.Text = "";
                txtDate.Text = "";
                MessageBox.Show(postToDelete.Title + " has been deleted from the ComboBox");
            }
            else
            {
                MessageBox.Show("No post selected for deletion");
            }
        }



    }
}
