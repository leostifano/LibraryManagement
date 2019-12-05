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
 * 
 */

namespace LibraryManagement.Admin
{
    public partial class ManagePublishers : System.Web.UI.Page
    {
        PublishersAdapter adpPublishers = new PublishersAdapter();
        BooksTableAdapter adpBooks = new BooksTableAdapter();

        dsAdmin.PublishersDataTable tblPublishers = new dsAdmin.PublishersDataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                RefreshList();

        }

        private void RefreshList()
        {
            tblPublishers = adpPublishers.GetPublishers();
            lstPublishers.DataSource = tblPublishers;
            lstPublishers.DataValueField = tblPublishers.PublisherColumn.ColumnName;
            lstPublishers.DataTextField = tblPublishers.PublisherColumn.ColumnName;
            lstPublishers.DataBind();

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            string publisher = txtNew.Text;
            if (publisher.Trim().Equals(""))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in the Publisher field";
                return;
            }

            int result = adpBooks.UpdatePublisher(publisher, lstPublishers.Text);
            if (result > 0)
            {
                lblMessage.Text = "Publisher updated successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshList();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Publisher not updated";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string Publisher = lstPublishers.Text;

            int result = adpBooks.DeletePublisher(Publisher);

            if (result == 1)
            {
                lblMessage.Text = "Publisher deleted successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                RefreshList();
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Publisher not deleted";
            }
        }
    }
}