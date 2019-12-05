using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.Librarian
{
    public partial class BookReturn : System.Web.UI.Page
    {
        private bllLibrarian bll;

        public BookReturn()
        {
            bll = new bllLibrarian();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            int username = int.Parse(txtUsername.Text);
            List<bllLibrarian> books = bll.GetBookById(username);

            if (books != null)
            {
                gridBooks.DataSource = books;
                gridBooks.DataBind();

                lblMessage.Text = "Product found.";
                lblMessage.ForeColor = System.Drawing.Color.Green;


            }
            else
            { 
                lblMessage.Text = "Product not found.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            //int result = adpUsers.Update(user.Username, user.Password, user.Role, user.Fee, user.UserId );
        }
    }
}