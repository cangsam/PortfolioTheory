using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace portfolioServices
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            var username = usernameTxt.Text;
            var passward = passwordTxt.Text;
            Session["token"] = Guid.NewGuid().ToString();
            Page.Response.Redirect("");
        }
    }
}