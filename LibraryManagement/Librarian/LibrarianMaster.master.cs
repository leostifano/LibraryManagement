using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.Librarian
{
    public partial class LibrarianMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Librarian/Default.aspx");
        }

        protected void btnIssueBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Librarian/IssueBook.aspx");
        }

        protected void btnBookReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Librarian/BookReturn.aspx");
        }

        protected void btnSearchLibrary_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Librarian/SearchLibrary.aspx");
        }

        protected void btnProfiles_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Librarian/Profiles.aspx");
        }

        protected void btnReports_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Librarian/Reports.aspx");
        }
    }
}