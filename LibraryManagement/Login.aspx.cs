using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagement.dsLoginTableAdapters;

/**Author: Leonardo Stifano
* This is the login page which checks if the user has valid login and
* links the user to a page based on their role
*/


namespace LibraryManagement
{
    public partial class Login : System.Web.UI.Page
    {
        UsersTableAdapter adpUser = new UsersTableAdapter();
        dsLogin.UsersDataTable tblUser = new dsLogin.UsersDataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /*
         * Checks if the user is valid
         * Uses forms authentication to ensure roles work
         * 
         */
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            tblUser = adpUser.GetUserByUsernameAndPassword(txtUsername.Text, txtPassword.Text);

            if (tblUser.Count == 0)
            {
                lblMsg.Enabled = true;
                return;
            }

            var row = tblUser[0];

            FormsAuthentication.Initialize();

            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, row.UserId.ToString(), DateTime.Now, DateTime.Now.AddMinutes(30), false, row.role);

            string hashedTicket = FormsAuthentication.Encrypt(ticket);

            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashedTicket);

            Response.Cookies.Add(cookie);

            string returnUrl = "";
            if (row.role == "Admin")
            {
                returnUrl = "~/Admin/";
            }

            else if (row.role == "Member")
            {
                returnUrl = "~/Member/";
            }

            else if (row.role == "Librarian")
            {
                returnUrl = "~/Librarian/";
            }

            else
            {
                returnUrl = "~/";
            }

            Session["Username"] = txtUsername.Text;
            Session["Role"] = row.role;

            Response.Redirect(returnUrl);






        }
    }
}