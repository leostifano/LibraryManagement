using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.Member
{
    public partial class Home : System.Web.UI.Page
    {
        private BusinessLogicLayer bll;

        public Home()
        {
            bll = new BusinessLogicLayer();
        }

        private void RefreshGridView()
        {
            int userId = (int)Session["UserId"];
            List<BusinessLogicLayer> lstBooks = bll.GetBooksByRenterId(userId);
            List<BusinessLogicLayer> lstRequests = bll.GetRequestsById(userId);

            if(lstBooks != null)
            {
                grdBooks.DataSource = lstBooks;
                grdBooks.DataBind();
            }
            else
            {
                lblBooksGrid.Text = "No books issued";
                grdBooks.DataSource = null;
                grdBooks.DataBind();
            }

            if (lstRequests != null)
            {
                grdRequests.DataSource = lstRequests;
                grdRequests.DataBind();
            }
            else
            {
                lblRequestsGrid.Text = "No requests";
                grdRequests.DataSource = null;
                grdRequests.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                RefreshGridView();
        }
    }
}