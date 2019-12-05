using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagement.Admin.dsAdminTableAdapters;

namespace LibraryManagement.Admin
{
    public partial class ManageBooks : System.Web.UI.Page
    {

        BooksTableAdapter adpBooks = new BooksTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) RefreshGrid();
        }


        private void RefreshGrid()
        {
            grdBooks.DataSource = adpBooks.GetData();
            grdBooks.DataBind();
        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string publisher = txtPublisher.Text;
            string genre = txtGenre.Text;
            string author = txtAuthor.Text;
            int reIssue = int.Parse(txtReIssue.Text);

            if (title.Trim().Equals(""))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in empty title field";
                return;
            }

            int result = adpBooks.Insert(title, author, genre, null, null, publisher, reIssue);
            if (result == 1)
            {
                lblMessage.Text = "Book added successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshGrid();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Book not added";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int bookID = int.Parse(txtBookID.Text);
            int result = adpBooks.Delete(bookID);

            if (result == 1)
            {
                lblMessage.Text = "Book deleted successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshGrid();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Book not deleted";
            }
        }

        protected void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string publisher = txtPublisher.Text;
            string genre = txtGenre.Text;
            string author = txtAuthor.Text;
            int bookID = int.Parse(txtBookID.Text);
            int reIssue = int.Parse(txtReIssue.Text);


            if (title.Trim().Equals(""))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in empty title field";
                return;
            }

            int result = adpBooks.Update(title, author, genre, null, null, publisher, reIssue, bookID);
            if (result == 1)
            {
                lblMessage.Text = "Book added successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshGrid();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Book not added";
            }
        }
    }
}