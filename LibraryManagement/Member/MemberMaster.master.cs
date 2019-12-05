using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.Member
{
    public partial class MemberMaster : System.Web.UI.MasterPage
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserName.Text = (string)Session["UserId"];
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            
        }

        protected void lbtnDelete_Click(object sender, EventArgs e)
        {
            int userId = (int)Session["UserId"];
            BusinessLogicLayer request = new BusinessLogicLayer();
            request.RequestType = "Delete";
            request.Id = 0;
            request.RequestStatus = "Pending Approval";
            bll.InsertRequest(request, userId);
            Response.Write("<script>alert('Your delete request has been received')</script>");
        }
    }
}