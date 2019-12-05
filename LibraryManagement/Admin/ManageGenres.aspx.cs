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
 * 
 */

namespace LibraryManagement.Admin
{
    public partial class ManageGenres : System.Web.UI.Page
    {
        GenresAdapter adpGenres = new GenresAdapter();
        BooksTableAdapter adpBooks = new BooksTableAdapter();

        dsAdmin.GenresDataTable tblGenres = new dsAdmin.GenresDataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                RefreshList();

        }

        private void RefreshList()
        {
            tblGenres = adpGenres.GetGenres();
            lstGenres.DataSource = tblGenres;
            lstGenres.DataValueField = tblGenres.GenreColumn.ColumnName;
            lstGenres.DataTextField = tblGenres.GenreColumn.ColumnName;
            lstGenres.DataBind();

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            string genre = txtNew.Text;
            if (genre.Trim().Equals(""))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in the Genre field";
                return;
            }

            int result = adpBooks.UpdateGenre(genre, lstGenres.Text);
            if (result > 0)
            {
                lblMessage.Text = "Genre updated successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshList();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Genre not updated";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string genre = lstGenres.Text;

            int result = adpBooks.DeleteGenre(genre);

            if (result == 1)
            {
                lblMessage.Text = "Genre deleted successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshList();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Genre not deleted";
            }
        }
    }
}