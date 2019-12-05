using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagement.Admin.dsAdminTableAdapters;

/**
 * 
 * Author: Leonardo Stifano
 */

namespace LibraryManagement.Admin
{
    public partial class ManageUsers : System.Web.UI.Page
    {
        UsersTableAdapter adpUsers = new UsersTableAdapter();
        dsAdmin.UsersDataTable tblUsers = new dsAdmin.UsersDataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) RefreshGrid();
        }

        protected void ddlUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshGrid()
        {
            grdUsers.DataSource = adpUsers.GetData();
            grdUsers.DataBind();
        }

        protected void btnDeleteSelected0_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(txtUserID.Text);
            int result = adpUsers.Delete(userID);

            if (result == 1)
            {
                lblMessage.Text = "User deleted successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshGrid();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "User not deleted";
            }


        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username.Trim().Equals("") || password.Trim().Equals(""))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in empty username and password fields";
                return;
            }

            int result = adpUsers.Insert(username, password, ddlRole.Text);
            if(result == 1)
            {
                lblMessage.Text = "User added successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshGrid();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "User not added";
            }
        }

        protected void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int userID = int.Parse(txtUserID.Text);
            string role = ddlRole.Text;

            if (username.Trim().Equals("") || password.Trim().Equals(""))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in empty username and password fields";
                return;
            }

            int result = adpUsers.Update(username, password, role, userID); ;
            if (result == 1)
            {
                lblMessage.Text = "User updated successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshGrid();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "User not updated";
            }
        }
    }
}