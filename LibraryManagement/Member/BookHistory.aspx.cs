using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.Member
{
    public partial class BookHistory : System.Web.UI.Page
    {
        private BusinessLogicLayer bll;
        private int userId;

        public BookHistory()
        {
            bll = new BusinessLogicLayer();
            userId = 1;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<BusinessLogicLayer> lstBooks = bll.GetBookHistory(userId);
            if(lstBooks != null)
            {
                grdBookHistory.DataSource = lstBooks;
                grdBookHistory.DataBind();
            }
            else
            {
                grdBookHistory.DataSource = null;
                grdBookHistory.DataBind();
                lblMessage.Text = "No book history";
            }
        }
    }
}