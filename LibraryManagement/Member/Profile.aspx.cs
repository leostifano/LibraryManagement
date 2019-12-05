using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.Member
{
    public partial class Profile : System.Web.UI.Page
    {
        private BusinessLogicLayer bll;
        private int userId;

        public Profile()
        {
            bll = new BusinessLogicLayer();
            userId = (int)Session["UserId"];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            BusinessLogicLayer user = bll.GetUserInfo(userId)[0];
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer user = new BusinessLogicLayer();
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Fees = bll.Fees;

            bll.UpdateUser(user, userId);
        }
    }
}