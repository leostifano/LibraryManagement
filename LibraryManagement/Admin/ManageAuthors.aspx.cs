using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagement.Admin.dsAdminTableAdapters;

/**
 * Author: Leonardo Stifano
 * 
 */

namespace LibraryManagement.Admin
{
    public partial class ManageAuthors : System.Web.UI.Page
    {
        AuthorsAdapter adpAuthors = new AuthorsAdapter();
        BooksTableAdapter adpBooks = new BooksTableAdapter();

        dsAdmin.AuthorsDataTable tblAuthors = new dsAdmin.AuthorsDataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                RefreshList();

        }

        private void RefreshList()
        {
            tblAuthors = adpAuthors.GetAuthors();
            lstAuthors.DataSource = tblAuthors;
            lstAuthors.DataValueField = tblAuthors.AuthorColumn.ColumnName;
            lstAuthors.DataTextField = tblAuthors.AuthorColumn.ColumnName;
            lstAuthors.DataBind();

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            string author = txtNew.Text;
            if (author.Trim().Equals(""))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in the author field";
                return;
            }

            int result = adpBooks.UpdateAuthor(author, lstAuthors.Text);
            if (result > 0)
            {
                lblMessage.Text = "Author updated successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshList();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Author not updated";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string author = lstAuthors.Text;

            int result = adpBooks.DeleteAuthor(author);

            if (result == 1)
            {
                lblMessage.Text = "Author deleted successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshList();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Author not deleted";
            }
        }
    }
}