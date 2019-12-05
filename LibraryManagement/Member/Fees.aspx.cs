using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.Member
{   //Author: Elizabeth Smikle
    public partial class Fees : System.Web.UI.Page
    {
        private BusinessLogicLayer bll;
        private int userId;

        public Fees()
        {
            bll = new BusinessLogicLayer();
            userId = 1;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string fees = bll.Fees.ToString("C");
            lblOverdueFees.Text = fees;
            List<BusinessLogicLayer> lstRequests = bll.GetRequestsById(userId);

            if(lstRequests != null)
            {
                grdFeeHistory.DataSource = lstRequests;
                grdFeeHistory.DataBind();
            }
            else
            {
                grdFeeHistory.DataSource = null;
                grdFeeHistory.DataBind();
            }

            if (bll.Fees == 0)
            {
                btnPayNow.Enabled = false;
                lblOverdueFees.Text = "No fees";
            }
        }

        protected void btnPayNow_Click(object sender, EventArgs e)
        {
            List<BusinessLogicLayer> books = bll.GetBooksByRenterId(userId);
            foreach(var book in books)
            {
                DateTime due = Convert.ToDateTime(book.DueDate);
                if(DateTime.Compare(due, DateTime.Now) < 0)
                {
                    BusinessLogicLayer request = new BusinessLogicLayer();
                    request.Id = book.Id;
                    request.RequestType = "Payment";
                    request.RequestStatus = "Pending Approval";

                    bll.InsertRequest(request, userId);
                }
            }

            lblMessage.Text = "Your payments are being processed";
        }
    }
}